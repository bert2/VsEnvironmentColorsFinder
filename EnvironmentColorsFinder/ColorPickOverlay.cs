namespace EnvironmentColorsFinder {
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Windows.Forms;

    public partial class ColorPickOverlay : Form {
        private readonly MainForm mainForm;
        private readonly Action<Color> handlePickedColor;

        public ColorPickOverlay(MainForm owner, Action<Color> handlePickedColor) {
            InitializeComponent();
            mainForm = owner;
            this.handlePickedColor = handlePickedColor;
        }

        private void ColorPickOverlay_Click(object sender, EventArgs e) {
            var click = (MouseEventArgs)e;

            Opacity = 0;

            var screen = Screen.FromControl(this);
            var bitmap = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
            var gfx = Graphics.FromImage(bitmap);
            gfx.CopyFromScreen(click.Location, new Point(0, 0), new Size(1, 1));

            mainForm.Show();
            handlePickedColor(bitmap.GetPixel(0, 0));

            Close();
        }
    }
}
