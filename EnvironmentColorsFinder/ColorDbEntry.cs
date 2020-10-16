namespace EnvironmentColorsFinder {
    using System.Drawing;

    // Don't change anything here without changing the contructor call in the ColorDatabaseGenerator.
    public struct Entry {
        public Entry(string name, Color dark, Color light, Color blue) {
            Name = name;
            Dark = dark;
            Light = light;
            Blue = blue;
        }

        public string Name;
        public Color Dark;
        public Color Light;
        public Color Blue;
    }
}
