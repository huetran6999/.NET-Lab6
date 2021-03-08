
namespace prjDVD
{
    partial class frmDVDCatalog
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblDVDCodeNo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLang = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.grpSubTitles = new System.Windows.Forms.GroupBox();
            this.radYes = new System.Windows.Forms.RadioButton();
            this.radNo = new System.Windows.Forms.RadioButton();
            this.cboLang = new System.Windows.Forms.ComboBox();
            this.updPrice = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grpSubTitles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(165, 38);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(199, 36);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "DVD Catalog";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // lblDVDCodeNo
            // 
            this.lblDVDCodeNo.AutoSize = true;
            this.lblDVDCodeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDVDCodeNo.Location = new System.Drawing.Point(35, 122);
            this.lblDVDCodeNo.Name = "lblDVDCodeNo";
            this.lblDVDCodeNo.Size = new System.Drawing.Size(120, 20);
            this.lblDVDCodeNo.TabIndex = 1;
            this.lblDVDCodeNo.Text = "DVD Number";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(35, 172);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(92, 20);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "DVD Title";
            // 
            // lblLang
            // 
            this.lblLang.AutoSize = true;
            this.lblLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLang.Location = new System.Drawing.Point(35, 221);
            this.lblLang.Name = "lblLang";
            this.lblLang.Size = new System.Drawing.Size(80, 20);
            this.lblLang.TabIndex = 3;
            this.lblLang.Text = "Languge";
            this.lblLang.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(35, 270);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 20);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // grpSubTitles
            // 
            this.grpSubTitles.Controls.Add(this.radNo);
            this.grpSubTitles.Controls.Add(this.radYes);
            this.grpSubTitles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSubTitles.Location = new System.Drawing.Point(145, 335);
            this.grpSubTitles.Name = "grpSubTitles";
            this.grpSubTitles.Size = new System.Drawing.Size(219, 100);
            this.grpSubTitles.TabIndex = 5;
            this.grpSubTitles.TabStop = false;
            this.grpSubTitles.Text = "Subtitles";
            // 
            // radYes
            // 
            this.radYes.AutoSize = true;
            this.radYes.Checked = true;
            this.radYes.Location = new System.Drawing.Point(26, 39);
            this.radYes.Name = "radYes";
            this.radYes.Size = new System.Drawing.Size(61, 24);
            this.radYes.TabIndex = 0;
            this.radYes.TabStop = true;
            this.radYes.Text = "Yes";
            this.radYes.UseVisualStyleBackColor = true;
            // 
            // radNo
            // 
            this.radNo.AutoSize = true;
            this.radNo.Location = new System.Drawing.Point(132, 39);
            this.radNo.Name = "radNo";
            this.radNo.Size = new System.Drawing.Size(53, 24);
            this.radNo.TabIndex = 1;
            this.radNo.Text = "No";
            this.radNo.UseVisualStyleBackColor = true;
            // 
            // cboLang
            // 
            this.cboLang.FormattingEnabled = true;
            this.cboLang.Items.AddRange(new object[] {
            "English",
            "Spanish",
            "French",
            "Chinese",
            "Russian"});
            this.cboLang.Location = new System.Drawing.Point(186, 224);
            this.cboLang.Name = "cboLang";
            this.cboLang.Size = new System.Drawing.Size(274, 24);
            this.cboLang.TabIndex = 6;
            // 
            // updPrice
            // 
            this.updPrice.Location = new System.Drawing.Point(192, 272);
            this.updPrice.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.updPrice.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.updPrice.Name = "updPrice";
            this.updPrice.Size = new System.Drawing.Size(267, 22);
            this.updPrice.TabIndex = 7;
            this.updPrice.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 22);
            this.textBox1.TabIndex = 8;
            // 
            // frmDVDCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 499);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.updPrice);
            this.Controls.Add(this.cboLang);
            this.Controls.Add(this.grpSubTitles);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblLang);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDVDCodeNo);
            this.Controls.Add(this.lblHeading);
            this.Name = "frmDVDCatalog";
            this.Text = "DVD Library";
            this.grpSubTitles.ResumeLayout(false);
            this.grpSubTitles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblDVDCodeNo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLang;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox grpSubTitles;
        private System.Windows.Forms.RadioButton radNo;
        private System.Windows.Forms.RadioButton radYes;
        private System.Windows.Forms.ComboBox cboLang;
        private System.Windows.Forms.NumericUpDown updPrice;
        private System.Windows.Forms.TextBox textBox1;
    }
}

