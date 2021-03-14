using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace ThongtinCanBo
{
    public partial class frmCanbo : Form
    {
        int codeNo = 0;
        public string textTest = "";
        public frmCanbo()
        {
            InitializeComponent();
            btnSave.Enabled = false;

        }

        private void btnAdd_click(object sender, EventArgs e)
        {
            ResetField();
            try
            {
                DBConnect.OpenConnect();
                SqlCommand cmd = new SqlCommand("select Max(MaCB) from canbo", DBConnect.con);
                codeNo = Convert.ToInt32(cmd.ExecuteScalar());
                DBConnect.CloseConnect();
            }
            catch (Exception ex)
            {
                codeNo = 0;
            }
            codeNo++;
            txtMSCB.Text = codeNo.ToString();
            btnAdd.Enabled = false;
            btnSave.Enabled = true;

        }
        private void ResetField()
        {
            txtHoTenCB.Text = "";
            txtDongia.Text = "";
            txtGiogiang.Text = "";
            txtMSCB.Text = "";
            txtMSCB.Text = "";
            cboChucvu.Text = "";

        }
        public void bindDataCb()
        {
            if (DBConnect.OpenConnect() == true)
            {
                SqlCommand cmd = new SqlCommand("select * from chucvu", DBConnect.con);
                SqlDataAdapter d = new SqlDataAdapter("select * from chucvu", DBConnect.con);
                DataSet dt = new DataSet();
                d.Fill(dt);
                if (dt.Tables[0].Rows.Count > 0)
                {
                    cboChucvu.DataSource = dt.Tables[0];
                    cboChucvu.DisplayMember = "tencv";
                    cboChucvu.ValueMember = "macv";
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
            else
            {
                Console.WriteLine("connect fail");
            }
        }

        private void getValue(object sender, EventArgs e)
        {
            bindDataCb();
        }

        private void btnSave_click(object sender, EventArgs e)
        {
            if (checkNull() == true)
            {
                string[] arr = { txtMSCB.Text, txtHoTenCB.Text, cboChucvu.SelectedIndex.ToString(), txtGiogiang.Text, txtDongia.Text };
                    try
                    {
                        DBConnect.OpenConnect();
                        SqlCommand cmd = new SqlCommand(DBConnect.InsertData("canbo", DBConnect.makeString(arr)), DBConnect.con);
                        int a = cmd.ExecuteNonQuery();
                        DBConnect.CloseConnect();
                        if (a == 0)
                        {
                            MessageBox.Show("Not success!");
                        }
                        else
                        {
                            MessageBox.Show("Success save!");
                            ResetField();
                            btnAdd.Enabled = true;
                            btnSave.Enabled = false;
                        }
                    }
                    catch (Exception ex)
                    {
                    //MessageBox.Show("Error!");
                    MessageBox.Show(DBConnect.strValue); ;
                    Console.WriteLine(DBConnect.strValue);
                }

            }
        }
        public Boolean checkNull()
        {
            if (txtHoTenCB.Text != ""  && txtGiogiang.Text != "" && txtDongia.Text !="" && cboChucvu.Text != "")
            {
                textTest = txtMSCB.Text+ " " + txtHoTenCB.Text + 
                    " " + cboChucvu.Text+ " " + txtGiogiang.Text + " " + txtDongia.Text;
                return true;
            }
            return false;
        }

        private void btnClose_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
