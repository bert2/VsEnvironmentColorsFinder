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
            toolTip.SetToolTip(pickDarkThemeDesiredColorBtn, "Pick color from screen.");
            toolTip.SetToolTip(pickLightThemeDesiredColorBtn, "Pick color from screen.");
            toolTip.SetToolTip(pickBlueThemeDesiredColorBtn, "Pick color from screen.");
        }

        private void MainForm_Load(object sender, EventArgs e) => RefreshEverything();

        private void RefreshEverything() {
            Color? desiredDarkColor = null;
            Color? desiredLightColor = null;
            Color? desiredBlueColor = null;

            // Get the colors from the RGB hex strings that the user has entered.
            if (darkThemeDesiredColorCheckBox.Checked)
                desiredDarkColor = ColorHelpers.ParseColor(darkThemeDesiredColorTextBox.Text);
            if (lightThemeDesiredColorCheckBox.Checked)
                desiredLightColor = ColorHelpers.ParseColor(lightThemeDesiredColorTextBox.Text);
            if (blueThemeDesiredColorCheckBox.Checked)
                desiredBlueColor = ColorHelpers.ParseColor(blueThemeDesiredColorTextBox.Text);

            // Show the selected colors under the textboxes,
            // or black if the theme is not selected for inclusion.
            darkThemeDesiredColorPictureBox.BackColor = desiredDarkColor ?? Color.Black;
            lightThemeDesiredColorPictureBox.BackColor = desiredLightColor ?? Color.Black;
            blueThemeDesiredColorPictureBox.BackColor = desiredBlueColor ?? Color.Black;

            // Calculate the best matches for the user-entered color hex strings.
            bestMatches = colorDatabase.CalculateBestMatches(desiredDarkColor, desiredLightColor, desiredBlueColor);

            // Populate the dropdown with the best matches.
            bestMatchesComboBox.Items.Clear();
            foreach (var bestMatch in bestMatches) {
                // We want to shoe all the matches that have a diff of zero,
                // but we should always show at least MaxNumMatchesToList matches in any case.
                if (bestMatch.Diff == 0 || bestMatchesComboBox.Items.Count < MinNumMatchesToList) {
                    _ = bestMatchesComboBox.Items.Add(string.Format($"{bestMatch.Name} ({bestMatch.Diff})"));
                } else {
                    break;
                }
            }
            bestMatchesComboBox.SelectedIndex = 0;
        }

        private void refreshButton_Click(object sender, EventArgs e) {
            RefreshEverything();
        }

        private void bestMatchesComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            var bestMatch = bestMatches[bestMatchesComboBox.SelectedIndex];

            darkThemeBestMatchPictureBox.BackColor = bestMatch.Dark;
            lightThemeBestMatchPictureBox.BackColor = bestMatch.Light;
            blueThemeBestMatchPictureBox.BackColor = bestMatch.Blue;
        }

        private void DarkThemeDesiredColorCheckBox_CheckedChanged(object sender, EventArgs e) {
            darkThemeDesiredColorTextBox.Enabled = darkThemeDesiredColorCheckBox.Checked;
            RefreshEverything();
        }

        private void LightThemeDesiredColorCheckBox_CheckedChanged(object sender, EventArgs e) {
            lightThemeDesiredColorTextBox.Enabled = lightThemeDesiredColorCheckBox.Checked;
            RefreshEverything();
        }

        private void BlueThemeDesiredColorCheckBox_CheckedChanged(object sender, EventArgs e) {
            blueThemeDesiredColorTextBox.Enabled = blueThemeDesiredColorCheckBox.Checked;
            RefreshEverything();
        }

        private void DarkThemeDesiredColorPictureBox_Click(object sender, EventArgs e) {
            OnPictureBoxClick(ref darkThemeBestMatchPictureBox, ref darkThemeDesiredColorTextBox);
        }

        private void LightThemeDesiredColorPictureBox_Click(object sender, EventArgs e) {
            OnPictureBoxClick(ref lightThemeBestMatchPictureBox, ref lightThemeDesiredColorTextBox);
        }

        private void BlueThemeDesiredColorPictureBox_Click(object sender, EventArgs e) {
            OnPictureBoxClick(ref blueThemeBestMatchPictureBox, ref blueThemeDesiredColorTextBox);
        }

        private void OnPictureBoxClick(ref PictureBox pictureBox, ref TextBox textBox) {
            colorDialog.Color = pictureBox.BackColor;
            var result = colorDialog.ShowDialog();
            if (result == DialogResult.OK) {
                textBox.Text = colorDialog.Color.ToHex();
                RefreshEverything();
            }
        }

        private void DarkThemeDesiredColorTextBox_TextChanged(object sender, EventArgs e) {
            RefreshEverything();
        }

        private void LightThemeDesiredColorTextBox_TextChanged(object sender, EventArgs e) {
            RefreshEverything();
        }

        private void BlueThemeDesiredColorTextBox_TextChanged(object sender, EventArgs e) {
            RefreshEverything();
        }

        private void PickDarkThemeDesiredColorBtn_Click(object sender, EventArgs e) {
            Hide();
            new ColorPickOverlay(
                this,
                c => darkThemeDesiredColorTextBox.Text = c.ToHex()
            ).Show();
        }

        private void PickLightThemeDesiredColorBtn_Click(object sender, EventArgs e) {
            Hide();
            new ColorPickOverlay(
                this,
                c => lightThemeDesiredColorTextBox.Text = c.ToHex()
            ).Show();
        }

        private void PickBlueThemeDesiredColorBtn_Click(object sender, EventArgs e) {
            Hide();
            new ColorPickOverlay(
                this,
                c => blueThemeDesiredColorTextBox.Text = c.ToHex()
            ).Show();
        }

        private void CopyToClipboardButton_Click(object sender, EventArgs e) {
            if (bestMatches.Count > 0) {
                var bestMatch = bestMatches[bestMatchesComboBox.SelectedIndex];
                var copyText = bestMatch.Name;
                Clipboard.SetText(copyText);
            }
        }

        private void darkThemeBestMatchPictureBox_MouseHover(object sender, EventArgs e) =>
            toolTip
            .SetToolTip(
                darkThemeBestMatchPictureBox,
                darkThemeBestMatchPictureBox.BackColor.ToHex());

        private void lightThemeBestMatchPictureBox_MouseHover(object sender, EventArgs e) =>
            toolTip
            .SetToolTip(
                lightThemeBestMatchPictureBox,
                lightThemeBestMatchPictureBox.BackColor.ToHex());

        private void blueThemeBestMatchPictureBox_MouseHover(object sender, EventArgs e) =>
            toolTip
            .SetToolTip(
                blueThemeBestMatchPictureBox,
                blueThemeBestMatchPictureBox.BackColor.ToHex());
    }
}
