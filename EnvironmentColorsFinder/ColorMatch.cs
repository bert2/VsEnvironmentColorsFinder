namespace EnvironmentColorsFinder {
    using System.Drawing;

    public struct ColorMatch {
        public ColorMatch(string name, Color dark, Color light, Color blue, int diff) {
            Name = name;
            Dark = dark;
            Light = light;
            Blue = blue;
            Diff = diff;
        }

        public string Name;
        public int Diff;
        public Color Dark;
        public Color Light;
        public Color Blue;
    }
}
