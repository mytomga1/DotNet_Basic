using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Day08_BaiTap_QLSinhVien_CSDL.Utils;

namespace Day08_BaiTap_QLSinhVien_CSDL.Models
{
    public class Students
    {
        public int ID { get; set; }
        public string Fullname { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }

        public Students() { }

        // Create hàm tạo Student có đầy đủ đối số
        public Students(int iD, string fullname, string gender, int age, string email, string phoneNumber)
        {
            ID = iD;
            Fullname = fullname;
            Gender = gender;
            Age = age;
            Email = email;
            PhoneNumber = phoneNumber;
            
        }

        public void Nhap() {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập Tên Sinh Viên : ");
            Fullname = Console.ReadLine();

            Console.Write("Nhập Giới Tính : ");
            Gender = Console.ReadLine();

            Console.Write("Nhập Tuổi : ");
            Age = Utility.ReadInt(); // Dẩy dữ liệu tuổi qua method ReadInt() bắt lỗi kiễu data

            Console.Write("Nhập Email : ");
            Email = Console.ReadLine();

            Console.Write("Nhập Số ĐT : ");
            PhoneNumber = Console.ReadLine();

            Console.WriteLine();            
        }

        public void HienThi() {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("[ ID:{0}, Tên:{1}, Giới Tính:{2}, Email:{3}, Số ĐT:{4}, Tuổi:{5} ]",
                               ID,Fullname,Gender,Email,PhoneNumber,Age);
        }
    }
}
