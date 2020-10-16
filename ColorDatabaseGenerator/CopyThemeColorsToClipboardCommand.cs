namespace ColorDatabaseGenerator {
    using System.ComponentModel.Design;
    using System.Linq;
    using System.Text;
    using System.Windows;

    using Microsoft;
    using Microsoft.VisualStudio.Shell;
    using Microsoft.VisualStudio.Shell.Interop;

    using Task = System.Threading.Tasks.Task;

    internal sealed class CopyThemeColorsToClipboardCommand {
        public static async Task InitializeAsync(AsyncPackage pkg) {
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(pkg.DisposalToken);

            var cmdService = await pkg.GetServiceAsync<IMenuCommandService, IMenuCommandService>();
            Assumes.Present(cmdService);

            var cmdId = new CommandID(PackageGuids.CmdSetId, PackageIds.CopyThemeColorsToClipboardCommandId);
            var cmd = new OleMenuCommand((_, __) => Execute(pkg), cmdId);

            cmdService.AddCommand(cmd);
        }

        public static void Execute(AsyncPackage pkg) {
            var text = ColorDatabaseGeneratorPackage.DB
                .Aggregate(
                    new StringBuilder(capacity: 176 * ColorDatabaseGeneratorPackage.DB.Length),
                    (sb, e) => sb
                        .Append("new ColorDbEntry(")
                            .Append('\"').Append(e.Name).Append("\", ")
                            .Append("Color.FromArgb(")
                                .Append(e[Theme.Dark].R).Append(',')
                                .Append(e[Theme.Dark].G).Append(',')
                                .Append(e[Theme.Dark].B)
                            .Append("), ")
                            .Append("Color.FromArgb(")
                                .Append(e[Theme.Light].R).Append(',')
                                .Append(e[Theme.Light].G).Append(',')
                                .Append(e[Theme.Light].B)
                            .Append("), ")
                            .Append("Color.FromArgb(")
                                .Append(e[Theme.Blue].R).Append(',')
                                .Append(e[Theme.Blue].G).Append(',')
                                .Append(e[Theme.Blue].B)
                            .Append(')')
                        .Append("),")
                        .AppendLine())
                .ToString();

            Clipboard.SetText(text);

            _ = VsShellUtilities.ShowMessageBox(
                pkg,
                "Theme colors copied to clipboard.",
                "Done!",
                OLEMSGICON.OLEMSGICON_INFO,
                OLEMSGBUTTON.OLEMSGBUTTON_OK,
                OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST
            );
        }
    }
}