using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Day09_BaiTap_QLSach.Models;
/*
        * Xây dựng menu chương trình như sau.
        Menu:
        1. Nhập thông tin sách
        2. Hiển thị tất cả sách ra màn hình
        3. Nhập thông tin tác giả
        4. Tìm kiếm tất cả sách được viết bởi tác giả
        5. Tìm kiếm sách
        Choose: ???
    Yêu cầu :
    Thiết kế lớp đối tượng tác giả gồm các thuộc tỉnh sau (Tên, tuổi, bút danh, ngày sinh, quê quán)
    - Chú ý : cài đặt tất cả các thuộc tỉnh chỉ có thuộc tính đọc dữ liệu
    - Tạo các hàm tạo ko đối và đầy đủ đối số
    - Tạo phương thức nhập thông tin tác giả, và xem thông tin tác giả
    - Chú ý : Mỗi tác giả có bút danh duy nhất, ko được phép nhập trùng lặp tên bút danh của tác giả
    Thiết kế lớp book gồm các thuộc tín : Tên sách, ngày xuất bản, but danh
    - Cài đặt get/set cho các thuộc tỉnh, hàm tạo ko đối và đầy đủ tham số
    - Tạo hàm nhập và xem thông tin tác giả
    - Chú ý : Khi nhập tên bút danh của tác giả, nếu chưa tồn tại thì -- Xuất hiện màn hình nhập thông tin cho tácgiả đó luôn.

    * Xây dựng từng chức năng chương trình
        Khi người dùng chọn 1 . Hỏi người dùng nhập số sách cần thêm - sau đó nhập thông tin cho từng quyển sách → và lưa vào 1 list..
        Khi người dùng chọn 2 : In tất cả thông tin quyển sách
        Khi người dùng chọn 3 : Hỏi người dùng nhập số tác giả > Nhập thông tin tác giả.
        Khi người dùng chọn 4 : Hiển thị màn hình nhập bút danh cần tìm - in ra quyển sách của tác giả đó
        Khi người dùng chọn 5 : Thoát chương trình.
*/
namespace Day09_BaiTap_QLSach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            List<Author> authorList = new List<Author>();
            List<Book> bookList = new List<Book>();

            
            int choose;
            do {
                Menu();
                choose = Validate.ReadInt();
                switch (choose) { 
                
                    case 1:
                        AddNewBook(bookList, authorList);
                        break;
                    case 2:
                        HienThiDSBook(bookList);
                        break;
                    case 3:
                        AddNewAuthor(authorList);
                        break;
                    case 4:
                        HienThiDSAuthor(authorList);
                        break;
                    case 5:
                        SearchBookByNickName(bookList);
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Nhập Sai Rồi !!!");
                        break;
                }         
            }while (choose != 6);
        }

        #region 1. Nhập thông tin sách
        private static void AddNewBook(List<Book> bookList, List<Author> authorList)
        {

            Console.Write("Bạn Muốn Nhập Bao Nhiêu Quyển sách: ");
            int N = Validate.ReadInt();

            Console.WriteLine("=========[Add New Book]===============");
            for (int i = 0; i < N; i++)
            {

                Book book = new Book();
                book.Nhap();
                bookList.Add(book);

                // Kiểm tra xem nick name đã tồn tại hay chưa, nếu chưa thì bắt người dùng nhập thông tin tác giả cho quyển sách
                if (!CheckExitNickName(authorList,book.NickName)) {

                    Author author = new Author(book.NickName);
                    author.NhapWithoutNickName();
                    authorList.Add(author);
                }

                Console.WriteLine("Add New Book Complete");
            }
            Console.WriteLine("=================================");
        }
        #endregion

        #region 2. Hiển thị tất cả sách ra màn hình
        private static void HienThiDSBook(List<Book> bookList)
        {
            if (bookList.Count == 0) {

                Console.WriteLine("KO CÓ DỮ LIỆU !!");
            }
            Console.WriteLine("=============[DS Sách]====================");
            for (int i = 0; i < bookList.Count; i++)
            {

                bookList[i].HienThi();
            }
        }
        #endregion

        #region 3. Nhập thông tin tác giả
        private static void AddNewAuthor(List<Author> authorList)
        {

            Console.Write("Bạn Muốn Tạo Mới Bao Nhiêu Tác Giả: ");
            int N = Validate.ReadInt();

            for (int i = 0; i < N; i++)
            {

                Author author = new Author();
                author.Nhap(authorList); // đẩy ds authorList qua bên hàm Nhap() của class Author với mục đích check trùng lặp bút danh 
                authorList.Add(author);

                Console.WriteLine("Add New Author Complete");
            }
        }
        #endregion

        #region 4. Hiển thị DanhSach Tác Giả
        private static void HienThiDSAuthor(List<Author> authorList)
        {
            if (authorList.Count == 0)
            {

                Console.WriteLine("KO CÓ DỮ LIỆU !!");
            }
            Console.WriteLine("=============[DS Tác Giả]====================");
            for (int i = 0; i < authorList.Count; i++)
            {

                authorList[i].HienThi();
            }
        }
        #endregion

        #region 5. Tìm kiếm tất cả sách được viết bởi tác giả 
        private static void SearchBookByNickName(List<Book> bookList)
        {
            Console.Write("Nhập bút danh tác giả các quyển sách bạn cần tìm: ");
            string findNickName = Console.ReadLine();
            Console.WriteLine("=============[Sách của {0}]====================",findNickName);
            for (int i = 0; i < bookList.Count; i++)
            {
                if (bookList[i].NickName.Equals(findNickName)) {

                    bookList[i].HienThi();
                }
            }
        }
        #endregion

        #region Hàm Check NickName
        static bool CheckExitNickName(List<Author> authorList, string nickname)
        {

            for (int i = 0; i < authorList.Count; i++)
            {

                if (authorList[i].NickName.Equals(nickname))
                {

                    return true; // return về vòng while(true) nhảy lỗi bắt nhập lại
                }
            }
            return false;
        }
        #endregion

        static void Menu()
        {
            Console.WriteLine("=============[QLSách]====================");
            Console.WriteLine("1. Nhập thông tin sách");
            Console.WriteLine("2. Hiển thị Tất Cả sách");
            Console.WriteLine("3. Nhập thông tin tác giả");
            Console.WriteLine("4. Hiển Thị Danh Sách Tác Giả");
            Console.WriteLine("5. Tìm kiếm tất cả sách được viết bởi tác giả");
            Console.WriteLine("6. Thoát");
            Console.WriteLine("============================================");
            Console.Write("Chọn : ");

        }
    }
}
