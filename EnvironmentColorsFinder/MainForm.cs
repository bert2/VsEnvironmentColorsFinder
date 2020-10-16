namespace EnvironmentColorsFinder {
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class MainForm : Form {
        private const int MinNumMatchesToList = 20;
        private readonly ToolTip toolTip = new ToolTip();
        private readonly ColorDatabase colorDatabase = new ColorDatabase();
        private List<ColorMatch> bestMatches;

        public MainForm() {
            InitializeComponent();
            toolTip.SetToolTip(pickDarkDesiredColorBtn, "Pick color from screen.");
            toolTip.SetToolTip(pickLightDesiredColorBtn, "Pick color from screen.");
            toolTip.SetToolTip(pickBlueDesiredColorBtn, "Pick color from screen.");
        }

        private void MainForm_Load(object sender, EventArgs e) => RefreshEverything();

        private void RefreshEverything() {
            Color? desiredDarkColor = null;
            Color? desiredLightColor = null;
            Color? desiredBlueColor = null;

            // Get the colors from the RGB hex strings that the user has entered.
            if (darkDesiredColorChk.Checked)
                desiredDarkColor = ColorHelpers.ParseColor(darkDesiredColorTxt.Text);
            if (lightDesiredColorChk.Checked)
                desiredLightColor = ColorHelpers.ParseColor(lightDesiredColorTxt.Text);
            if (blueDesiredColorChk.Checked)
                desiredBlueColor = ColorHelpers.ParseColor(blueDesiredColorTxt.Text);

            // Show the selected colors under the textboxes,
            // or black if the theme is not selected for inclusion.
            darkDesiredColorPic.BackColor = desiredDarkColor ?? Color.Black;
            lightDesiredColorPic.BackColor = desiredLightColor ?? Color.Black;
            blueDesiredColorPic.BackColor = desiredBlueColor ?? Color.Black;

            // Calculate the best matches for the user-entered color hex strings.
            bestMatches = colorDatabase.CalculateBestMatches(desiredDarkColor, desiredLightColor, desiredBlueColor);

            // Populate the dropdown with the best matches.
            bestMatchesCmb.Items.Clear();
            foreach (var bestMatch in bestMatches) {
                // We want to shoe all the matches that have a diff of zero,
                // but we should always show at least MaxNumMatchesToList matches in any case.
                if (bestMatch.Diff == 0 || bestMatchesCmb.Items.Count < MinNumMatchesToList) {
                    _ = bestMatchesCmb.Items.Add(string.Format($"{bestMatch.Name} ({bestMatch.Diff})"));
                } else {
                    break;
                }
            }
            bestMatchesCmb.SelectedIndex = 0;
        }

        private void bestMatchesCmb_SelectedIndexChanged(object sender, EventArgs e) {
            var bestMatch = bestMatches[bestMatchesCmb.SelectedIndex];
            darkBestMatchPic.BackColor = bestMatch.Dark;
            lightBestMatchPic.BackColor = bestMatch.Light;
            blueBestMatchPic.BackColor = bestMatch.Blue;
        }

        private void DarkDesiredColorChk_CheckedChanged(object sender, EventArgs e) {
            darkDesiredColorTxt.Enabled = darkDesiredColorChk.Checked;
            RefreshEverything();
        }

        private void LightDesiredColorChk_CheckedChanged(object sender, EventArgs e) {
            lightDesiredColorTxt.Enabled = lightDesiredColorChk.Checked;
            RefreshEverything();
        }

        private void BlueDesiredColorChk_CheckedChanged(object sender, EventArgs e) {
            blueDesiredColorTxt.Enabled = blueDesiredColorChk.Checked;
            RefreshEverything();
        }

        private void DarkDesiredColorPic_Click(object sender, EventArgs e)
            => OnDesiredColorPicClick(darkDesiredColorPic, darkDesiredColorTxt);

        private void LightDesiredColorPic_Click(object sender, EventArgs e)
            => OnDesiredColorPicClick(lightDesiredColorPic, lightDesiredColorTxt);

        private void BlueDesiredColorPic_Click(object sender, EventArgs e)
            => OnDesiredColorPicClick(blueDesiredColorPic, blueDesiredColorTxt);

        private void OnDesiredColorPicClick(PictureBox desiredColorPic, TextBox desiredColorTxt) {
            colorPickerDlg.Color = desiredColorPic.BackColor;
            var result = colorPickerDlg.ShowDialog();
            if (result == DialogResult.OK) {
                desiredColorTxt.Text = colorPickerDlg.Color.ToHex();
                RefreshEverything();
            }
        }

        private void DarkDesiredColorTxt_TextChanged(object sender, EventArgs e) => RefreshEverything();

        private void LightDesiredColorTxt_TextChanged(object sender, EventArgs e) => RefreshEverything();

        private void BlueDesiredColorTxt_TextChanged(object sender, EventArgs e) => RefreshEverything();

        private void PickDarkDesiredColorBtn_Click(object sender, EventArgs e) => OnPickDesiredColorBtnClick(darkDesiredColorTxt);

        private void PickLightDesiredColorBtn_Click(object sender, EventArgs e) => OnPickDesiredColorBtnClick(lightDesiredColorTxt);

        private void PickBlueDesiredColorBtn_Click(object sender, EventArgs e) => OnPickDesiredColorBtnClick(blueDesiredColorTxt);

        private void OnPickDesiredColorBtnClick(TextBox desiredColorTxt) {
            Hide();
            new ColorPickOverlayFrm(this, c => desiredColorTxt.Text = c.ToHex()).Show();
        }

        private void CopyToClipboardBtn_Click(object sender, EventArgs e) {
            if (bestMatches.Count > 0) {
                var bestMatch = bestMatches[bestMatchesCmb.SelectedIndex];
                var copyText = bestMatch.Name;
                Clipboard.SetText(copyText);
            }
        }

        private void darkBestMatchPic_MouseHover(object sender, EventArgs e) => OnBestMatchPicMouseOver(darkBestMatchPic);

        private void lightBestMatchPic_MouseHover(object sender, EventArgs e) => OnBestMatchPicMouseOver(lightBestMatchPic);

        private void blueBestMatchPic_MouseHover(object sender, EventArgs e) => OnBestMatchPicMouseOver(blueBestMatchPic);

        private void OnBestMatchPicMouseOver(PictureBox bestMatchPic)
            => toolTip.SetToolTip(bestMatchPic, bestMatchPic.BackColor.ToHex());
    }
}
