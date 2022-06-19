using System;
using System.Collections.Generic; // Để Quản Lý dc n Book ta dùng thằng List của (System.Collections.Generic)
/* 
 _ Cài Đặt lớp Book gồm các Thuộc tín :
    + private String bookName;
    + private String bookAuthor;
    + private String producer;
    + private String year;
    + private float price;

 _ Cài dăt 2 constructor, các phương thức set/get cho các thuộc tín của lớp.
 _ Cài Đặt hàm nhập, hiển thị cho các property của class(lớp).
 _ Cài đặt class AptechBook kế thừa lớp Book và bổ sung thêm thuộc tính:
    + private String language;
    + private Int semester;

 _ Cài đặt 2 constructor trong đó sử dụng super để gọi đến constructor của lớp cha.
 _ Cài đặt các metho set/get cho các thuộc tính bổ sung
 _ Override các phương thức nhập và hiển thị của class cha Book

 _ Cài đặt lớp Test trong đó tạo menu và thực hiện theo các chức năng sau :
    1. Nhập thông tin n cuốn sách của Aptech
    2. Hiện Thị Thông tin vừa nhập.
    3. Sắp xếp thông tin giảm dần theo năm sản xuất và hiển thị
    4. Tìm Kiếm Theo tên sách
    5. Tìm theo tên tác giả
    6. Thoát
*/

namespace BaiTap_QuanLyBook
{
    // Cài đặt lớp Test
    public class Test
    {
        static void Main(string[] args)
        {
            //Book book = new Book();
            //book.Nhap();
            //book.HienThi();

            List<AptechBook> aptechbook = new List<AptechBook>();
            int choose;

            do
            {
                ShowMenu();
                choose = checknumber.ReadInt();

                switch (choose)
                {
                    case 1:
                        Input(aptechbook);
                        break;

                    case 2:
                        Display(aptechbook);
                        break;

                    case 3:
                        Sort(aptechbook);
                        break;

                    case 4:
                        TimKiemByName(aptechbook);
                        break;

                    case 5:
                        TimKiemByTacGia(aptechbook);
                        break;

                    case 6:
                        Console.WriteLine("See you again :))");
                        break;

                    default:
                        Console.WriteLine("Nhap Sai");
                        break;
                }
            } while (choose !=6);
        }

        private static void TimKiemByName(List<AptechBook> aptechbook)
        {
            //Console.WriteLine("Nhap Ten sach can Tim: ");
            //string timtheoten = Console.ReadLine();

            //for (int i = 0; i < aptechBooks.Count; i++)
            //{

            //    if (aptechBooks[i].Name.Equals(timtheoten))
            //    {

            //        aptechBooks[i].HienThi();
            //    }
            //}
        }

        static void Input(List<AptechBook> aptechBooks) {
            Console.WriteLine("Nhap so Sach Can Them: ");
            int N = checknumber.ReadInt();

            for (int i = 0; i < N; i++) {
                // Cần đặt thằng AptechBook bên trong vong for
                // bởi vì mỗi lần khởi tạo khạo ko gian dữ liệu mới cho AptechBook
                AptechBook book = new AptechBook(); 
                book.Nhap();
                aptechBooks.Add(book);
            }
        }
        static void Display(List<AptechBook> aptechBooks) {

            for (int i = 0; i < aptechBooks.Count; i++) { 
            
                aptechBooks[i].HienThi();
            }
        }
        static void Sort(List<AptechBook> aptechBooks   ) {

            aptechBooks.Sort((AptechBook or1, AptechBook or2) => {
                return string.Compare(or1.Year, or2.Year);
            });
            Display(aptechBooks);
        }

        static void TimKiemByTacGia(List<AptechBook> aptechBooks) {

            Console.WriteLine("Nhap Ten Author can Tim: ");
            string timtheoAuthor = Console.ReadLine();

            for (int i = 0; i < aptechBooks.Count; i++)
            {

                if (aptechBooks[i].Author.Equals(timtheoAuthor))
                {

                    aptechBooks[i].HienThi();
                }
            }
        }

        static void ShowMenu() {

            Console.WriteLine("--------- [ Books ] ---------");
            Console.Write("1. Enter Info Book: ");
            Console.WriteLine(" ");
            Console.Write("2. Display the information you just entered: ");
            Console.WriteLine(" ");
            Console.Write("3. Sort information descending by year of manufacture and display: ");
            Console.WriteLine(" ");
            Console.Write("4. Search by Name");
            Console.WriteLine(" ");
            Console.Write("5. Search by Author");
            Console.WriteLine(" ");
            Console.Write("6. Exit");
            Console.WriteLine(" ");
            Console.WriteLine("-----------------------------");
            Console.WriteLine(" ");
            Console.Write(" Choose: ");
        }
    }
       
}