# EnvironmentColors finder

Updated version of the [EnvironmentColors finder](http://niahtextfilter.com/environmentcolorsfinder) created by Grant Davies.

![Usage example](usage.gif "Usage example")

## Added features

* Pick a color directly from the screen, so you don't have to do the "take screenshot, open screenshot in Paint, pick color, copy & paste color value" routine anymore.
* Includes all color enumerations from `Microsoft.VisualStudio.PlatformUI` (Microsoft.VistualStudio.Shell.15.0), not just `EnvironmentColors`.
* [Dummy VS extension](./ColorDatabaseGenerator/) to generate the color database.
* Uses [CIE76](https://en.wikipedia.org/wiki/Color_difference#CIE76) to match colors instead of Euclidean distance.
* Resizable layout, because the property names can get really long.

## Credits

* [Orignal version](http://niahtextfilter.com/environmentcolorsfinder) ([source code](https://bitbucket.org/grantdavies/vsenvironmentcolorsfinder/src/master)) was created by [Grant Davies](https://twitter.com/GrantTheAnt).
* [ColorMine](https://www.nuget.org/packages/ColorMine) is used to calculate color differences.
