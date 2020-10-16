namespace EnvironmentColorsFinder {
    using System.Drawing;
    using System.Globalization;
    using System.Text.RegularExpressions;

    public static class ColorHelpers {
        public static Color? ParseColor(string rgbHexString) {
            if (!Regex.IsMatch(rgbHexString, "^[0-9A-Fa-f]{6}$")) return null;

            var redHexString = rgbHexString.Substring(0, 2);
            var greenHexString = rgbHexString.Substring(2, 2);
            var blueHexString = rgbHexString.Substring(4, 2);

            var red = ParseHexByte(redHexString);
            var green = ParseHexByte(greenHexString);
            var blue = ParseHexByte(blueHexString);

            return Color.FromArgb(red, green, blue);
        }

        public static string ToHex(this Color c) => c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");

        public static int CalculateColorDiff(Color a, Color b) =>
            CalculateColorElementDiff(a.R, b.R) +
            CalculateColorElementDiff(a.G, b.G) +
            CalculateColorElementDiff(a.B, b.B);

        private static int CalculateColorElementDiff(byte a, byte b) {
            var diff = a - b;
            return diff * diff;
        }

        private static byte ParseHexByte(string hex) => byte.Parse(hex, NumberStyles.AllowHexSpecifier);
    }
}
