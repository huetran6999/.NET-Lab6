using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace ThanhToan
{
    public partial class frmThanhtoan : Form
    {
        public frmThanhtoan()
        {
            InitializeComponent();

            btnLuu.Enabled = false;
            cboNgayTT.SelectedIndex = -1;
            txtSoHD.Enabled = false;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmThanhtoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'timeget.gettime3' table. You can move, or remove it, as needed.
            this.gettime3TableAdapter.Fill(this.timeget.gettime3);
            // TODO: This line of code loads data into the 'thanhToanDataSet.phong' table. You can move, or remove it, as needed.
            this.phongTableAdapter.Fill(this.thanhToanDataSet.phong);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtNgayTT_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cboNgayTT.DataSource = gettime3BindingSource;
            cboNgayTT.Refresh();
            int max=clsData.getMaxRecord("khachhang");
            txtSoHD.Text = max.ToString();
            btnLuu.Enabled = true;
            txtHoten.Text = "";
            txtCMND.Text = "";
            txtSotienTT.Text = "";
            

            cboNgayTT.SelectedIndex = -1;
            cboSophong.SelectedIndex = -1;
          
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            


            clsData.insertKhachHang(Int32.Parse(txtSoHD.Text), txtHoten.Text, txtCMND.Text, Int32.Parse((cboSophong.SelectedItem as DataRowView)["MaPhong"].ToString()), DateTime.Parse((cboNgayTT.SelectedItem as DataRowView)["result"].ToString()),txtSotienTT.Text);
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.gettime3TableAdapter.FillBy(this.timeget.gettime3);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.gettime3TableAdapter.FillBy1(this.timeget.gettime3);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
