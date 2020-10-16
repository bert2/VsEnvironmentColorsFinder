namespace ColorDatabaseGenerator {
    using System;
    using System.Drawing;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading;

    using Microsoft.VisualStudio.PlatformUI;
    using Microsoft.VisualStudio.Shell;

    using Task = System.Threading.Tasks.Task;

    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [Guid(PackageGuids.PackageIdString)]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    public sealed class ColorDatabaseGeneratorPackage : AsyncPackage {
        public static readonly Entry[] DB = new[] {
            typeof(CommonControlsColors),
            typeof(CommonDocumentColors),
            typeof(EnvironmentColors),
            typeof(HeaderColors),
            typeof(InfoBarColors),
            typeof(ProgressBarColors),
            typeof(SearchControlColors),
            typeof(StartPageColors),
            typeof(ThemedDialogColors),
            typeof(TreeViewColors),
            typeof(UnthemedDialogColors),
            typeof(VisualStudioInstallerColors)
        }
        .SelectMany(
            t => t
                .GetProperties()
                .Where(p
                    => p.PropertyType == typeof(ThemeResourceKey)
                    && p.Name.EndsWith("ColorKey")),
            Entry.Create)
        .ToArray();

        protected override async Task InitializeAsync(CancellationToken ct, IProgress<ServiceProgressData> progress) {
            await JoinableTaskFactory.SwitchToMainThreadAsync(ct);
            await GrabDarkThemeColorsCommand.InitializeAsync(this);
            await GrabLightThemeColorsCommand.InitializeAsync(this);
            await GrabBlueThemeColorsCommand.InitializeAsync(this);
            await CopyThemeColorsToClipboardCommand.InitializeAsync(this);
        }
    }

    public enum Theme { Dark = 0, Blue = 1, Light = 2 }

    public class Entry {
        public readonly string Name;
        public readonly ThemeResourceKey Key;
        public Color this[Theme t] {
            get => colors[(int)t];
            set => colors[(int)t] = value;
        }
        public readonly Color[] colors = new Color[3];
        public Entry(string name, ThemeResourceKey key) => (Name, Key) = (name, key);
        public static Entry Create(Type declaringType, PropertyInfo keyProp) => new Entry(
            $"{declaringType.Name}.{keyProp.Name}",
            (ThemeResourceKey)keyProp.GetValue(null));
        public override string ToString() => new StringBuilder(capacity: 100)
            .Append(Name).Append(": ")
            .Append(Hex(this[Theme.Dark])).Append(" (d), ")
            .Append(Hex(this[Theme.Blue])).Append(" (b), ")
            .Append(Hex(this[Theme.Light])).Append(" (l)")
            .ToString();
        private static string Hex(Color c) => c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
    }
}
