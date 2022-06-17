using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_QuanLyBook
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Producer { get; set; }
        public string Year { get; set; }
        public float Price { get; set; }

        public Book() { }

        public Book(string name, string author, string producer, string year, float price) { 
            
            this.Name = name;
            this.Author = author;
            this.Producer = producer;
            this.Year = year;
            this.Price = price;
        }

        public virtual void Nhap() {

            Console.Write("Enter Name Book: ");
            Name = Console.ReadLine();
            Console.WriteLine(" ");

            Console.Write("Enter Author: ");
            Author = Console.ReadLine();
            Console.WriteLine(" ");

            Console.Write("Enter Producer: ");
            Producer = Console.ReadLine();
            Console.WriteLine(" ");

            Console.Write("Enter Year: ");
            Year = Console.ReadLine();
            Console.WriteLine(" ");

            Console.Write("Enter Price: ");
            Price = float.Parse(Console.ReadLine());
            Console.WriteLine(" ");
        }

        public virtual void HienThi() {

            //Cách Hiển Thị Thứ 1
            //Console.WriteLine("Sach [ Name: {0}, Author: {1}, Producer: {2}, Year: {3}, Price: {4} ]",
            //    Name,Author,Producer,Year,Price);

            //Cách Hiện thị thứ 2
            Console.WriteLine("----- Info Book -----");
            Console.Write("Name: " + Name);
            Console.WriteLine(" ");
            Console.Write("Author: " + Author);
            Console.WriteLine(" ");
            Console.Write("Producer: " + Producer);
            Console.WriteLine(" ");
            Console.Write("Year: " + Year);
            Console.WriteLine(" ");
            Console.Write("Price: " + Price);
            Console.WriteLine(" ");
            Console.WriteLine("-----------------------");
        }

    }
}
