namespace EnvironmentColorsFinder {
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Windows.Forms;

    public partial class ColorPickOverlayForm : Form {
        private readonly Action<Color> handlePicked;

        public ColorPickOverlayForm( Action<Color> handlePicked) {
            InitializeComponent();
            this.handlePicked = handlePicked;
        }

        private void ColorPickOverlay_Click(object sender, EventArgs e) {
            var click = (MouseEventArgs)e;

            Opacity = 0;

            var bitmap = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
            var gfx = Graphics.FromImage(bitmap);
            var screen = Screen.FromControl(this);
            gfx.CopyFromScreen(
                new Point(
                    click.Location.X + screen.Bounds.Location.X,
                    click.Location.Y + screen.Bounds.Location.Y),
                new Point(0, 0),
                new Size(1, 1));

            Owner.Show();
            handlePicked(bitmap.GetPixel(0, 0));

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
}
