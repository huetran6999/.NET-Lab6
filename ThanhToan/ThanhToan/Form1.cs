﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThanhToan
{
    public partial class frmThanhtoan : Form
    {
        public frmThanhtoan()
        {
            InitializeComponent();

            btnLuu.Enabled = false;
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
            int max=clsData.getMaxRecord("khachhang");
            txtSoHD.Text = max.ToString();
        }
    }
}
