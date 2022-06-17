using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_BaiTap_QLSinhVien_CSDL.DataBase
{
    public class Config
    {
        static string HOST = "localhost";
        static string PORT = "3306";
        static string DATABASE = "bt_qlsv";
        static string USERNAME = "root";
        static string PASSWORD = "";

        #region Viết code theo cách tối ưu
        public static string getConnectionString() {

            string connString = string.Format("SERVER={0};PORT={1};DATABASE={2};UID={3};PASSWORD={4};SSL Mode=None",
                                               HOST, PORT, DATABASE,USERNAME,PASSWORD);
            return connString;
        }
        #endregion
    }
}
