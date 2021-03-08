
namespace ThanhToan
{
    partial class frmThanhtoan
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
            this.lblSoHD = new System.Windows.Forms.Label();
            this.lblSophong = new System.Windows.Forms.Label();
            this.lblNgayTT = new System.Windows.Forms.Label();
            this.lblSotienTT = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblHoten = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.txtSotienTT = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.cboSophong = new System.Windows.Forms.ComboBox();
            this.dtNgayTT = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblSoHD
            // 
            this.lblSoHD.AutoSize = true;
            this.lblSoHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoHD.Location = new System.Drawing.Point(30, 53);
            this.lblSoHD.Name = "lblSoHD";
            this.lblSoHD.Size = new System.Drawing.Size(70, 25);
            this.lblSoHD.TabIndex = 0;
            this.lblSoHD.Text = "Số HĐ";
            // 
            // lblSophong
            // 
            this.lblSophong.AutoSize = true;
            this.lblSophong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSophong.Location = new System.Drawing.Point(424, 191);
            this.lblSophong.Name = "lblSophong";
            this.lblSophong.Size = new System.Drawing.Size(97, 25);
            this.lblSophong.TabIndex = 1;
            this.lblSophong.Text = "Số phòng";
            // 
            // lblNgayTT
            // 
            this.lblNgayTT.AutoSize = true;
            this.lblNgayTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTT.Location = new System.Drawing.Point(424, 260);
            this.lblNgayTT.Name = "lblNgayTT";
            this.lblNgayTT.Size = new System.Drawing.Size(89, 25);
            this.lblNgayTT.TabIndex = 2;
            this.lblNgayTT.Text = "Ngày TT";
            // 
            // lblSotienTT
            // 
            this.lblSotienTT.AutoSize = true;
            this.lblSotienTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSotienTT.Location = new System.Drawing.Point(31, 260);
            this.lblSotienTT.Name = "lblSotienTT";
            this.lblSotienTT.Size = new System.Drawing.Size(104, 25);
            this.lblSotienTT.TabIndex = 3;
            this.lblSotienTT.Text = "Số tiền TT";
            this.lblSotienTT.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMND.Location = new System.Drawing.Point(30, 191);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(102, 25);
            this.lblCMND.TabIndex = 4;
            this.lblCMND.Text = "Số CMND";
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoten.Location = new System.Drawing.Point(31, 119);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(69, 25);
            this.lblHoten.TabIndex = 5;
            this.lblHoten.Text = "Họ tên";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(133, 346);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(139, 50);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(600, 346);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(139, 50);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(364, 346);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(139, 50);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // txtSoHD
            // 
            this.txtSoHD.Location = new System.Drawing.Point(150, 57);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(247, 22);
            this.txtSoHD.TabIndex = 9;
            // 
            // txtSotienTT
            // 
            this.txtSotienTT.Location = new System.Drawing.Point(150, 264);
            this.txtSotienTT.Name = "txtSotienTT";
            this.txtSotienTT.Size = new System.Drawing.Size(247, 22);
            this.txtSotienTT.TabIndex = 10;
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(150, 195);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(247, 22);
            this.txtCMND.TabIndex = 11;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(150, 123);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(685, 22);
            this.txtHoten.TabIndex = 12;
            // 
            // cboSophong
            // 
            this.cboSophong.FormattingEnabled = true;
            this.cboSophong.Items.AddRange(new object[] {
            "A101",
            "A102",
            "A103"});
            this.cboSophong.Location = new System.Drawing.Point(546, 188);
            this.cboSophong.Name = "cboSophong";
            this.cboSophong.Size = new System.Drawing.Size(288, 24);
            this.cboSophong.TabIndex = 13;
            // 
            // dtNgayTT
            // 
            this.dtNgayTT.Location = new System.Drawing.Point(546, 256);
            this.dtNgayTT.Name = "dtNgayTT";
            this.dtNgayTT.Size = new System.Drawing.Size(288, 22);
            this.dtNgayTT.TabIndex = 14;
            // 
            // frmThanhtoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.dtNgayTT);
            this.Controls.Add(this.cboSophong);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtSotienTT);
            this.Controls.Add(this.txtSoHD);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblHoten);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.lblSotienTT);
            this.Controls.Add(this.lblNgayTT);
            this.Controls.Add(this.lblSophong);
            this.Controls.Add(this.lblSoHD);
            this.Name = "frmThanhtoan";
            this.Text = "Thanh toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoHD;
        private System.Windows.Forms.Label lblSophong;
        private System.Windows.Forms.Label lblNgayTT;
        private System.Windows.Forms.Label lblSotienTT;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.TextBox txtSotienTT;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.ComboBox cboSophong;
        private System.Windows.Forms.DateTimePicker dtNgayTT;
    }
}

