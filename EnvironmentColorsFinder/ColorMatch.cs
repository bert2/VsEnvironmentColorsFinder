namespace EnvironmentColorsFinder {
    using System.Drawing;

    public struct ColorMatch {
        public ColorMatch(string name, Color dark, Color light, Color blue, uint diff) {
            Name = name;
            Dark = dark;
            Light = light;
            Blue = blue;
            Diff = diff;
        }

        public string Name;
        public uint Diff;
        public Color Dark;
        public Color Light;
        public Color Blue;
    }
}
