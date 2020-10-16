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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pickDarkThemeDesiredColorBtn = new System.Windows.Forms.Button();
            this.pickLightThemeDesiredColorBtn = new System.Windows.Forms.Button();
            this.pickBlueThemeDesiredColorBtn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.darkThemeDesiredColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightThemeDesiredColorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkThemeBestMatchPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightThemeBestMatchPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueThemeBestMatchPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueThemeDesiredColorPictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(label1, 2);
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(179, 20);
            label1.TabIndex = 0;
            label1.Text = "Dark theme";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(label2, 2);
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(208, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(179, 20);
            label2.TabIndex = 1;
            label2.Text = "Light theme";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(label3, 2);
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(413, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(179, 20);
            label3.TabIndex = 11;
            label3.Text = "Blue theme";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // darkThemeDesiredColorTextBox
            // 
            this.darkThemeDesiredColorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkThemeDesiredColorTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkThemeDesiredColorTextBox.Location = new System.Drawing.Point(33, 33);
            this.darkThemeDesiredColorTextBox.Name = "darkThemeDesiredColorTextBox";
            this.darkThemeDesiredColorTextBox.Size = new System.Drawing.Size(149, 20);
            this.darkThemeDesiredColorTextBox.TabIndex = 2;
            this.darkThemeDesiredColorTextBox.Text = "717171";
            this.darkThemeDesiredColorTextBox.TextChanged += new System.EventHandler(this.DarkThemeDesiredColorTextBox_TextChanged);
            // 
            // lightThemeDesiredColorTextBox
            // 
            this.lightThemeDesiredColorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lightThemeDesiredColorTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lightThemeDesiredColorTextBox.Location = new System.Drawing.Point(238, 33);
            this.lightThemeDesiredColorTextBox.Name = "lightThemeDesiredColorTextBox";
            this.lightThemeDesiredColorTextBox.Size = new System.Drawing.Size(149, 20);
            this.lightThemeDesiredColorTextBox.TabIndex = 4;
            this.lightThemeDesiredColorTextBox.Text = "c9def5";
            this.lightThemeDesiredColorTextBox.TextChanged += new System.EventHandler(this.LightThemeDesiredColorTextBox_TextChanged);
            // 
            // darkThemeDesiredColorPictureBox
            // 
            this.darkThemeDesiredColorPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkThemeDesiredColorPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.darkThemeDesiredColorPictureBox.Location = new System.Drawing.Point(33, 63);
            this.darkThemeDesiredColorPictureBox.Name = "darkThemeDesiredColorPictureBox";
            this.darkThemeDesiredColorPictureBox.Size = new System.Drawing.Size(149, 24);
            this.darkThemeDesiredColorPictureBox.TabIndex = 5;
            this.darkThemeDesiredColorPictureBox.TabStop = false;
            this.darkThemeDesiredColorPictureBox.Click += new System.EventHandler(this.DarkThemeDesiredColorPictureBox_Click);
            // 
            // lightThemeDesiredColorPictureBox
            // 
            this.lightThemeDesiredColorPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lightThemeDesiredColorPictureBox.BackColor = System.Drawing.Color.Blue;
            this.lightThemeDesiredColorPictureBox.Location = new System.Drawing.Point(238, 63);
            this.lightThemeDesiredColorPictureBox.Name = "lightThemeDesiredColorPictureBox";
            this.lightThemeDesiredColorPictureBox.Size = new System.Drawing.Size(149, 24);
            this.lightThemeDesiredColorPictureBox.TabIndex = 6;
            this.lightThemeDesiredColorPictureBox.TabStop = false;
            this.lightThemeDesiredColorPictureBox.Click += new System.EventHandler(this.LightThemeDesiredColorPictureBox_Click);
            // 
            // darkThemeBestMatchPictureBox
            // 
            this.darkThemeBestMatchPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkThemeBestMatchPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel1.SetColumnSpan(this.darkThemeBestMatchPictureBox, 2);
            this.darkThemeBestMatchPictureBox.Location = new System.Drawing.Point(3, 145);
            this.darkThemeBestMatchPictureBox.Name = "darkThemeBestMatchPictureBox";
            this.darkThemeBestMatchPictureBox.Size = new System.Drawing.Size(179, 24);
            this.darkThemeBestMatchPictureBox.TabIndex = 7;
            this.darkThemeBestMatchPictureBox.TabStop = false;
            this.darkThemeBestMatchPictureBox.MouseHover += new System.EventHandler(this.darkThemeBestMatchPictureBox_MouseHover);
            // 
            // lightThemeBestMatchPictureBox
            // 
            this.lightThemeBestMatchPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lightThemeBestMatchPictureBox.BackColor = System.Drawing.Color.Blue;
            this.tableLayoutPanel1.SetColumnSpan(this.lightThemeBestMatchPictureBox, 2);
            this.lightThemeBestMatchPictureBox.Location = new System.Drawing.Point(208, 145);
            this.lightThemeBestMatchPictureBox.Name = "lightThemeBestMatchPictureBox";
            this.lightThemeBestMatchPictureBox.Size = new System.Drawing.Size(179, 24);
            this.lightThemeBestMatchPictureBox.TabIndex = 8;
            this.lightThemeBestMatchPictureBox.TabStop = false;
            this.lightThemeBestMatchPictureBox.MouseHover += new System.EventHandler(this.lightThemeBestMatchPictureBox_MouseHover);
            // 
            // bestMatchesComboBox
            // 
            this.bestMatchesComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.bestMatchesComboBox, 7);
            this.bestMatchesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bestMatchesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestMatchesComboBox.FormattingEnabled = true;
            this.bestMatchesComboBox.Location = new System.Drawing.Point(3, 114);
            this.bestMatchesComboBox.Name = "bestMatchesComboBox";
            this.bestMatchesComboBox.Size = new System.Drawing.Size(434, 24);
            this.bestMatchesComboBox.TabIndex = 7;
            this.bestMatchesComboBox.SelectedIndexChanged += new System.EventHandler(this.bestMatchesComboBox_SelectedIndexChanged);
            // 
            // blueThemeBestMatchPictureBox
            // 
            this.blueThemeBestMatchPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blueThemeBestMatchPictureBox.BackColor = System.Drawing.Color.Blue;
            this.tableLayoutPanel1.SetColumnSpan(this.blueThemeBestMatchPictureBox, 2);
            this.blueThemeBestMatchPictureBox.Location = new System.Drawing.Point(413, 145);
            this.blueThemeBestMatchPictureBox.Name = "blueThemeBestMatchPictureBox";
            this.blueThemeBestMatchPictureBox.Size = new System.Drawing.Size(179, 24);
            this.blueThemeBestMatchPictureBox.TabIndex = 14;
            this.blueThemeBestMatchPictureBox.TabStop = false;
            this.blueThemeBestMatchPictureBox.MouseHover += new System.EventHandler(this.blueThemeBestMatchPictureBox_MouseHover);
            // 
            // blueThemeDesiredColorPictureBox
            // 
            this.blueThemeDesiredColorPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blueThemeDesiredColorPictureBox.BackColor = System.Drawing.Color.Blue;
            this.blueThemeDesiredColorPictureBox.Location = new System.Drawing.Point(443, 63);
            this.blueThemeDesiredColorPictureBox.Name = "blueThemeDesiredColorPictureBox";
            this.blueThemeDesiredColorPictureBox.Size = new System.Drawing.Size(149, 24);
            this.blueThemeDesiredColorPictureBox.TabIndex = 13;
            this.blueThemeDesiredColorPictureBox.TabStop = false;
            this.blueThemeDesiredColorPictureBox.Click += new System.EventHandler(this.BlueThemeDesiredColorPictureBox_Click);
            // 
            // blueThemeDesiredColorTextBox
            // 
            this.blueThemeDesiredColorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blueThemeDesiredColorTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueThemeDesiredColorTextBox.Location = new System.Drawing.Point(443, 33);
            this.blueThemeDesiredColorTextBox.Name = "blueThemeDesiredColorTextBox";
            this.blueThemeDesiredColorTextBox.Size = new System.Drawing.Size(149, 20);
            this.blueThemeDesiredColorTextBox.TabIndex = 6;
            this.blueThemeDesiredColorTextBox.Text = "fff0d0";
            this.blueThemeDesiredColorTextBox.TextChanged += new System.EventHandler(this.BlueThemeDesiredColorTextBox_TextChanged);
            // 
            // darkThemeDesiredColorCheckBox
            // 
            this.darkThemeDesiredColorCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.darkThemeDesiredColorCheckBox.AutoSize = true;
            this.darkThemeDesiredColorCheckBox.Checked = true;
            this.darkThemeDesiredColorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.darkThemeDesiredColorCheckBox.Location = new System.Drawing.Point(6, 38);
            this.darkThemeDesiredColorCheckBox.Name = "darkThemeDesiredColorCheckBox";
            this.darkThemeDesiredColorCheckBox.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.darkThemeDesiredColorCheckBox.Size = new System.Drawing.Size(18, 14);
            this.darkThemeDesiredColorCheckBox.TabIndex = 1;
            this.darkThemeDesiredColorCheckBox.UseVisualStyleBackColor = true;
            this.darkThemeDesiredColorCheckBox.CheckedChanged += new System.EventHandler(this.DarkThemeDesiredColorCheckBox_CheckedChanged);
            // 
            // lightThemeDesiredColorCheckBox
            // 
            this.lightThemeDesiredColorCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lightThemeDesiredColorCheckBox.AutoSize = true;
            this.lightThemeDesiredColorCheckBox.Checked = true;
            this.lightThemeDesiredColorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lightThemeDesiredColorCheckBox.Location = new System.Drawing.Point(211, 38);
            this.lightThemeDesiredColorCheckBox.Name = "lightThemeDesiredColorCheckBox";
            this.lightThemeDesiredColorCheckBox.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lightThemeDesiredColorCheckBox.Size = new System.Drawing.Size(18, 14);
            this.lightThemeDesiredColorCheckBox.TabIndex = 3;
            this.lightThemeDesiredColorCheckBox.UseVisualStyleBackColor = true;
            this.lightThemeDesiredColorCheckBox.CheckedChanged += new System.EventHandler(this.LightThemeDesiredColorCheckBox_CheckedChanged);
            // 
            // blueThemeDesiredColorCheckBox
            // 
            this.blueThemeDesiredColorCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.blueThemeDesiredColorCheckBox.AutoSize = true;
            this.blueThemeDesiredColorCheckBox.Checked = true;
            this.blueThemeDesiredColorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.blueThemeDesiredColorCheckBox.Location = new System.Drawing.Point(416, 38);
            this.blueThemeDesiredColorCheckBox.Name = "blueThemeDesiredColorCheckBox";
            this.blueThemeDesiredColorCheckBox.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.blueThemeDesiredColorCheckBox.Size = new System.Drawing.Size(18, 14);
            this.blueThemeDesiredColorCheckBox.TabIndex = 5;
            this.blueThemeDesiredColorCheckBox.UseVisualStyleBackColor = true;
            this.blueThemeDesiredColorCheckBox.CheckedChanged += new System.EventHandler(this.BlueThemeDesiredColorCheckBox_CheckedChanged);
            // 
            // colorDialog
            // 
            this.colorDialog.SolidColorOnly = true;
            // 
            // copyToClipboardButton
            // 
            this.copyToClipboardButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyToClipboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyToClipboardButton.Location = new System.Drawing.Point(443, 113);
            this.copyToClipboardButton.Name = "copyToClipboardButton";
            this.copyToClipboardButton.Size = new System.Drawing.Size(149, 26);
            this.copyToClipboardButton.TabIndex = 8;
            this.copyToClipboardButton.Text = "📋 Copy";
            this.copyToClipboardButton.UseVisualStyleBackColor = true;
            this.copyToClipboardButton.Click += new System.EventHandler(this.CopyToClipboardButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.darkThemeDesiredColorCheckBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.darkThemeDesiredColorTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(label3, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.blueThemeDesiredColorTextBox, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.blueThemeDesiredColorCheckBox, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.lightThemeDesiredColorTextBox, 4, 1);
            this.tableLayoutPanel1.Controls.Add(label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lightThemeDesiredColorCheckBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.darkThemeBestMatchPictureBox, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lightThemeBestMatchPictureBox, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.blueThemeBestMatchPictureBox, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.copyToClipboardButton, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.bestMatchesComboBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.darkThemeDesiredColorPictureBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.blueThemeDesiredColorPictureBox, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.lightThemeDesiredColorPictureBox, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.pickDarkThemeDesiredColorBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pickLightThemeDesiredColorBtn, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.pickBlueThemeDesiredColorBtn, 6, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(595, 172);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // pickDarkThemeDesiredColorBtn
            // 
            this.pickDarkThemeDesiredColorBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pickDarkThemeDesiredColorBtn.Image = global::EnvironmentColorsFinder.Properties.Resources.ColorPicker_12x_16x;
            this.pickDarkThemeDesiredColorBtn.Location = new System.Drawing.Point(3, 63);
            this.pickDarkThemeDesiredColorBtn.Name = "pickDarkThemeDesiredColorBtn";
            this.pickDarkThemeDesiredColorBtn.Size = new System.Drawing.Size(24, 24);
            this.pickDarkThemeDesiredColorBtn.TabIndex = 15;
            this.pickDarkThemeDesiredColorBtn.UseVisualStyleBackColor = true;
            this.pickDarkThemeDesiredColorBtn.Click += new System.EventHandler(this.PickDarkThemeDesiredColorBtn_Click);
            // 
            // pickLightThemeDesiredColorBtn
            // 
            this.pickLightThemeDesiredColorBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pickLightThemeDesiredColorBtn.Image = global::EnvironmentColorsFinder.Properties.Resources.ColorPicker_12x_16x;
            this.pickLightThemeDesiredColorBtn.Location = new System.Drawing.Point(208, 63);
            this.pickLightThemeDesiredColorBtn.Name = "pickLightThemeDesiredColorBtn";
            this.pickLightThemeDesiredColorBtn.Size = new System.Drawing.Size(24, 24);
            this.pickLightThemeDesiredColorBtn.TabIndex = 16;
            this.pickLightThemeDesiredColorBtn.UseVisualStyleBackColor = true;
            this.pickLightThemeDesiredColorBtn.Click += new System.EventHandler(this.PickLightThemeDesiredColorBtn_Click);
            // 
            // pickBlueThemeDesiredColorBtn
            // 
            this.pickBlueThemeDesiredColorBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pickBlueThemeDesiredColorBtn.Image = global::EnvironmentColorsFinder.Properties.Resources.ColorPicker_12x_16x;
            this.pickBlueThemeDesiredColorBtn.Location = new System.Drawing.Point(413, 63);
            this.pickBlueThemeDesiredColorBtn.Name = "pickBlueThemeDesiredColorBtn";
            this.pickBlueThemeDesiredColorBtn.Size = new System.Drawing.Size(24, 24);
            this.pickBlueThemeDesiredColorBtn.TabIndex = 17;
            this.pickBlueThemeDesiredColorBtn.UseVisualStyleBackColor = true;
            this.pickBlueThemeDesiredColorBtn.Click += new System.EventHandler(this.PickBlueThemeDesiredColorBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 172);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(355, 211);
            this.Name = "MainForm";
            this.Text = "EnvironmentColors finder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.darkThemeDesiredColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightThemeDesiredColorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkThemeBestMatchPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightThemeBestMatchPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueThemeBestMatchPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueThemeDesiredColorPictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button pickDarkThemeDesiredColorBtn;
        private System.Windows.Forms.Button pickLightThemeDesiredColorBtn;
        private System.Windows.Forms.Button pickBlueThemeDesiredColorBtn;
    }
}

