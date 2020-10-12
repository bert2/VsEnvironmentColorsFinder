namespace EnvironmentColorsFinder
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.darkThemeDesiredColorTextBox = new System.Windows.Forms.TextBox();
            this.lightThemeDesiredColorTextBox = new System.Windows.Forms.TextBox();
            this.darkThemeDesiredColorPictureBox = new System.Windows.Forms.PictureBox();
            this.lightThemeDesiredColorPictureBox = new System.Windows.Forms.PictureBox();
            this.darkThemeBestMatchPictureBox = new System.Windows.Forms.PictureBox();
            this.lightThemeBestMatchPictureBox = new System.Windows.Forms.PictureBox();
            this.bestMatchesComboBox = new System.Windows.Forms.ComboBox();
            this.blueThemeBestMatchPictureBox = new System.Windows.Forms.PictureBox();
            this.blueThemeDesiredColorPictureBox = new System.Windows.Forms.PictureBox();
            this.blueThemeDesiredColorTextBox = new System.Windows.Forms.TextBox();
            this.darkThemeDesiredColorCheckBox = new System.Windows.Forms.CheckBox();
            this.lightThemeDesiredColorCheckBox = new System.Windows.Forms.CheckBox();
            this.blueThemeDesiredColorCheckBox = new System.Windows.Forms.CheckBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.copyToClipboardButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.darkThemeDesiredColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightThemeDesiredColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkThemeBestMatchPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightThemeBestMatchPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueThemeBestMatchPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueThemeDesiredColorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(16, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Dark theme";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(153, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "Light theme";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(290, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(100, 20);
            label3.TabIndex = 11;
            label3.Text = "Blue theme";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // darkThemeDesiredColorTextBox
            // 
            this.darkThemeDesiredColorTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkThemeDesiredColorTextBox.Location = new System.Drawing.Point(36, 43);
            this.darkThemeDesiredColorTextBox.Name = "darkThemeDesiredColorTextBox";
            this.darkThemeDesiredColorTextBox.Size = new System.Drawing.Size(80, 20);
            this.darkThemeDesiredColorTextBox.TabIndex = 2;
            this.darkThemeDesiredColorTextBox.Text = "ff00ff";
            this.darkThemeDesiredColorTextBox.TextChanged += new System.EventHandler(this.DarkThemeDesiredColorTextBox_TextChanged);
            // 
            // lightThemeDesiredColorTextBox
            // 
            this.lightThemeDesiredColorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lightThemeDesiredColorTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lightThemeDesiredColorTextBox.Location = new System.Drawing.Point(173, 43);
            this.lightThemeDesiredColorTextBox.Name = "lightThemeDesiredColorTextBox";
            this.lightThemeDesiredColorTextBox.Size = new System.Drawing.Size(80, 20);
            this.lightThemeDesiredColorTextBox.TabIndex = 3;
            this.lightThemeDesiredColorTextBox.Text = "ff00ff";
            this.lightThemeDesiredColorTextBox.TextChanged += new System.EventHandler(this.LightThemeDesiredColorTextBox_TextChanged);
            // 
            // darkThemeDesiredColorPictureBox
            // 
            this.darkThemeDesiredColorPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.darkThemeDesiredColorPictureBox.Location = new System.Drawing.Point(16, 72);
            this.darkThemeDesiredColorPictureBox.Name = "darkThemeDesiredColorPictureBox";
            this.darkThemeDesiredColorPictureBox.Size = new System.Drawing.Size(100, 26);
            this.darkThemeDesiredColorPictureBox.TabIndex = 5;
            this.darkThemeDesiredColorPictureBox.TabStop = false;
            this.darkThemeDesiredColorPictureBox.Click += new System.EventHandler(this.DarkThemeDesiredColorPictureBox_Click);
            // 
            // lightThemeDesiredColorPictureBox
            // 
            this.lightThemeDesiredColorPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lightThemeDesiredColorPictureBox.BackColor = System.Drawing.Color.Blue;
            this.lightThemeDesiredColorPictureBox.Location = new System.Drawing.Point(153, 71);
            this.lightThemeDesiredColorPictureBox.Name = "lightThemeDesiredColorPictureBox";
            this.lightThemeDesiredColorPictureBox.Size = new System.Drawing.Size(100, 26);
            this.lightThemeDesiredColorPictureBox.TabIndex = 6;
            this.lightThemeDesiredColorPictureBox.TabStop = false;
            this.lightThemeDesiredColorPictureBox.Click += new System.EventHandler(this.LightThemeDesiredColorPictureBox_Click);
            // 
            // darkThemeBestMatchPictureBox
            // 
            this.darkThemeBestMatchPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.darkThemeBestMatchPictureBox.Location = new System.Drawing.Point(16, 148);
            this.darkThemeBestMatchPictureBox.Name = "darkThemeBestMatchPictureBox";
            this.darkThemeBestMatchPictureBox.Size = new System.Drawing.Size(100, 26);
            this.darkThemeBestMatchPictureBox.TabIndex = 7;
            this.darkThemeBestMatchPictureBox.TabStop = false;
            // 
            // lightThemeBestMatchPictureBox
            // 
            this.lightThemeBestMatchPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lightThemeBestMatchPictureBox.BackColor = System.Drawing.Color.Blue;
            this.lightThemeBestMatchPictureBox.Location = new System.Drawing.Point(153, 148);
            this.lightThemeBestMatchPictureBox.Name = "lightThemeBestMatchPictureBox";
            this.lightThemeBestMatchPictureBox.Size = new System.Drawing.Size(100, 26);
            this.lightThemeBestMatchPictureBox.TabIndex = 8;
            this.lightThemeBestMatchPictureBox.TabStop = false;
            // 
            // bestMatchesComboBox
            // 
            this.bestMatchesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bestMatchesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bestMatchesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestMatchesComboBox.FormattingEnabled = true;
            this.bestMatchesComboBox.Location = new System.Drawing.Point(16, 114);
            this.bestMatchesComboBox.Name = "bestMatchesComboBox";
            this.bestMatchesComboBox.Size = new System.Drawing.Size(268, 24);
            this.bestMatchesComboBox.TabIndex = 10;
            this.bestMatchesComboBox.SelectedIndexChanged += new System.EventHandler(this.bestMatchesComboBox_SelectedIndexChanged);
            // 
            // blueThemeBestMatchPictureBox
            // 
            this.blueThemeBestMatchPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.blueThemeBestMatchPictureBox.BackColor = System.Drawing.Color.Blue;
            this.blueThemeBestMatchPictureBox.Location = new System.Drawing.Point(290, 148);
            this.blueThemeBestMatchPictureBox.Name = "blueThemeBestMatchPictureBox";
            this.blueThemeBestMatchPictureBox.Size = new System.Drawing.Size(100, 26);
            this.blueThemeBestMatchPictureBox.TabIndex = 14;
            this.blueThemeBestMatchPictureBox.TabStop = false;
            // 
            // blueThemeDesiredColorPictureBox
            // 
            this.blueThemeDesiredColorPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.blueThemeDesiredColorPictureBox.BackColor = System.Drawing.Color.Blue;
            this.blueThemeDesiredColorPictureBox.Location = new System.Drawing.Point(290, 71);
            this.blueThemeDesiredColorPictureBox.Name = "blueThemeDesiredColorPictureBox";
            this.blueThemeDesiredColorPictureBox.Size = new System.Drawing.Size(100, 26);
            this.blueThemeDesiredColorPictureBox.TabIndex = 13;
            this.blueThemeDesiredColorPictureBox.TabStop = false;
            this.blueThemeDesiredColorPictureBox.Click += new System.EventHandler(this.BlueThemeDesiredColorPictureBox_Click);
            // 
            // blueThemeDesiredColorTextBox
            // 
            this.blueThemeDesiredColorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.blueThemeDesiredColorTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueThemeDesiredColorTextBox.Location = new System.Drawing.Point(310, 43);
            this.blueThemeDesiredColorTextBox.Name = "blueThemeDesiredColorTextBox";
            this.blueThemeDesiredColorTextBox.Size = new System.Drawing.Size(80, 20);
            this.blueThemeDesiredColorTextBox.TabIndex = 12;
            this.blueThemeDesiredColorTextBox.Text = "ff00ff";
            this.blueThemeDesiredColorTextBox.TextChanged += new System.EventHandler(this.BlueThemeDesiredColorTextBox_TextChanged);
            // 
            // darkThemeDesiredColorCheckBox
            // 
            this.darkThemeDesiredColorCheckBox.AutoSize = true;
            this.darkThemeDesiredColorCheckBox.Checked = true;
            this.darkThemeDesiredColorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.darkThemeDesiredColorCheckBox.Location = new System.Drawing.Point(16, 46);
            this.darkThemeDesiredColorCheckBox.Name = "darkThemeDesiredColorCheckBox";
            this.darkThemeDesiredColorCheckBox.Size = new System.Drawing.Size(15, 14);
            this.darkThemeDesiredColorCheckBox.TabIndex = 15;
            this.darkThemeDesiredColorCheckBox.UseVisualStyleBackColor = true;
            this.darkThemeDesiredColorCheckBox.CheckedChanged += new System.EventHandler(this.DarkThemeDesiredColorCheckBox_CheckedChanged);
            // 
            // lightThemeDesiredColorCheckBox
            // 
            this.lightThemeDesiredColorCheckBox.AutoSize = true;
            this.lightThemeDesiredColorCheckBox.Checked = true;
            this.lightThemeDesiredColorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lightThemeDesiredColorCheckBox.Location = new System.Drawing.Point(152, 46);
            this.lightThemeDesiredColorCheckBox.Name = "lightThemeDesiredColorCheckBox";
            this.lightThemeDesiredColorCheckBox.Size = new System.Drawing.Size(15, 14);
            this.lightThemeDesiredColorCheckBox.TabIndex = 16;
            this.lightThemeDesiredColorCheckBox.UseVisualStyleBackColor = true;
            this.lightThemeDesiredColorCheckBox.CheckedChanged += new System.EventHandler(this.LightThemeDesiredColorCheckBox_CheckedChanged);
            // 
            // blueThemeDesiredColorCheckBox
            // 
            this.blueThemeDesiredColorCheckBox.AutoSize = true;
            this.blueThemeDesiredColorCheckBox.Checked = true;
            this.blueThemeDesiredColorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.blueThemeDesiredColorCheckBox.Location = new System.Drawing.Point(289, 46);
            this.blueThemeDesiredColorCheckBox.Name = "blueThemeDesiredColorCheckBox";
            this.blueThemeDesiredColorCheckBox.Size = new System.Drawing.Size(15, 14);
            this.blueThemeDesiredColorCheckBox.TabIndex = 17;
            this.blueThemeDesiredColorCheckBox.UseVisualStyleBackColor = true;
            this.blueThemeDesiredColorCheckBox.CheckedChanged += new System.EventHandler(this.BlueThemeDesiredColorCheckBox_CheckedChanged);
            // 
            // colorDialog
            // 
            this.colorDialog.SolidColorOnly = true;
            // 
            // copyToClipboardButton
            // 
            this.copyToClipboardButton.Location = new System.Drawing.Point(294, 114);
            this.copyToClipboardButton.Name = "copyToClipboardButton";
            this.copyToClipboardButton.Size = new System.Drawing.Size(96, 23);
            this.copyToClipboardButton.TabIndex = 18;
            this.copyToClipboardButton.Text = "-> Clipboard";
            this.copyToClipboardButton.UseVisualStyleBackColor = true;
            this.copyToClipboardButton.Click += new System.EventHandler(this.CopyToClipboardButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 187);
            this.Controls.Add(this.copyToClipboardButton);
            this.Controls.Add(this.blueThemeDesiredColorCheckBox);
            this.Controls.Add(this.lightThemeDesiredColorCheckBox);
            this.Controls.Add(this.darkThemeDesiredColorCheckBox);
            this.Controls.Add(this.blueThemeBestMatchPictureBox);
            this.Controls.Add(this.blueThemeDesiredColorPictureBox);
            this.Controls.Add(this.blueThemeDesiredColorTextBox);
            this.Controls.Add(label3);
            this.Controls.Add(this.bestMatchesComboBox);
            this.Controls.Add(this.lightThemeBestMatchPictureBox);
            this.Controls.Add(this.darkThemeBestMatchPictureBox);
            this.Controls.Add(this.lightThemeDesiredColorPictureBox);
            this.Controls.Add(this.darkThemeDesiredColorPictureBox);
            this.Controls.Add(this.lightThemeDesiredColorTextBox);
            this.Controls.Add(this.darkThemeDesiredColorTextBox);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "EnvironmentColors finder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.darkThemeDesiredColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightThemeDesiredColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkThemeBestMatchPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightThemeBestMatchPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueThemeBestMatchPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueThemeDesiredColorPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox darkThemeDesiredColorTextBox;
        private System.Windows.Forms.TextBox lightThemeDesiredColorTextBox;
        private System.Windows.Forms.PictureBox darkThemeDesiredColorPictureBox;
        private System.Windows.Forms.PictureBox lightThemeDesiredColorPictureBox;
        private System.Windows.Forms.PictureBox darkThemeBestMatchPictureBox;
        private System.Windows.Forms.PictureBox lightThemeBestMatchPictureBox;
        private System.Windows.Forms.ComboBox bestMatchesComboBox;
        private System.Windows.Forms.PictureBox blueThemeBestMatchPictureBox;
        private System.Windows.Forms.PictureBox blueThemeDesiredColorPictureBox;
        private System.Windows.Forms.TextBox blueThemeDesiredColorTextBox;
        private System.Windows.Forms.CheckBox darkThemeDesiredColorCheckBox;
        private System.Windows.Forms.CheckBox lightThemeDesiredColorCheckBox;
        private System.Windows.Forms.CheckBox blueThemeDesiredColorCheckBox;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button copyToClipboardButton;
    }
}

