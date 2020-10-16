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
            System.Windows.Forms.Label darkThemeLbl;
            System.Windows.Forms.Label lightThemeLbl;
            System.Windows.Forms.Label blueThemeLbl;
            this.darkDesiredColorTxt = new System.Windows.Forms.TextBox();
            this.lightDesiredColorTxt = new System.Windows.Forms.TextBox();
            this.darkDesiredColorPic = new System.Windows.Forms.PictureBox();
            this.lightDesiredColorPic = new System.Windows.Forms.PictureBox();
            this.darkBestMatchPic = new System.Windows.Forms.PictureBox();
            this.lightBestMatchPic = new System.Windows.Forms.PictureBox();
            this.bestMatchesCmb = new System.Windows.Forms.ComboBox();
            this.blueBestMatchPic = new System.Windows.Forms.PictureBox();
            this.blueDesiredColorPic = new System.Windows.Forms.PictureBox();
            this.blueDesiredColorTxt = new System.Windows.Forms.TextBox();
            this.darkDesiredColorChk = new System.Windows.Forms.CheckBox();
            this.lightDesiredColorChk = new System.Windows.Forms.CheckBox();
            this.blueDesiredColorChk = new System.Windows.Forms.CheckBox();
            this.colorPickerDlg = new System.Windows.Forms.ColorDialog();
            this.copyToClipboardBtn = new System.Windows.Forms.Button();
            this.tableLayoutPnl = new System.Windows.Forms.TableLayoutPanel();
            this.pickDarkDesiredColorBtn = new System.Windows.Forms.Button();
            this.pickLightDesiredColorBtn = new System.Windows.Forms.Button();
            this.pickBlueDesiredColorBtn = new System.Windows.Forms.Button();
            darkThemeLbl = new System.Windows.Forms.Label();
            lightThemeLbl = new System.Windows.Forms.Label();
            blueThemeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.darkDesiredColorPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightDesiredColorPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkBestMatchPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightBestMatchPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBestMatchPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueDesiredColorPic)).BeginInit();
            this.tableLayoutPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // darkThemeLbl
            // 
            darkThemeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPnl.SetColumnSpan(darkThemeLbl, 2);
            darkThemeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            darkThemeLbl.Location = new System.Drawing.Point(3, 0);
            darkThemeLbl.Name = "darkThemeLbl";
            darkThemeLbl.Size = new System.Drawing.Size(179, 20);
            darkThemeLbl.TabIndex = 0;
            darkThemeLbl.Text = "Dark theme";
            darkThemeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lightThemeLbl
            // 
            lightThemeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPnl.SetColumnSpan(lightThemeLbl, 2);
            lightThemeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lightThemeLbl.Location = new System.Drawing.Point(208, 0);
            lightThemeLbl.Name = "lightThemeLbl";
            lightThemeLbl.Size = new System.Drawing.Size(179, 20);
            lightThemeLbl.TabIndex = 1;
            lightThemeLbl.Text = "Light theme";
            lightThemeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blueThemeLbl
            // 
            blueThemeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPnl.SetColumnSpan(blueThemeLbl, 2);
            blueThemeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            blueThemeLbl.Location = new System.Drawing.Point(413, 0);
            blueThemeLbl.Name = "blueThemeLbl";
            blueThemeLbl.Size = new System.Drawing.Size(179, 20);
            blueThemeLbl.TabIndex = 11;
            blueThemeLbl.Text = "Blue theme";
            blueThemeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // darkDesiredColorTxt
            // 
            this.darkDesiredColorTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkDesiredColorTxt.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkDesiredColorTxt.Location = new System.Drawing.Point(33, 33);
            this.darkDesiredColorTxt.Name = "darkDesiredColorTxt";
            this.darkDesiredColorTxt.Size = new System.Drawing.Size(149, 20);
            this.darkDesiredColorTxt.TabIndex = 2;
            this.darkDesiredColorTxt.Text = "717171";
            this.darkDesiredColorTxt.TextChanged += new System.EventHandler(this.DarkDesiredColorTxt_TextChanged);
            // 
            // lightDesiredColorTxt
            // 
            this.lightDesiredColorTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lightDesiredColorTxt.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lightDesiredColorTxt.Location = new System.Drawing.Point(238, 33);
            this.lightDesiredColorTxt.Name = "lightDesiredColorTxt";
            this.lightDesiredColorTxt.Size = new System.Drawing.Size(149, 20);
            this.lightDesiredColorTxt.TabIndex = 4;
            this.lightDesiredColorTxt.Text = "c9def5";
            this.lightDesiredColorTxt.TextChanged += new System.EventHandler(this.LightDesiredColorTxt_TextChanged);
            // 
            // darkDesiredColorPic
            // 
            this.darkDesiredColorPic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkDesiredColorPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.darkDesiredColorPic.Location = new System.Drawing.Point(33, 63);
            this.darkDesiredColorPic.Name = "darkDesiredColorPic";
            this.darkDesiredColorPic.Size = new System.Drawing.Size(149, 24);
            this.darkDesiredColorPic.TabIndex = 5;
            this.darkDesiredColorPic.TabStop = false;
            this.darkDesiredColorPic.Click += new System.EventHandler(this.DarkDesiredColorPic_Click);
            // 
            // lightDesiredColorPic
            // 
            this.lightDesiredColorPic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lightDesiredColorPic.BackColor = System.Drawing.Color.Blue;
            this.lightDesiredColorPic.Location = new System.Drawing.Point(238, 63);
            this.lightDesiredColorPic.Name = "lightDesiredColorPic";
            this.lightDesiredColorPic.Size = new System.Drawing.Size(149, 24);
            this.lightDesiredColorPic.TabIndex = 6;
            this.lightDesiredColorPic.TabStop = false;
            this.lightDesiredColorPic.Click += new System.EventHandler(this.LightDesiredColorPic_Click);
            // 
            // darkBestMatchPic
            // 
            this.darkBestMatchPic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.darkBestMatchPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tableLayoutPnl.SetColumnSpan(this.darkBestMatchPic, 2);
            this.darkBestMatchPic.Location = new System.Drawing.Point(3, 145);
            this.darkBestMatchPic.Name = "darkBestMatchPic";
            this.darkBestMatchPic.Size = new System.Drawing.Size(179, 24);
            this.darkBestMatchPic.TabIndex = 7;
            this.darkBestMatchPic.TabStop = false;
            this.darkBestMatchPic.MouseHover += new System.EventHandler(this.darkBestMatchPic_MouseHover);
            // 
            // lightBestMatchPic
            // 
            this.lightBestMatchPic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lightBestMatchPic.BackColor = System.Drawing.Color.Blue;
            this.tableLayoutPnl.SetColumnSpan(this.lightBestMatchPic, 2);
            this.lightBestMatchPic.Location = new System.Drawing.Point(208, 145);
            this.lightBestMatchPic.Name = "lightBestMatchPic";
            this.lightBestMatchPic.Size = new System.Drawing.Size(179, 24);
            this.lightBestMatchPic.TabIndex = 8;
            this.lightBestMatchPic.TabStop = false;
            this.lightBestMatchPic.MouseHover += new System.EventHandler(this.lightBestMatchPic_MouseHover);
            // 
            // bestMatchesCmb
            // 
            this.bestMatchesCmb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPnl.SetColumnSpan(this.bestMatchesCmb, 7);
            this.bestMatchesCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bestMatchesCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestMatchesCmb.FormattingEnabled = true;
            this.bestMatchesCmb.Location = new System.Drawing.Point(3, 114);
            this.bestMatchesCmb.Name = "bestMatchesCmb";
            this.bestMatchesCmb.Size = new System.Drawing.Size(434, 24);
            this.bestMatchesCmb.TabIndex = 10;
            this.bestMatchesCmb.SelectedIndexChanged += new System.EventHandler(this.bestMatchesCmb_SelectedIndexChanged);
            // 
            // blueBestMatchPic
            // 
            this.blueBestMatchPic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blueBestMatchPic.BackColor = System.Drawing.Color.Blue;
            this.tableLayoutPnl.SetColumnSpan(this.blueBestMatchPic, 2);
            this.blueBestMatchPic.Location = new System.Drawing.Point(413, 145);
            this.blueBestMatchPic.Name = "blueBestMatchPic";
            this.blueBestMatchPic.Size = new System.Drawing.Size(179, 24);
            this.blueBestMatchPic.TabIndex = 14;
            this.blueBestMatchPic.TabStop = false;
            this.blueBestMatchPic.MouseHover += new System.EventHandler(this.blueBestMatchPic_MouseHover);
            // 
            // blueDesiredColorPic
            // 
            this.blueDesiredColorPic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blueDesiredColorPic.BackColor = System.Drawing.Color.Blue;
            this.blueDesiredColorPic.Location = new System.Drawing.Point(443, 63);
            this.blueDesiredColorPic.Name = "blueDesiredColorPic";
            this.blueDesiredColorPic.Size = new System.Drawing.Size(149, 24);
            this.blueDesiredColorPic.TabIndex = 13;
            this.blueDesiredColorPic.TabStop = false;
            this.blueDesiredColorPic.Click += new System.EventHandler(this.BlueDesiredColorPic_Click);
            // 
            // blueDesiredColorTxt
            // 
            this.blueDesiredColorTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blueDesiredColorTxt.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueDesiredColorTxt.Location = new System.Drawing.Point(443, 33);
            this.blueDesiredColorTxt.Name = "blueDesiredColorTxt";
            this.blueDesiredColorTxt.Size = new System.Drawing.Size(149, 20);
            this.blueDesiredColorTxt.TabIndex = 6;
            this.blueDesiredColorTxt.Text = "fff0d0";
            this.blueDesiredColorTxt.TextChanged += new System.EventHandler(this.BlueDesiredColorTxt_TextChanged);
            // 
            // darkDesiredColorChk
            // 
            this.darkDesiredColorChk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.darkDesiredColorChk.AutoSize = true;
            this.darkDesiredColorChk.Checked = true;
            this.darkDesiredColorChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.darkDesiredColorChk.Location = new System.Drawing.Point(6, 38);
            this.darkDesiredColorChk.Name = "darkDesiredColorChk";
            this.darkDesiredColorChk.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.darkDesiredColorChk.Size = new System.Drawing.Size(18, 14);
            this.darkDesiredColorChk.TabIndex = 1;
            this.darkDesiredColorChk.UseVisualStyleBackColor = true;
            this.darkDesiredColorChk.CheckedChanged += new System.EventHandler(this.DarkDesiredColorChk_CheckedChanged);
            // 
            // lightDesiredColorChk
            // 
            this.lightDesiredColorChk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lightDesiredColorChk.AutoSize = true;
            this.lightDesiredColorChk.Checked = true;
            this.lightDesiredColorChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lightDesiredColorChk.Location = new System.Drawing.Point(211, 38);
            this.lightDesiredColorChk.Name = "lightDesiredColorChk";
            this.lightDesiredColorChk.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lightDesiredColorChk.Size = new System.Drawing.Size(18, 14);
            this.lightDesiredColorChk.TabIndex = 3;
            this.lightDesiredColorChk.UseVisualStyleBackColor = true;
            this.lightDesiredColorChk.CheckedChanged += new System.EventHandler(this.LightDesiredColorChk_CheckedChanged);
            // 
            // blueDesiredColorChk
            // 
            this.blueDesiredColorChk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.blueDesiredColorChk.AutoSize = true;
            this.blueDesiredColorChk.Checked = true;
            this.blueDesiredColorChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.blueDesiredColorChk.Location = new System.Drawing.Point(416, 38);
            this.blueDesiredColorChk.Name = "blueDesiredColorChk";
            this.blueDesiredColorChk.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.blueDesiredColorChk.Size = new System.Drawing.Size(18, 14);
            this.blueDesiredColorChk.TabIndex = 5;
            this.blueDesiredColorChk.UseVisualStyleBackColor = true;
            this.blueDesiredColorChk.CheckedChanged += new System.EventHandler(this.BlueDesiredColorChk_CheckedChanged);
            // 
            // colorPickerDlg
            // 
            this.colorPickerDlg.SolidColorOnly = true;
            // 
            // copyToClipboardBtn
            // 
            this.copyToClipboardBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.copyToClipboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyToClipboardBtn.Location = new System.Drawing.Point(443, 113);
            this.copyToClipboardBtn.Name = "copyToClipboardBtn";
            this.copyToClipboardBtn.Size = new System.Drawing.Size(149, 26);
            this.copyToClipboardBtn.TabIndex = 11;
            this.copyToClipboardBtn.Text = "📋 Copy";
            this.copyToClipboardBtn.UseVisualStyleBackColor = true;
            this.copyToClipboardBtn.Click += new System.EventHandler(this.CopyToClipboardBtn_Click);
            // 
            // tableLayoutPnl
            // 
            this.tableLayoutPnl.ColumnCount = 8;
            this.tableLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPnl.Controls.Add(this.darkDesiredColorChk, 0, 1);
            this.tableLayoutPnl.Controls.Add(this.darkDesiredColorTxt, 1, 1);
            this.tableLayoutPnl.Controls.Add(darkThemeLbl, 0, 0);
            this.tableLayoutPnl.Controls.Add(blueThemeLbl, 6, 0);
            this.tableLayoutPnl.Controls.Add(this.blueDesiredColorTxt, 7, 1);
            this.tableLayoutPnl.Controls.Add(this.blueDesiredColorChk, 6, 1);
            this.tableLayoutPnl.Controls.Add(this.lightDesiredColorTxt, 4, 1);
            this.tableLayoutPnl.Controls.Add(lightThemeLbl, 3, 0);
            this.tableLayoutPnl.Controls.Add(this.lightDesiredColorChk, 3, 1);
            this.tableLayoutPnl.Controls.Add(this.darkBestMatchPic, 0, 5);
            this.tableLayoutPnl.Controls.Add(this.lightBestMatchPic, 3, 5);
            this.tableLayoutPnl.Controls.Add(this.blueBestMatchPic, 6, 5);
            this.tableLayoutPnl.Controls.Add(this.copyToClipboardBtn, 7, 4);
            this.tableLayoutPnl.Controls.Add(this.bestMatchesCmb, 0, 4);
            this.tableLayoutPnl.Controls.Add(this.darkDesiredColorPic, 1, 2);
            this.tableLayoutPnl.Controls.Add(this.blueDesiredColorPic, 7, 2);
            this.tableLayoutPnl.Controls.Add(this.lightDesiredColorPic, 4, 2);
            this.tableLayoutPnl.Controls.Add(this.pickDarkDesiredColorBtn, 0, 2);
            this.tableLayoutPnl.Controls.Add(this.pickLightDesiredColorBtn, 3, 2);
            this.tableLayoutPnl.Controls.Add(this.pickBlueDesiredColorBtn, 6, 2);
            this.tableLayoutPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPnl.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPnl.Name = "tableLayoutPnl";
            this.tableLayoutPnl.RowCount = 6;
            this.tableLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPnl.Size = new System.Drawing.Size(595, 172);
            this.tableLayoutPnl.TabIndex = 19;
            // 
            // pickDarkDesiredColorBtn
            // 
            this.pickDarkDesiredColorBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pickDarkDesiredColorBtn.Image = global::EnvironmentColorsFinder.Properties.Resources.ColorPicker_12x_16x;
            this.pickDarkDesiredColorBtn.Location = new System.Drawing.Point(3, 63);
            this.pickDarkDesiredColorBtn.Name = "pickDarkDesiredColorBtn";
            this.pickDarkDesiredColorBtn.Size = new System.Drawing.Size(24, 24);
            this.pickDarkDesiredColorBtn.TabIndex = 7;
            this.pickDarkDesiredColorBtn.UseVisualStyleBackColor = true;
            this.pickDarkDesiredColorBtn.Click += new System.EventHandler(this.PickDarkDesiredColorBtn_Click);
            // 
            // pickLightDesiredColorBtn
            // 
            this.pickLightDesiredColorBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pickLightDesiredColorBtn.Image = global::EnvironmentColorsFinder.Properties.Resources.ColorPicker_12x_16x;
            this.pickLightDesiredColorBtn.Location = new System.Drawing.Point(208, 63);
            this.pickLightDesiredColorBtn.Name = "pickLightDesiredColorBtn";
            this.pickLightDesiredColorBtn.Size = new System.Drawing.Size(24, 24);
            this.pickLightDesiredColorBtn.TabIndex = 8;
            this.pickLightDesiredColorBtn.UseVisualStyleBackColor = true;
            this.pickLightDesiredColorBtn.Click += new System.EventHandler(this.PickLightDesiredColorBtn_Click);
            // 
            // pickBlueDesiredColorBtn
            // 
            this.pickBlueDesiredColorBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pickBlueDesiredColorBtn.Image = global::EnvironmentColorsFinder.Properties.Resources.ColorPicker_12x_16x;
            this.pickBlueDesiredColorBtn.Location = new System.Drawing.Point(413, 63);
            this.pickBlueDesiredColorBtn.Name = "pickBlueDesiredColorBtn";
            this.pickBlueDesiredColorBtn.Size = new System.Drawing.Size(24, 24);
            this.pickBlueDesiredColorBtn.TabIndex = 9;
            this.pickBlueDesiredColorBtn.UseVisualStyleBackColor = true;
            this.pickBlueDesiredColorBtn.Click += new System.EventHandler(this.PickBlueDesiredColorBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 172);
            this.Controls.Add(this.tableLayoutPnl);
            this.MinimumSize = new System.Drawing.Size(355, 211);
            this.Name = "MainForm";
            this.Text = "EnvironmentColors finder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.darkDesiredColorPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightDesiredColorPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkBestMatchPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightBestMatchPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueBestMatchPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueDesiredColorPic)).EndInit();
            this.tableLayoutPnl.ResumeLayout(false);
            this.tableLayoutPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox darkDesiredColorTxt;
        private System.Windows.Forms.TextBox lightDesiredColorTxt;
        private System.Windows.Forms.PictureBox darkDesiredColorPic;
        private System.Windows.Forms.PictureBox lightDesiredColorPic;
        private System.Windows.Forms.PictureBox darkBestMatchPic;
        private System.Windows.Forms.PictureBox lightBestMatchPic;
        private System.Windows.Forms.ComboBox bestMatchesCmb;
        private System.Windows.Forms.PictureBox blueBestMatchPic;
        private System.Windows.Forms.PictureBox blueDesiredColorPic;
        private System.Windows.Forms.TextBox blueDesiredColorTxt;
        private System.Windows.Forms.CheckBox darkDesiredColorChk;
        private System.Windows.Forms.CheckBox lightDesiredColorChk;
        private System.Windows.Forms.CheckBox blueDesiredColorChk;
        private System.Windows.Forms.ColorDialog colorPickerDlg;
        private System.Windows.Forms.Button copyToClipboardBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPnl;
        private System.Windows.Forms.Button pickDarkDesiredColorBtn;
        private System.Windows.Forms.Button pickLightDesiredColorBtn;
        private System.Windows.Forms.Button pickBlueDesiredColorBtn;
    }
}

