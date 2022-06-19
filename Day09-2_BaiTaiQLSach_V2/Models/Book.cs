using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

/*
   
    Cài đặt lớp Book gồm các thuộc tính:

    private String bookName;

    private String bookAuthor;

    private String producer;

    private int yearPublishing;

    private float price;
 

    Cài đặt 2 constructors, các phương thức set/get cho các thuộc tính của lớp.

    Cài đặt 2 phương thức input() và display để nhập và hiển thị các thuộc tính của lớp.
 
*/


namespace Day09_2_BaiTaiQLSach_V2.Models
{
    [Serializable]
    public abstract class Book
    {
        private String bookName;
        public String BookName { get { return bookName; } set { bookName = value; } }

        private String bookAuthor;
        public String BookAuthor { get { return bookAuthor; } set { bookAuthor = value; } }

        private String producer;
        public String Producer { get { return producer; } set { producer = value; } }

        private int yearPublishing;
        public int YearPublishing { get { return yearPublishing; } set { yearPublishing = value; } }

        private float price;
        public float Price { get { return price; } set { price = value; } } 

        public Book() { }

        public Book(string bookName, string bookAuthor, string producer, int yearPublishing, float price)
        {
            this.BookName = bookName;
            this.BookAuthor = bookAuthor;
            this.Producer = producer;
            this.YearPublishing = yearPublishing;
            this.Price = price;
        }

        public virtual void Nhap()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Cuốn Sách Tên Gì: ");
            BookName = Console.ReadLine();

            Console.Write("Cuốn Sách của tác giả: ");
            BookAuthor = Console.ReadLine();

            Console.Write("Nhập tên Nhà Xuất Bản: ");
            Producer = Console.ReadLine();

            Console.Write("Năm Phát Hành Sách: ");
            YearPublishing = CheckValidate.ReadInt();

            Console.Write("Giá Tiền: ");
            Price = CheckValidate.ReadInt();

        }

        public virtual void HienThi() { 
        
            Console.Write("[ Tên Sách: {0}, Tác giả: {1}, Nhà xuất bản: {2}, Năm xuất bản: {3}, Giá: {4},",
                                 BookName,BookAuthor,Producer,YearPublishing,Price);
        }
    }
}
