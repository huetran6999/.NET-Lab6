using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjDVD
{
    class clsDatabase
    {
        public static SqlConnection con;

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
                con = new SqlConnection("Server=NHATSON-PC\\SQLEXPRESS;Database=DVDLibrary;uid=mylogin;pwd=mylogin;");
                con.Open();
            }
            catch(Exception)
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
            catch(Exception)
            {
                return false;
            }
            return true;
        }
    }
}
