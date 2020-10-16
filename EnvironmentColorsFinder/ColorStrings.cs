namespace EnvironmentColorsFinder {
    using System.Drawing;
    using System.Globalization;
    using System.Text.RegularExpressions;

    public static class ColorStrings {
        public static Color? ToColor(this string rgbHex) {
            if (!Regex.IsMatch(rgbHex, "^[0-9A-Fa-f]{6}$")) return null;

            var rHex = rgbHex.Substring(0, 2);
            var gHex = rgbHex.Substring(2, 2);
            var bHex = rgbHex.Substring(4, 2);

            var r = byte.Parse(rHex, NumberStyles.AllowHexSpecifier);
            var g = byte.Parse(gHex, NumberStyles.AllowHexSpecifier);
            var b = byte.Parse(bHex, NumberStyles.AllowHexSpecifier);

            return Color.FromArgb(r, g, b);
        }

        public static string ToHex(this Color c) => c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
    }
}
