# ColorDatabaseGenerator

This is a Visual Studio extension used to generate the data needed for the [`ColorDatabase`](../EnvironmentColorsFinder/ColorDatabase.cs).

## Prerequisites

* Installed [Visual Studio SDK](https://docs.microsoft.com/en-us/visualstudio/extensibility/installing-the-visual-studio-sdk?view=vs-2019).

## Usage

1. Start this project in Visual Studio which will fire up the VS experimental instance with this extension.
2. In the VS experimental instance, you'll find four new entries in the `Tools` menu:
  * `Grab Dark Theme Colors`
  * `Grab Light Theme Colors`
  * `Grab Blue Theme Colors`
  * `Copy Theme Colors to Clipboard`
3. Click the `Grab ...` entry for the theme which the VS experimental instance is currently set to.
4. Change the theme of the VS experimental instance under `Tools/Options/Environment/General/Color Theme`.
5. Click the respective `Grab ...` entry.
6. Repeat step 4 and 5 for the last theme.
7. Click `Copy Theme Colors to Clipboard`.
8. Your clipboard will now contain the entries that can be pasted into the [`ColorDatabase`](../EnvironmentColorsFinder/ColorDatabase.cs).
