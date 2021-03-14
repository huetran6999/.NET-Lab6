
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
            this.components = new System.ComponentModel.Container();
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
            this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thanhToanDataSet = new ThanhToan.ThanhToanDataSet();
            this.phongTableAdapter = new ThanhToan.ThanhToanDataSetTableAdapters.phongTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gettime3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeget = new ThanhToan.timeget();
            this.thanhToanDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gettime3TableAdapter = new ThanhToan.timegetTableAdapters.gettime3TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhToanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gettime3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhToanDataSetBindingSource)).BeginInit();
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
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
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
            this.cboSophong.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.phongBindingSource, "MaPhong", true));
            this.cboSophong.DataSource = this.phongBindingSource;
            this.cboSophong.DisplayMember = "TenPhong";
            this.cboSophong.FormattingEnabled = true;
            this.cboSophong.Location = new System.Drawing.Point(546, 188);
            this.cboSophong.Name = "cboSophong";
            this.cboSophong.Size = new System.Drawing.Size(288, 24);
            this.cboSophong.TabIndex = 13;
            this.cboSophong.ValueMember = "MaPhong";
            // 
            // phongBindingSource
            // 
            this.phongBindingSource.DataMember = "phong";
            this.phongBindingSource.DataSource = this.thanhToanDataSet;
            // 
            // thanhToanDataSet
            // 
            this.thanhToanDataSet.DataSetName = "ThanhToanDataSet";
            this.thanhToanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phongTableAdapter
            // 
            this.phongTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.gettime3BindingSource;
            this.comboBox1.DisplayMember = "result";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(546, 260);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(288, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "result";
            // 
            // gettime3BindingSource
            // 
            this.gettime3BindingSource.DataMember = "gettime3";
            this.gettime3BindingSource.DataSource = this.timeget;
            // 
            // timeget
            // 
            this.timeget.DataSetName = "timeget";
            this.timeget.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thanhToanDataSetBindingSource
            // 
            this.thanhToanDataSetBindingSource.DataSource = this.thanhToanDataSet;
            this.thanhToanDataSetBindingSource.Position = 0;
            // 
            // gettime3TableAdapter
            // 
            this.gettime3TableAdapter.ClearBeforeFill = true;
            // 
            // frmThanhtoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.comboBox1);
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
            this.Load += new System.EventHandler(this.frmThanhtoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhToanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gettime3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhToanDataSetBindingSource)).EndInit();
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
        private ThanhToanDataSet thanhToanDataSet;
        private System.Windows.Forms.BindingSource phongBindingSource;
        private ThanhToanDataSetTableAdapters.phongTableAdapter phongTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource thanhToanDataSetBindingSource;
        private timeget timeget;
        private System.Windows.Forms.BindingSource gettime3BindingSource;
        private timegetTableAdapters.gettime3TableAdapter gettime3TableAdapter;
    }
}

