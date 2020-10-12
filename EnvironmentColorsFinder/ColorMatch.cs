using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace EnvironmentColorsFinder
{
    public struct ColorMatch
    {
        public ColorMatch(string name, Color dark, Color light, Color blue, uint diff)
        {
            this.Name = name;
            this.Dark = dark;
            this.Light = light;
            this.Blue = blue;
            this.Diff = diff;
        }

        public string Name;
        public uint Diff;
        public Color Dark;
        public Color Light;
        public Color Blue;
    }
}
