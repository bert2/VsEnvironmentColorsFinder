using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EnvironmentColorsFinder
{
    public partial class MainForm : Form
    {
        private const int MinNumMatchesToList = 20;

        private ColorDatabase colorDatabase = new ColorDatabase();
        private IEnumerable<ColorMatch> bestMatches = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshEverything();
        }

        private void RefreshEverything()
        {
            Color? desiredDarkColor = null;
            Color? desiredLightColor = null;
            Color? desiredBlueColor = null;
            try
            {
                // Get the colors from the RGB hex strings that the user has entered.
                if (this.darkThemeDesiredColorCheckBox.Checked)
                    desiredDarkColor = ColorHelpers.ParseColor(this.darkThemeDesiredColorTextBox.Text);
                if (this.lightThemeDesiredColorCheckBox.Checked)
                    desiredLightColor = ColorHelpers.ParseColor(this.lightThemeDesiredColorTextBox.Text);
                if (this.blueThemeDesiredColorCheckBox.Checked)
                    desiredBlueColor = ColorHelpers.ParseColor(this.blueThemeDesiredColorTextBox.Text);
            }
            catch (ArgumentException)
            {
                return;
            }

            // Show the selected colors under the textboxes,
            // or black if the theme is not selected for inclusion.
            this.darkThemeDesiredColorPictureBox.BackColor = desiredDarkColor ?? Color.Black;
            this.lightThemeDesiredColorPictureBox.BackColor = desiredLightColor ?? Color.Black;
            this.blueThemeDesiredColorPictureBox.BackColor = desiredBlueColor ?? Color.Black;

            // Calculate the best matches for the user-entered color hex strings.
            this.bestMatches = this.colorDatabase.CalculateBestMatches(desiredDarkColor, desiredLightColor, desiredBlueColor);

            // Populate the dropdown with the best matches.
            this.bestMatchesComboBox.Items.Clear();
            foreach (var bestMatch in bestMatches)
            {
                // We want to shoe all the matches that have a diff of zero,
                // but we should always show at least MaxNumMatchesToList matches in any case.
                if (bestMatch.Diff == 0 || this.bestMatchesComboBox.Items.Count < MinNumMatchesToList)
                {
                    this.bestMatchesComboBox.Items.Add(string.Format($"{bestMatch.Name} ({bestMatch.Diff})"));
                }
            }
            this.bestMatchesComboBox.SelectedIndex = 0;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshEverything();
        }

        private void bestMatchesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var bestMatch = this.bestMatches.ElementAt(this.bestMatchesComboBox.SelectedIndex);

            this.darkThemeBestMatchPictureBox.BackColor = bestMatch.Dark;
            this.lightThemeBestMatchPictureBox.BackColor = bestMatch.Light;
            this.blueThemeBestMatchPictureBox.BackColor = bestMatch.Blue;
        }

        private void DarkThemeDesiredColorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.darkThemeDesiredColorTextBox.Enabled = this.darkThemeDesiredColorCheckBox.Checked;
            RefreshEverything();
        }

        private void LightThemeDesiredColorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.lightThemeDesiredColorTextBox.Enabled = this.lightThemeDesiredColorCheckBox.Checked;
            RefreshEverything();
        }

        private void BlueThemeDesiredColorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.blueThemeDesiredColorTextBox.Enabled = this.blueThemeDesiredColorCheckBox.Checked;
            RefreshEverything();
        }

        private void DarkThemeDesiredColorPictureBox_Click(object sender, EventArgs e)
        {
            OnPictureBoxClick(ref this.darkThemeBestMatchPictureBox, ref this.darkThemeDesiredColorTextBox);
        }

        private void LightThemeDesiredColorPictureBox_Click(object sender, EventArgs e)
        {
            OnPictureBoxClick(ref this.lightThemeBestMatchPictureBox, ref this.lightThemeDesiredColorTextBox);
        }

        private void BlueThemeDesiredColorPictureBox_Click(object sender, EventArgs e)
        {
            OnPictureBoxClick(ref this.blueThemeBestMatchPictureBox, ref this.blueThemeDesiredColorTextBox);
        }

        private void OnPictureBoxClick(ref PictureBox pictureBox, ref TextBox textBox)
        {
            this.colorDialog.Color = pictureBox.BackColor;
            var result = this.colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox.Text = ColorHelpers.GetHexStringFromColor(this.colorDialog.Color);
                RefreshEverything();
            }
        }

        private void DarkThemeDesiredColorTextBox_TextChanged(object sender, EventArgs e)
        {
            RefreshEverything();
        }

        private void LightThemeDesiredColorTextBox_TextChanged(object sender, EventArgs e)
        {
            RefreshEverything();
        }

        private void BlueThemeDesiredColorTextBox_TextChanged(object sender, EventArgs e)
        {
            RefreshEverything();
        }

        private void CopyToClipboardButton_Click(object sender, EventArgs e)
        {
            if (this.bestMatches.Any())
            {
                var bestMatch = this.bestMatches.ElementAt(this.bestMatchesComboBox.SelectedIndex);
                var copyText = bestMatch.Name;
                Clipboard.SetText(copyText);
            }
        }
    }
}
