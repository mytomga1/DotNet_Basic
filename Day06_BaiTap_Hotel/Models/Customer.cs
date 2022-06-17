using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_BaiTap_Hotel.Models
{
    /*
     1. Thiết kế lớp đối tượng khách hàng gồm các thuộc tính (Số CMTND, họ tên, tuổi, giới tính, quê quán)

            - Thiết kế get/set cho thuộc tính

            - Tạo hàm tạo ko đối và đầy đủ đối số

            - Tạo hàm nhập và hiển thị thông tin   
    */
    public class Customer
    {
        public string CMND { get; set; }
        public string Fullname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

        public Customer() { }

        public void Nhap() {

            Console.Write("NHập CMND : ");
            CMND = Console.ReadLine();

            InputWithoutCmnd();
        }

        public void InputWithoutCmnd()
        {
            Console.Write("Nhập Tên : ");
            Fullname = Console.ReadLine();

            Console.Write("Nhập tuổi : ");
            Age = int.Parse(Console.ReadLine());

            Console.Write("Nhập Giới Tính : ");
            Gender = Console.ReadLine();

            Console.Write("Nhập Địa Chỉ : ");
            Address = Console.ReadLine();
        }

        public void HienThi() {

            Console.WriteLine("CMND : {0}, Tên : {1}, Tuổi : {2}, Giới Tính : {3}, Địa Chỉ : {4}",
                               CMND,Fullname,Age,Gender,Address);
            Console.WriteLine("======================================================");
        }
    }
}
 