using System;
using System.Collections.Generic;
using Day08_BaiTap_QLSinhVien_CSDL.Utils;
using Day08_BaiTap_QLSinhVien_CSDL.Models;
using Day08_BaiTap_QLSinhVien_CSDL.DataBase;

namespace Day08_BaiTap_QLSinhVien_CSDL
{   /*
     * Nội dung kiến thức:
	        Kết nối CSDL MySQL <-> C# (C Sharp)

        Mini Project:
	        Viết 1 chương trình quản lý sinh
	        Menu chương trình:
		        1. Xem danh sách sinh viên
		        2. Thêm sinh viên vào CSDL
		        3. Sửa thông tin sinh viên
		        4. Xoá
		        5. Thoát

        B1. Chuẩn bị database + tables
        B2. Tạo dự án + add thư viện hỗ trợ kết CSDL MySQL <-> C#
        B3. Mapping Models <-> Tables (CSDL)
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int choose;
            do {

                Menu();
                choose = Utility.ReadInt();

                switch (choose) { 
                
                    case 1:
                        HienThiDS();
                        break;
                    case 2:
                        AddNew();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Delete();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Nhập Sai !!!");
                        break;
                }
            }while (choose != 5);
        }

        #region 1. Xem danh sách sinh viên
        private static void HienThiDS()
        {
            List<Students> studentsList = StudentDAO.GetStudents();

            Console.WriteLine("===== DS Sinh Viên =========================");
            foreach (Students std in studentsList)
            {

                std.HienThi();
            }
        }
        #endregion

        #region 2. Thêm sinh viên vào CSDL
        private static void AddNew()
        {
            Console.WriteLine("=============[Add New SinhVien]=============");
            Students students = new Students();
            students.Nhap();

            StudentDAO.AddNewSV(students);
            Console.WriteLine("==> Thêm Thành Công");
        }
        #endregion

        #region 3. Sửa thông tin sinh viên
        private static void Update()
        {
            Console.WriteLine("===== Update Info Sinh Viên =================");
            Console.WriteLine("=> Nhập ID Sinh Viên Cần Sửa Info: ");
            int id = Utility.ReadInt();// gọi đến hàm ReadInt() tại class Utility để lấy id SV

            //Kiêm tra id có tồn tại ko
            Students stdFind = StudentDAO.FindById(id);

            if (stdFind != null)
            {
                stdFind.Nhap();
                StudentDAO.UpdateInfoSV(stdFind);
                Console.WriteLine("==> Cập Nhật Thông Tin Thành Công");
            }
            else
            {

                Console.WriteLine("(Student ID Not Fount) Please Try Again !!!");
            }
        }
        #endregion


        #region 4. XOÁ
        private static void Delete()
        {
            Console.WriteLine("===== Delete Sinh Viên ====================");
            Console.WriteLine("=> Nhập ID Sinh Viên Muốn Xoá: ");
            int id = Utility.ReadInt();

            //Kiêm tra id có tồn tại ko
            Students stdFind = StudentDAO.FindById(id);

            if (stdFind != null)
            {
                StudentDAO.DeleteSV(id);
                Console.WriteLine("==> Xoá Thành Công");

            }
            else
            {

                Console.WriteLine("(Student ID Not Fount) Please Try Again !!!");
            }
        }
        #endregion

        static void Menu()
        {
            Console.WriteLine("=============[QLSinhVien]====================");
            Console.WriteLine("1. Xem danh sách sinh viên");
            Console.WriteLine("2. Thêm sinh viên vào CSDL");
            Console.WriteLine("3. Sửa thông tin sinh viên");
            Console.WriteLine("4. Xoá");
            Console.WriteLine("5. Thoát");
            Console.WriteLine("============================================");
            Console.Write("Chọn : ");

        }
    }
}
