using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *         Thiết kế lớp book gồm các thuộc tín : Tên sách, ngày xuất bản, but danh
            - Cài đặt get/set cho các thuộc tỉnh, hàm tạo ko đối và đầy đủ tham số
*/
namespace Day09_BaiTap_QLSach.Models
{
    public class Book
    {
        public String BookName { get; set; }
        public int YearPublishing { get; set; }
        public String NickName { get; set; }

        public Book() { }

        public Book(string bookName, int yearPublishing, string nickName)
        {
            this.BookName = bookName;
            this.YearPublishing = yearPublishing;
            this.NickName = nickName;
        }

        public void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập Tên Sách: ");
            BookName = Console.ReadLine();

            Console.Write("Nhập Năm Xuất Bản: ");
            YearPublishing = Validate.ReadInt();

            Console.Write("Nhập Bút Danh: ");
            NickName = Console.ReadLine();
        }

        public void HienThi()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("[Tên Sách: {0}, Năm Xuất Bản: {1}, Bút Danh: {2} ]", BookName,YearPublishing,NickName);
        }
    }
}
