namespace EnvironmentColorsFinder {
    using System.Drawing;

    public struct ColorMatch {
        public ColorMatch(string name, Color dark, Color light, Color blue, double diff) {
            Name = name;
            Dark = dark;
            Light = light;
            Blue = blue;
            Diff = diff;
        }

        public string Name;
        public double Diff;
        public Color Dark;
        public Color Light;
        public Color Blue;
    }
}
