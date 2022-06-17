using System;
using System.Collections.Generic;
using Day07_BaiTap_QLSinhVien_Import.Export_JSON.Models;

namespace Day07_BaiTap_QLSinhVien_Import.Export_JSON
{
    /*
     * III - Tạo lớp main chứa mảng đối tượng ClassRoom List<ClassRoom> classlist = new ArrayList<>()
     * Sau đó Xây Dựng menu chương trình như sau :
       1. Nhập thông tin sinh vien từ file json(data.json -> xem nội dung file dc import ở dưới)
       2. Hiển Thị Thông tin SV
       3. Lưu Thông Tin Lớp Học vào 1 file ten_lop.obj
     * Chú thích :
       - Khi người dùng chọn 1 : thực hiện dọc dữ liệu từ file data.json và lưu thông tin đọc vào mảng classList
       _ Khi người dùng chọn 2 : Hiện thị thông tin lớp học từ mảng classList
       - Khi người dùng chọn 3 : thực hiện lưu thông tin từng lớp học vào 1 file tương ứng (VD: T1801A.obj)
     */
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Tạo 1 mãng chứa ds ClassRoom
            List<ClassRoom> classRooms = new List<ClassRoom>();
            int choose;

            do
            {
                Menu();
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        ImportJSONFILE(classRooms);
                        break;
                    case 2:
                        HienThi(classRooms);
                        break;
                    case 3:

                        break;
                    case 4:
                        Console.WriteLine("Thoat chuong trinh");
                        break;
                    default:
                        Console.WriteLine("Nhap sai!!!");
                        break;
                }
            } while (choose != 4);

            Console.ReadLine();
        }

        static void ImportJSONFILE(List<ClassRoom> classRooms)
        {
            // B1: Đọc Nội Dung file json
            var content = System.IO.File.ReadAllText(@"data.json");
            Console.WriteLine();
        }

        static void HienThi(List<ClassRoom> classRooms)
        {
            foreach (ClassRoom room in classRooms) { 
            
                room.HienThi();
            }
        }

        static void Menu()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("1. Nhập thông tin sinh vien từ file Json :");
            Console.WriteLine("2. Hiển Thị Thông tin SV : ");
            Console.WriteLine("3. Lưu Thông Tin Lớp Học vào file Json : ");            
            Console.WriteLine("4. Thoát : ");
            Console.WriteLine("============================================");
            Console.Write("Chọn : ");

        }
    }
}
