using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day06_BaiTap_Hotel.Models;

namespace Day06_BaiTap_Hotel.Models
{
    /*
     2. Thiết kế lớp Hotel gồm các thuộc tính : tên, địa chỉ, loại khách sạn (VIP, Bình dân,...), danh sách các Room, mã khách sạn
        - Thiết kế get/set cho thuộc tính
        - Tạo hàm tạo ko đối và đầy đủ đối số
        - Tạo hàm nhập và hiển thị thông tin
    */

    public class Hotel
    {
        public string HotelCode { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string LoaiKS { get; set; }
        public List<Room> RoomList { get; set; }

        public Hotel() { 
        
            RoomList = new List<Room>();
        }

        public void Nhap()
        {
            Console.WriteLine("===========================================");
            Console.Write("Enter MaSo Hotel: ");
            HotelCode = Console.ReadLine();

            Console.Write("Enter Name Hotel: ");
            Name = Console.ReadLine();

            Console.Write("Enter Address: ");
            Address = Console.ReadLine();

            Console.Write("Enter Loai Hotel (Vip, Normal): ");
            LoaiKS = Console.ReadLine();

            for (; ; )
            {

                Room room = new Room();
                room.Nhap();

                RoomList.Add(room);

                Console.Write("Co Tiep Tuc Nhap Hay Ko? Y/N: ");
                string option = Console.ReadLine();

                if (option.ToUpper().Equals("N")) { 
                    break; 
                }
            }
        }
        public void HienThi()
        {

            Console.WriteLine("Hotel Info : [ MaSo: {0}, Name: {1}, Address: {2}, Loai: {3} ]",
                               HotelCode, Name, Address, LoaiKS);

            foreach (Room room in RoomList)
            {
                room.HienThi();
            }
        }
    }
}
