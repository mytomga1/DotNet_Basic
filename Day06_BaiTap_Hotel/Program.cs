using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day06_BaiTap_Hotel.Models;

namespace Day06_BaiTap_Hotel
{
    /*     
        Xây dựng menu chương trình như sau

        1. Nhập thông tin khách sạn

        2. Hiển thị thông tin khách sạn

        3. Đặt phong nghỉ

        4. Tìm phòng còn trống

        5. Thống kê doanh duy khách sạn

        6. Tìm kiếm thông tin khách hàng.

        7. Thoát chương trình

        Yêu cầu :

        1. Thiết kế lớp đối tượng khách hàng gồm các thuộc tính (Số CMTND, họ tên, tuổi, giới tính, quê quán)

            - Thiết kế get/set cho thuộc tính

            - Tạo hàm tạo ko đối và đầy đủ đối số

            - Tạo hàm nhập và hiển thị thông tin

        2. Thiết kế lớp Hotel gồm các thuộc tính : tên, địa chỉ, loại khách sạn (VIP, Bình dân,...), danh sách các Room, mã khách sạn


            - Thiết kế get/set cho thuộc tính

            - Tạo hàm tạo ko đối và đầy đủ đối số

            - Tạo hàm nhập và hiển thị thông tin

        3. Thiết kế lớp Room gồm các thuộc tính : Tên phòng, giá tiền, tầng, số người tối đa ở, mã phòng

            - Thiết kế get/set cho thuộc tính

            - Tạo hàm tạo ko đối và đầy đủ đối số

            - Tạo hàm nhập và hiển thị thông tin

        4. Thiết kế lớp Book gồm các thuộc tính : ngày book, ngày trả phòng, Số CMTND người book, mã khách sạn, mã phòng

            Chú ý : Số CMTND -> nếu chưa tồn tại -> nhập thông tin KH đó

            Mã khách sạn -> Nếu ko tồn tại, yêu cầu nhập đúng khách sạn đã có

            Mã Phòng -> yêu cầu nhập đúng mã phòng của KH mà người dùng muốn book -> Nếu nhập sai, yêu cầu nhập đúng mới dừng.

        Chú thích menu :

            Khi người dùng chọn 1 : Hỏi người dùng số khách sạn cần nhập => Khi nhập mỗi khách sạn thì yêu cầu

            - Nhập thông tin khách sạn đó

            - Hỏi người dùng nhập số phòng cần nhập cho khách sạn đó => Nhập thông tin từng phòng

            Khi người dùng chọn 2 : In toàn bộ thông tin liên quan tới KS

            Khi người dùng chọn 3 : Nhập thông tin đặt phòng (Book)

            Khi người dùng chọn 4: Nhập vào 1 ngày book và ngày trả phòng, in ra tất cả các phòng có thể đap ứng đc yêu cầu trên

            Khi người dùng chọn 5 : In ra tổng tiền mà mỗi khách sạn kiếm được ra màn hình.

            Khi người dùng chọn 6 : Nhập Số CMTND khách hàng => In ra tất cả các khách sạn mà khách hàng này đã tới.

            Khi người dùng chọn 7 : Thoát chương trình.

    */

    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Customer> customers = new List<Customer>();
            List<Hotel> hotels = new List<Hotel>();
            List<Book> books = new List<Book>();
             
            int choose;
            do {
                Menu();
                choose = int.Parse(Console.ReadLine());

                switch (choose) { 
                    case 1:
                        NhapHotel(hotels);  
                        break;
                    case 2:
                        HienThiHotel(hotels);
                        break;
                    case 3:
                        Booking(customers,hotels,books);
                        break;
                    case 4:
                        FindBookingAvaiable(hotels,books);
                        break;
                    case 5:
                        TongTien(hotels);
                        break;
                    case 6:
                        SeachKhachHang(customers, books, hotels);
                        break;
                    case 7:
                        Console.WriteLine("Thoát !!!");
                        break;
                    default: Console.WriteLine("Nhập Sai !!!");
                        break ;
                }
            }while (choose != 7);
        }
        #region 1. Nhập Thông Tin Hotel
            static void NhapHotel(List<Hotel> hotels)
            {

                for (; ; )
                {

                    Hotel hotel = new Hotel();
                    hotel.Nhap();
                    hotels.Add(hotel);

                    Console.WriteLine("Bạn có tiếp tục thêm khách sạn mới hay ko Y/N: ");
                    string option = Console.ReadLine();
                    if (option.ToUpper().Equals("N"))
                    {
                        break;
                    }
                }
            }
        #endregion

        #region 2. Hiển Thị Thông Tin Hotel
            static void HienThiHotel(List<Hotel> hotels)
            {
                foreach (Hotel hotel in hotels)
                {
                    hotel.HienThi();
                }
            }
        #endregion

        #region 3. Đặt Phòng 
            static void Booking(List<Customer> customers, List<Hotel> hotels, List<Book> books)
            {

                Book book = new Book();
                book.Nhap(customers, hotels);

                books.Add(book);
            }
        #endregion

        #region 4. Tìm Phòng trống
            static void FindBookingAvaiable(List<Hotel> hotels, List<Book> books)
            {
                if (hotels.Count == 0)
                {
                    Console.WriteLine("KO CÓ DỮ LIỆU !!!");
                    return;
                }

                Console.WriteLine("Nhập Mã Khách Sạn: ");
                Hotel currentHotel = null;
                for (; ; )
                {
                    foreach (Hotel hotel in hotels)
                    {
                        Console.WriteLine("============================================");
                        Console.WriteLine("Mã Khách Sạn: {0}, Tên Khách Sạn: {1}", hotel.HotelCode, hotel.Name);

                    }
                    string TimKS = Console.ReadLine();

                    //Sau khi Nhập xong dữ liệu chúng ta viết 1 hàm kiểm tra
                    foreach (Hotel hotel in hotels)
                    {
                        if (hotel.HotelCode.Equals(TimKS))
                        {
                            currentHotel = hotel;
                            break;
                        }
                    }
                    if (currentHotel != null)
                    {
                        break;
                    }
                    Console.Write("(Mã KS Not Found) Nhập lại: ");
                }
                if (hotels.Count == 0)
                {
                    Console.WriteLine("KO CÓ DỮ LIỆU !!!");
                    return;
                }

                Console.Write("Enter Ngay CheckIn (dd/mm/yyyy): ");
                string datetime = Console.ReadLine();
                DateTime CheckIn = DateTime.ParseExact(datetime, "dd/mm/yyyy", null); ;

                Console.Write("Enter Ngay CheckOut (dd/mm/yyyy): ");
                datetime = Console.ReadLine();
                DateTime CheckOut = DateTime.ParseExact(datetime, "dd/mm/yyyy", null);

                // tìm kiếm phòng trống có thể booking
                // Room => có thể booking phải thoả mãn điều kiện như sau :
                // VD Room R001 có người booking từ ngày day1 -> day2. điều kiện chúng ta có thể booking tiếp checkin > day1 và checkout < day01

                foreach (Room room in currentHotel.RoomList)
                {
                    // tạo 1 vòng lặp foreach với mục đích duyệt qua tất cả các phòng mà trong khách sạn (currentHotel) chúng ta muốn book
                    // => sau đó mới tìm ra tất cả danh sách book mà phòng chúng ta muốn đặt

                    List<Book> currentBooking = new List<Book>(); // tìm kiếm những dữ liệu mà những phòng (currentBooking)đã dc booking rồi
                    foreach (Book book in books)
                    {
                        if (book.HotelCodeBK.Equals(currentHotel.HotelCode) && book.RoomNoBK.Equals(room.RoomNo))
                        {
                            currentBooking.Add(book);
                        }
                    }

                    // Do chúng ta đã lấy dc data booking của các phòng vào trong thằng currentBooking nên tiếp theo
                    // Kiểm tra Phòng này có khả năng book hay ko
                    bool isFind = false; // nếu isFind = false thì chúng ta có thể booking
                    foreach (Book book in currentBooking)
                    {

                        if (DateTime.Compare(book.CheckIn, CheckOut) >0 || DateTime.Compare(book.CheckOut, CheckIn) <0)
                        {
                            //OK
                        }
                        else
                        {
                            Console.WriteLine("[ Xin Lỗi, Quý Khách hiện tại ngày quý khách chọn Không còn phòng trống. Xin hãy chọn ngày khác ( T T ) ]");
                            isFind = true;
                            break;
                        }
                    }
                    if (!isFind)
                    {
                        Console.WriteLine("==================[ Các Phòng Còn Trống ]========================");
                        Console.WriteLine("[ Mã Phòng: {0}| Tên Phòng: {1} ]",
                                room.RoomNo, room.RoomName);
                    }
                }
            }
        #endregion

        #region 5. Thống Kê Doanh Thu Hotel
            static void TongTien(List<Hotel> hotels)
            {
                foreach (Hotel hotel in hotels)
                {
                    float sum = 0;
                    foreach (Room room in hotel.RoomList)
                    {
                        sum += room.Price;
                    }
                    Console.WriteLine("Doanh Thu Dự Tính Thu dc của Khách sạn {0}: {1}", hotel.Name, sum);
                }
            }
        #endregion

        #region 6. Tìm Thông Tin Khách Hàng
            static void SeachKhachHang(List<Customer> customers, List<Book> books, List<Hotel> hotels)
            {

                Console.Write("Nhập CMND Khách Hàng Cần Tìm :");
                string str = Console.ReadLine();
                foreach (Customer khach in customers)
                {
                    if (str == khach.CMND)
                    {
                        Console.WriteLine("Khách Hàng : {0} Đã đặt phòng", khach.Fullname);
                    }
                    else
                    {
                        Console.WriteLine("Khong co du lieu khach hang");
                    }
                }

                foreach (Book book in books)
                {
                    if (str == book.CMNDBK)
                    {
                        foreach (Hotel hotel in hotels)
                        {
                            if (hotel.HotelCode == book.HotelCodeBK)
                            {
                                Console.WriteLine(" tại khách sạn : {0}", hotel.Name);
                            }
                        }
                    }
                }
            }
        #endregion


        static void Menu()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("1. Nhập Thông Tin Hotel: ");
            Console.WriteLine("2. Hiển Thị Thông Tin Hotel : ");
            Console.WriteLine("3. Đặt Phòng : ");
            Console.WriteLine("4. Tìm Phòng trống: ");
            Console.WriteLine("5. Thống Kê Doanh Thu Hotel: ");
            Console.WriteLine("6. Tìm Thông Tin Khách Hàng : ");
            Console.WriteLine("7. Thoát : ");
            Console.WriteLine("============================================");
            Console.Write("Chọn : ");

        }
    }
}
