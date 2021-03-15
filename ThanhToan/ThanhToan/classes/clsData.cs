using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ThanhToan
{
    class clsData
    {
        public static SqlConnection con;

        public static int getMaxRecord(string tableName)
        {
            try
            {
                OpenConnection();
                SqlCommand com = new SqlCommand("Select MAX(SoHD) from "+tableName, con);
                int max = Convert.ToInt32(com.ExecuteScalar());
                CloseConnection();
                return max + 1;
            }
            catch (Exception)
            {
                return 1;
            }
        }
        public static bool OpenConnection()
        {
            try
            {
                //con = new SqlConnection();
                /*con.ConnectionString =
                  "Data Source=NHATSON-PC\\SQLEXPRESS;" +
                  "Initial Catalog=DVDLibrary;" +
                  "User ID = mylogin;" +
                 " Password = mylogin;";*/
                //con = new SqlConnection("Data Source=NHATSON-PC\\PC-ASUS;Initial Catalog=DVDLibrary;User ID=mylogin;Password=mylogin");
                con = new SqlConnection("Server=NHATSON-PC\\SQLEXPRESS;Database=ThanhToan;uid=mylogin;pwd=mylogin;");
                con.Open();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static bool CloseConnection()
        {
            try
            {
                con.Close();

            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static bool insertKhachHang(int soHD,string hoTen,string soCMND,int maPhong,DateTime ngayTT,string soTien)
        {
            try
            {
                OpenConnection();
                string strInsert = "Insert Into khachhang Values (@SoHD,@TenKH,@SoCMND,@SoTien,@NgayTT,@Phong)";
                SqlCommand com = new SqlCommand(strInsert, con);

                SqlParameter p1 = new SqlParameter("@SoHD", SqlDbType.Int);
                p1.Value = soHD;
                SqlParameter p2 = new SqlParameter("@TenKH", SqlDbType.NVarChar);
                p2.Value = hoTen;
                SqlParameter p3 = new SqlParameter("@SoCMND", SqlDbType.NVarChar);
                p3.Value = soCMND;
                SqlParameter p4 = new SqlParameter("@SoTien", SqlDbType.NVarChar);
                p4.Value = soTien;
                SqlParameter p5 = new SqlParameter("@NgayTT", SqlDbType.DateTime);
                p5.Value = ngayTT;
                SqlParameter p6 = new SqlParameter("@Phong", SqlDbType.Int);
                p6.Value = maPhong;

                com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                com.Parameters.Add(p3);
                com.Parameters.Add(p4);
                com.Parameters.Add(p5);
                com.Parameters.Add(p6);

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            MessageBox.Show("Insert successfully!!!");
            CloseConnection();
            return true;
        }

    }
}
