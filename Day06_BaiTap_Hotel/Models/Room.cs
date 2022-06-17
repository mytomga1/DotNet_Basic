using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_BaiTap_Hotel.Models
{
    public class Room
    {
        public string RoomName { get; set; }
        public float Price { get; set; }
        public string RoomNo { get; set; }
        public int PeopleMax { get; set; }
        public int Floor { get; set; }

        public Room() { }

        public void Nhap()
        {

            Console.Write("NHập mã phòng : ");
            RoomNo = Console.ReadLine();

            Console.Write("Nhập Tên phòng : ");
            RoomName = Console.ReadLine();

            Console.Write("Giá Phòng : ");
            Price = float.Parse(Console.ReadLine());

            Console.Write("Phòng mấy người : ");
            PeopleMax = int.Parse(Console.ReadLine());

            Console.Write("Lầu mấy : ");
            Floor = int.Parse(Console.ReadLine());
        }
        public void HienThi()
        {

            Console.WriteLine("[ Mã Phòng : {0}, Tên Phòng : {1}, Giá Phòng : {2}, Phòng mấy người: {3}, Tầng : {4} ]",
                               RoomNo,RoomName,Price,PeopleMax,Floor);
        }
    }
}
