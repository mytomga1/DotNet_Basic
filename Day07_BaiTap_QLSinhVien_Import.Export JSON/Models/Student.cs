using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_BaiTap_QLSinhVien_Import.Export_JSON.Models
{
    /*
        public string Gender { get; set; }
        1. Tạo 1 lớp đối tượng sinh viên (Student) gồm các thuộc tính : Fullname,Birthday,Email,Address,
           _ Tạo hàm ko đối số và có đầy đủ đối số
           _ Tạo hàm getter & setter
           _ Tạo hàm nhập thông tin và hiển thị thông tin sinh vien
    */


    [Serializable] // sử dụng thằng [ Serializablet : thường dùng để lưu file dc hổ trợ trong C#]
                   // là loại kỹ thuật chuyển đổi object về dạng trung gian (text, mảng byte) phục vụ lưu trữ (trong file) hoặc truyền qua mạng (lập trình socket).
    public class Student
    {
        public string Fullname { get; set; }
        public string Birthday { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }




        public Student() {}

        public void Nhap() {

            Console.Write("Nhập Tên : ");
            Fullname = Console.ReadLine();

            Console.Write("Nhập Ngày Sinh (dd-mm-yyyy): ");
            Birthday = Console.ReadLine();

            Console.Write("Nhập Email : ");
            Email = Console.ReadLine();

            Console.Write("Nhập Địa Chỉ : ");
            Address = Console.ReadLine();

            Console.Write("Nhập Giới Tính : ");
            Gender = Console.ReadLine();
        }

        public void HienThi()
        {
            Console.WriteLine("[ Tên :{0}| Ngày Sinh:{1}| Email:{2}| Địa Chỉ:{3}| Giới Tính{4} ]",
                                Fullname, Birthday, Email, Address, Gender);

        }

    }
}
