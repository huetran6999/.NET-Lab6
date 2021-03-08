using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjDVD.classes
{
    class clsDatabase
    {
        public static SqlConnection con;

        public static bool OpenConnection()
        {
            try
            {
                con = new SqlConnection("Data Source=localhost,3306;Database=DVDLibrary;User ID=mylogin;Password=mylogin");
                con.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }   
    }
}
