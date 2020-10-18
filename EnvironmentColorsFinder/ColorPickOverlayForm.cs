namespace EnvironmentColorsFinder {
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class ColorPickOverlayForm : Form {
        public Action<Color> HandlePicked { get; set; }

        public ColorPickOverlayForm() => InitializeComponent();

        private void ColorPickOverlay_Click(object sender, EventArgs e) {
            var click = (MouseEventArgs)e;

            Opacity = 0;
            var color = Screen.FromControl(this).GetPixel(click.Location);

            Owner.Show();
            HandlePicked(color);

            Close();
        }

        protected override bool ProcessDialogKey(Keys keyData) {
            if (keyData == Keys.Escape && ModifierKeys == Keys.None) {
                Owner.Show();
                Close();
                return true;
            }

            return base.ProcessDialogKey(keyData);
        }
    }

    public static class GetPixelExt {
        public static Color GetPixel(this Screen screen, Point location) {
            var pixel = new Bitmap(1, 1);
            var screenOffset = (Size)screen.Bounds.Location;
            Graphics.FromImage(pixel).CopyFromScreen(
                upperLeftSource:      location + screenOffset,
                upperLeftDestination: new Point(0, 0),
                blockRegionSize:      new Size(1, 1));
            return pixel.GetPixel(0, 0);
        }
    }
}
