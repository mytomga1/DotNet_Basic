using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Day09_2_BaiTaiQLSach_V2.Models;
using System.IO;

/*
   * Cài đặt lớp Book gồm các thuộc tính:

        private String bookName;

        private String bookAuthor;

        private String producer;

        private int yearPublishing;

        private float price;
 

        Cài đặt 2 constructors, các phương thức set/get cho các thuộc tính của lớp.

        Cài đặt 2 phương thức input() và display để nhập và hiển thị các thuộc tính của lớp.
 

   * Cài đặt lớp AptechBook kế thừa lớp Book và bổ sung thêm vào thuộc tính:

        private String language;

        private int semester;
 

        Cài đặt 2 constructor trong đó sử dụng super để gọi đến constructor của lớp cha.

        Cài đặt các phương thức get/set cho các thuộc tính bổ sung

        Override các phương thức input() và display().
 

   * Cài đặt lớp Test trong đó tạo menu và thực hiện theo các chức năng của menu:
        1.    Nhập thông tin cuốn sách của Aptech
        2.    Hiển thị thông tin vừa nhập
        3.    Sắp xếp thông tin giảm dần theo năm xuất bản và hiển thị
        4.    Tìm kiếm theo tên sách
        5.    Tìm kiếm theo tên tác giả
        6.    Lưu thông tin sách đã nhập vào file
        7.    Đọc nội dung từ file và lưu vào mang quản lý sách
        8.    Thoát.
*/

namespace Day09_2_BaiTaiQLSach_V2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            List<AptechBook> aptechBKlist = new List<AptechBook>();

            int choose;
            do
            {
                Menu();
                choose = CheckValidate.ReadInt();
                switch (choose)
                {

                    case 1:
                        NhapInfoBook(aptechBKlist);
                        break;
                    case 2:
                        ShowDSBook(aptechBKlist);
                        break;
                    case 3:
                        SortByYear(aptechBKlist);
                        break;
                    case 4:
                        FindByName(aptechBKlist);
                        break;
                    case 5:
                        FindByAuthor(aptechBKlist);
                        break;
                    case 6:
                        SaveFile(aptechBKlist);
                        break;
                    case 7:
                        OpenFile();
                        break;
                    case 8:

                        break;
                    default:
                        Console.WriteLine("Nhập Sai Rồi !!!");
                        break;
                }
            } while (choose != 8);

        }

        #region 1. Nhập thông tin sách của Aptech
        private static void NhapInfoBook(List<AptechBook> aptechBKlist)
        {
            Console.WriteLine("=============[Add New Book]===============");
            Console.Write("Bạn Muốn Nhập Mấy Cuốn Sách : ");
            int N = CheckValidate.ReadInt();
            for (int i = 0; i < N; i++)
            {

                AptechBook aptechBook = new AptechBook();
                aptechBook.Nhap();
                aptechBKlist.Add(aptechBook);
            }
        }
        #endregion

        #region 2. Hiển thị Tất Cả sách
        private static void ShowDSBook(List<AptechBook> aptechBKlist)
        {
            if (aptechBKlist.Count == 0)
            {

                Console.WriteLine("Chưa có dữ liệu !!!");
            }
            else
            {

                for (int i = 0; i < aptechBKlist.Count; i++)
                {

                    aptechBKlist[i].HienThi();
                }
            }
        }
        #endregion

        #region 3. Sắp xếp thông tin giảm dần theo năm xuất bản và hiển thị
        private static void SortByYear(List<AptechBook> aptechBKlist)
        {
            //aptechBKlist.Sort((o1, o2) =>
            //{
            //    return -o1.YearPublishing.CompareTo(o2.YearPublishing);
            //});

            aptechBKlist.Sort((x, y) => y.YearPublishing.CompareTo(x.YearPublishing));

            for (int i = 0; i < aptechBKlist.Count; i++)
            {
                aptechBKlist[i].HienThi();
            }
        }
        #endregion

        #region 4. Tìm kiếm theo tên sách
        private static void FindByName(List<AptechBook> aptechBKlist)
        {

            if (aptechBKlist.Count == 0)
            {

                Console.WriteLine("Chưa có dữ liệu !!!");
            }
            else
            {
                Console.Write("Nhập Tên Quyển Sách Cần Tìm: ");
                string fname = Console.ReadLine();

                for (int i = 0; i < aptechBKlist.Count; i++)
                {
                    if (aptechBKlist[i].BookName.Equals(fname))
                    {
                        aptechBKlist[i].HienThi();
                    }
                    else
                    {
                        Console.WriteLine("Không Tìm Thấy Thông Tin Quyển Sách");
                    }
                }
            }
        }
        #endregion

        #region 5. Tìm kiếm theo tên tác giả
        private static void FindByAuthor(List<AptechBook> aptechBKlist)
        {
            if (aptechBKlist.Count == 0)
            {

                Console.WriteLine("Chưa có dữ liệu !!!");
            }
            else
            {
                Console.Write("Nhập Tên Tác giả Quyển Sách Cần Tìm: ");
                string fname = Console.ReadLine();

                for (int i = 0; i < aptechBKlist.Count; i++)
                {
                    if (aptechBKlist[i].BookAuthor.Equals(fname))
                    {
                        aptechBKlist[i].HienThi();
                    }
                    else
                    {
                        Console.WriteLine("Không Tìm Thấy Thông Tin Quyển Sách");
                    }
                }
            }
        }
        #endregion

        #region 6. Lưu thông tin sách đã nhập vào file
        private static void SaveFile(List<AptechBook> aptechBKlist)
        {
            bool append = false;
            using (Stream stream = File.Open(@"Book.txt", append ? FileMode.Append : FileMode.Create))
            {
                var format1 = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                format1.Serialize(stream, aptechBKlist);
                Console.WriteLine("Save Success");
            }
        }
        #endregion

        #region 7. Đọc nội dung từ file và lưu vào mang quản lý sách
        private static void OpenFile()
        {
            List<AptechBook> aptechBKlist = new List<AptechBook>();
            using (Stream filepath1 = File.Open(@"Book.txt", FileMode.Open))
            {
                var format = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                aptechBKlist = (List<AptechBook>)format.Deserialize(filepath1);
            }
            ShowDSBook(aptechBKlist);
        }
        #endregion

        static void Menu() {
            Console.WriteLine("=============[QLSách]====================");
            Console.WriteLine("1. Nhập thông tin sách của Aptech");
            Console.WriteLine("2. Hiển thị Tất Cả sách");
            Console.WriteLine("3. Sắp xếp thông tin giảm dần theo năm xuất bản và hiển thị");
            Console.WriteLine("4. Tìm kiếm theo tên sách");
            Console.WriteLine("5. Tìm kiếm theo tên tác giả");
            Console.WriteLine("6. Lưu thông tin sách đã nhập vào file");
            Console.WriteLine("7. Đọc nội dung từ file và lưu vào mang quản lý sách");
            Console.WriteLine("8. Thoát");
            Console.WriteLine("============================================");
            Console.Write("Chọn : ");
        }
    }
}