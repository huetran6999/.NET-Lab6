using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    
}
}
