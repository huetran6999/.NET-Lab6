using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ThongtinCanBo
{
    class DBConnect
    {
        public static SqlConnection con;
        public static  String strValue = "";
        public static Boolean OpenConnect() {
            try {
                con = new SqlConnection("server=NHATSON-PC\\SQLEXPRESS; database=QLCB;uid=mylogin;pwd=mylogin");
                con.Open();
            } catch(Exception ex) {
                return false;
            }
            return true;
        }
        public static bool CloseConnect() {
            try
            {
                con.Close();
            }
            catch (Exception ex) {
                return false;
            }
            return true;
        }
        public static string makeString(string[] arr )
        {
            string onConvert = "";
            string converted = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (i + 1 == arr.Length)
                {
                    onConvert = onConvert + "'" + arr[i] + "'";
                }
                else
                {
                    onConvert = onConvert + "'" + arr[i] + "'" + ",";
                }
            }
            converted = "(" + onConvert + ")";
            return converted;
        }
        public static String InsertData(String tableName, String value)
        {
            String insertString = "";
            insertString = "insert into " + tableName + " values " + value;
            strValue = insertString;
            return insertString;
        }
    }
}
