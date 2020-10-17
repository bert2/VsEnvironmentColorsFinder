namespace EnvironmentColorsFinder {
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;

    using ColorMine.ColorSpaces;
    using ColorMine.ColorSpaces.Comparisons;

    public static class ColorDiff {
        public static List<ColorMatch> CalculateBestMatches(this ColorDbEntry[] db, Color? dark, Color? light, Color? blue) =>
            (from e in db
             let diff = e.CalculateColorDiff(dark, light, blue)
             orderby diff
             select new ColorMatch(e.Name, e.Dark, e.Light, e.Blue, diff))
            .ToList();

        public static double CalculateColorDiff(this ColorDbEntry e, Color? dark, Color? light, Color? blue) {
            var diffs = new List<double>(capacity: 3);
            if (dark != null) diffs.Add(dark.Value.Diff(e.Dark));
            if (light != null) diffs.Add(light.Value.Diff(e.Light));
            if (blue != null) diffs.Add(blue.Value.Diff(e.Blue));
            return diffs.Count > 0 ? diffs.Average() : .0;
        }

        public static double Diff(this Color a, Color b) => a.ToRgb().Compare(b.ToRgb(), new Cie1976Comparison());

        private static Rgb ToRgb(this Color c) => new Rgb { R = c.R, G = c.G, B = c.B };
    }
}
