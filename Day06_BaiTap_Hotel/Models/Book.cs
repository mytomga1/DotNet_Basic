using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day06_BaiTap_Hotel.Models; 

namespace Day06_BaiTap_Hotel.Models
{
    public class Book
    {
        public string CMNDBK { get; set; }
        public string HotelCodeBK { get; set; }
        public string RoomNoBK { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public Book() { }

        public void Nhap(List<Customer> customers, List<Hotel> hotels)
        {  
            if (hotels.Count == 0) {
                Console.WriteLine("KO CÓ DỮ LIỆU !!!");
                return;
            }

            Console.WriteLine("Enter CMND: ");
            CMNDBK = Console.ReadLine();
            //KT xem đã tồn tại cmnd nay trên hệ thống chưa.
            bool isFind = false;
            foreach (Customer customer in customers){

                if (customer.CMND.Equals(CMNDBK)){
                    isFind = true;
                    break;
                }
            }
            // Nếu kiểm tra cmnd ko tồn tại thì thực thi method nhập mới
            if (!isFind)
            {
                // Nhập mới dữ liệu KH
                Customer customer = new Customer();
                customer.CMND = CMNDBK;
                customer.InputWithoutCmnd();

                customers.Add(customer);
            }

            //Console.WriteLine("Nhập Mã Khách Sạn: ");
            Hotel currentHotel = null;
            for ( ; ; ) {
                foreach (Hotel hotel in hotels) {
                    Console.WriteLine("============================================");
                    Console.WriteLine("Mã Khách Sạn: {0}, Tên Khách Sạn: {1}", hotel.HotelCode, hotel.Name);
                    Console.Write("Nhập Mã Khách Sạn: ");
                }
                HotelCodeBK = Console.ReadLine();

                //Sau khi Nhập xong dữ liệu chúng ta viết 1 hàm kiểm tra
                foreach (Hotel hotel in hotels)
                {
                    if (hotel.HotelCode.Equals(HotelCodeBK)) {
                        currentHotel = hotel;
                        break;
                    }
                }
                if (currentHotel != null) {
                    break;
                }
                Console.Write("(Mã KS Not Found) Nhập lại: ");
            }

            //Console.WriteLine("Nhập Mã Phòng: ");
            if (currentHotel.RoomList.Count == 0) {

                Console.WriteLine("Hiện Tại Khách sạn phòng điều trống chưa ai book phòng");
                return;
            }
            for (; ; ) {
                Console.WriteLine("============================================");
                foreach (Room room in currentHotel.RoomList) {
                    Console.WriteLine(currentHotel.Name +" Hotel [ Mã Phòng: {0}, Tên Phòng: {1} ]", room.RoomNo, room.RoomName);
                    Console.Write("Nhập Mã Phòng: ");
                }
                isFind = false;
                RoomNoBK = Console.ReadLine();

                foreach (Room room in currentHotel.RoomList) {
                    if (room.RoomNo.Equals(RoomNoBK)) { 
                    
                        isFind = true;
                        break;
                    }
                }

                if (isFind)
                {
                    break;
                }
                else {
                    Console.Write("Room Booking (Not Found) Nhập Lại: ");
                }
            }

            Console.Write("Enter Ngay CheckIn (dd/mm/yyyy): ");
            string datetime = Console.ReadLine();
            CheckIn = ConvertStringToDateTime(datetime);

            Console.Write("Enter Ngay CheckOut (dd/mm/yyyy): ");
            datetime = Console.ReadLine();
            CheckOut = ConvertStringToDateTime(datetime);


        }

        // tạo 1 method ConvertStringToDateTime() để định dạng lại ngày tháng nhập vào
        public DateTime ConvertStringToDateTime(string value)
        {

            DateTime dt = DateTime.ParseExact(value, "dd/mm/yyyy", null);
            return dt;
        }
    }
}
