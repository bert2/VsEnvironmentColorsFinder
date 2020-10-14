namespace ColorDatabaseGenerator {
    using System.ComponentModel.Design;

    using Microsoft;
    using Microsoft.VisualStudio.Shell;
    using Microsoft.VisualStudio.Shell.Interop;

    using Task = System.Threading.Tasks.Task;

    internal sealed class GrabLightThemeColorsCommand {
        public static async Task InitializeAsync(AsyncPackage pkg) {
            await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync(pkg.DisposalToken);

            var cmdService = await pkg.GetServiceAsync<IMenuCommandService, IMenuCommandService>();
            Assumes.Present(cmdService);

            var cmdId = new CommandID(PackageGuids.CmdSetId, PackageIds.GrabLightThemeColorsCommandId);
            var cmd = new OleMenuCommand(
                (_, __) => ThreadHelper.JoinableTaskFactory.RunAsync(async delegate {
                    await Execute(pkg);
                }),
                cmdId);

            cmdService.AddCommand(cmd);
        }

        public static async Task Execute(AsyncPackage pkg) {
            var shell = await pkg.GetServiceAsync<SVsUIShell, IVsUIShell5>();

            foreach (var entry in ColorDatabaseGeneratorPackage.DB)
                entry[Theme.Light] = shell.GetThemedGDIColor(entry.Key);

            _ = VsShellUtilities.ShowMessageBox(
                pkg,
                "Light theme colors stored in memory.",
                "Done!",
                OLEMSGICON.OLEMSGICON_INFO,
                OLEMSGBUTTON.OLEMSGBUTTON_OK,
                OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST
            );
        }
    }
}