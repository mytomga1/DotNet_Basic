using Day08_BaiTap_QLSinhVien_CSDL.Models;
using Day08_BaiTap_QLSinhVien_CSDL.Utils;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Day08_BaiTap_QLSinhVien_CSDL.DataBase
{
    public class StudentDAO
    {
        #region Chức năng Hiển thị Danh Sách SV
        // Hàm này sẽ có nhiệm vụ lấy tất cả dữ liệu trong bản Student trong DB
        public static List<Students> GetStudents()
        {

            #region Code Theo Cách cũ chưa tối ưu
            //// Open Connection
            //string connString = string.Format("SERVER={0};PORT={1};DATABASE={2};UID={3};PASSWORD={4};SSL Mode=None",
            //                                   Config.HOST, Config.PORT, Config.DATABASE, Config.USERNAME, Config.PASSWORD);

            //MySqlConnection conn = new MySqlConnection(connString);
            //conn.Open();

            ////Query
            //string sql = "SELECT * FROM `students` WHERE 1";
            //MySqlCommand cmd = new MySqlCommand(sql, conn); // dòng này có nv chạy câu query select
            //MySqlDataReader reader = cmd.ExecuteReader(); // sau khi chạy query xong nó sẻ đọc và đỗ dữ liệu vào thằng ySqlDataReader reader

            //while (reader.Read())
            //{ // sử dụng while để đọc mỗi bản ghi

            //    //string fullname = reader.GetString(1);
            //    int id = int.Parse(reader["id"].ToString());
            //    string fullname = reader["fullname"].ToString();
            //    string gender = reader["gender"].ToString();
            //    int age = int.Parse(reader["age"].ToString());
            //    string email = reader["email"].ToString();
            //    string phone_number = reader["phone_number"].ToString();

            //    Students std = new Students(id, fullname, gender, age, email, phone_number);
            //    dataList.Add(std); // sau đó lưu dữ liệu vào datalist chuyển về cho class Students
            //}

            ////Close Connection
            //conn.Close();

            //return dataList;
            #endregion

            List<Students> dataList = new List<Students>();

            // Open Connection
            MySqlConnection conn = new MySqlConnection(Config.getConnectionString());
            conn.Open();

            //Query
            string sql = "SELECT * FROM `students` WHERE 1";
            MySqlCommand cmd = new MySqlCommand(sql, conn); // dòng này có nv chạy câu query select
            MySqlDataReader reader = cmd.ExecuteReader(); // sau khi chạy query xong nó sẻ đọc và đỗ dữ liệu vào thằng ySqlDataReader reader

            while (reader.Read())
            { // sử dụng while để đọc mỗi bản ghi

                //string fullname = reader.GetString(1);
                int id = int.Parse(reader["id"].ToString());
                string fullname = reader["fullname"].ToString();
                string gender = reader["gender"].ToString();
                int age = int.Parse(reader["age"].ToString());
                string email = reader["email"].ToString();
                string phone_number = reader["phone_number"].ToString();

                Students std = new Students(id, fullname, gender, age, email, phone_number);
                dataList.Add(std); // sau đó lưu dữ liệu vào datalist chuyển về cho class Students
            }

            //Close Connection
            conn.Close();

            return dataList;
        }
        #endregion

        #region Chức Năng thêm SV
        public static void AddNewSV(Students std)
        {
            // Open Connection
            MySqlConnection conn = new MySqlConnection(Config.getConnectionString());
            conn.Open();

            //Query
            string sql = "INSERT INTO `students`(`fullname`, `gender`, `age`, `email`, `phone_number`) " +
                         "VALUES (@fullname, @gender, @age, @email, @phone_number)";

            MySqlCommand cmd = new MySqlCommand(sql, conn); // dòng này có nv chạy câu query select
            cmd.Parameters.AddWithValue("@fullname", std.Fullname);
            cmd.Parameters.AddWithValue("@gender", std.Gender);
            cmd.Parameters.AddWithValue("@age", std.Age);
            cmd.Parameters.AddWithValue("@email", std.Email);
            cmd.Parameters.AddWithValue("@phone_number", std.PhoneNumber);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        #endregion

        #region Hàm Check ID 

        public static Students FindById(int id)
        {
            Students std = null;

            // Open Connection
            MySqlConnection conn = new MySqlConnection(Config.getConnectionString());
            conn.Open();

            //Query
            string sql = "SELECT * FROM `students` WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(sql, conn); // dòng này có nv chạy câu query select
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd.ExecuteReader(); // sau khi chạy query xong nó sẻ đọc và đỗ dữ liệu vào thằng ySqlDataReader reader

            if (reader.Read())
            { // sử dụng while để đọc mỗi bản ghi

                string fullname = reader["fullname"].ToString();
                string gender = reader["gender"].ToString();
                int age = int.Parse(reader["age"].ToString());
                string email = reader["email"].ToString();
                string phone_number = reader["phone_number"].ToString();

                std = new Students(id,fullname, gender, age, email, phone_number);

            }
            //Close Connection
            conn.Close();

            return std;
        }
        #endregion

        #region Chức Năng Update
        public static void UpdateInfoSV(Students std)
        {
            // Open Connection
            MySqlConnection conn = new MySqlConnection(Config.getConnectionString());
            conn.Open();

            //Query
            string sql = "UPDATE `students` SET `fullname`=@fullname, `gender`=@gender, `age`=@age, `email`=@email, `phone_number`=@phone_number WHERE id=@id";


            MySqlCommand cmd = new MySqlCommand(sql, conn); // dòng này có nv chạy câu query select
            cmd.Parameters.AddWithValue("@fullname", std.Fullname);
            cmd.Parameters.AddWithValue("@gender", std.Gender);
            cmd.Parameters.AddWithValue("@age", std.Age);
            cmd.Parameters.AddWithValue("@email", std.Email);
            cmd.Parameters.AddWithValue("@phone_number", std.PhoneNumber);
            cmd.Parameters.AddWithValue("@id", std.ID);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        #endregion

        #region Chức Năng Xoá
        public static void DeleteSV(int id)
        {
            // Open Connection
            MySqlConnection conn = new MySqlConnection(Config.getConnectionString());
            conn.Open();

            //Query
            string sql = "DELETE FROM `students` WHERE `id`=@id";


            MySqlCommand cmd = new MySqlCommand(sql, conn); // dòng này có nv chạy câu query select

            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        #endregion
    }
}
