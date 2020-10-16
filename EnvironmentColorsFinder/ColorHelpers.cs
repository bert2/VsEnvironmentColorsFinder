using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;

namespace EnvironmentColorsFinder
{
    internal static class ColorHelpers
    {
        public static Color? ParseColor(string rgbHexString)
        {
            if (!Regex.IsMatch(rgbHexString, "^[0-9A-Fa-f]{6}$")) return null;

            var redHexString = rgbHexString.Substring(0, 2);
            var greenHexString = rgbHexString.Substring(2, 2);
            var blueHexString = rgbHexString.Substring(4, 2);

            var red = ParseHexByte(redHexString);
            var green = ParseHexByte(greenHexString);
            var blue = ParseHexByte(blueHexString);

            return Color.FromArgb(red, green, blue);
        }

        private static byte ParseHexByte(string hexString) =>
            (byte)int.Parse(hexString, System.Globalization.NumberStyles.AllowHexSpecifier);

        public static string ToHex(this Color c) => c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");

        public static uint CalculateColorDiff(Color a, Color b) =>
            CalculateColorElementDiff(a.R, b.R) +
            CalculateColorElementDiff(a.G, b.G) +
            CalculateColorElementDiff(a.B, b.B);

        private static uint CalculateColorElementDiff(byte a, byte b)
        {
            var diff = a - b;
            return (uint)(diff * diff);
        }
    }
}
