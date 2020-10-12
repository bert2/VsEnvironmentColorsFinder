using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace EnvironmentColorsFinder
{
    internal static class ColorHelpers
    {
        public static Color ParseColor(string rgbHexString)
        {
            if (rgbHexString.Length != 6)
                throw new ArgumentException("rgbHexString must be a 6 character (RRGGBB) RGB hex string");

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

        public static string GetHexStringFromColor(Color color) =>
            color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");

        public static uint CalculateColorDiff(Color a, Color b) =>
            CalculateColorElementDiff(a.R, b.R) +
            CalculateColorElementDiff(a.G, b.G) +
            CalculateColorElementDiff(a.B, b.B);

        private static uint CalculateColorElementDiff(byte a, byte b)
        {
            var diff = (int)a - (int)b;
            var euclideanDiff = (uint)(diff * diff);
            return euclideanDiff;
        }
    }
}
