using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_QuanLyBook
{
    // class AptechBook con kế thừa class Cha Book
    public class AptechBook:Book {
    
        public string Language { get; set; }
        public string Semester { get; set; }

        public AptechBook() { }
        public AptechBook(string name, string author, string producer, string year, float price, string language, string semester) : 
                     base(name, author, producer, year, price) { 
                   //Khai báo :base để có thể truyền dc các thông số đến lớp Cha để tự sử dụng
           
            this.Language = language;
            this.Semester = semester;
        }

        //_ Sử dụng Override thêm các proprety cho phương thức nhập và hiển thị của class cha Book
        public override void Nhap()
        {
            //Sử dụng base để kế thừa metho Nhap() của thằng cha
            base.Nhap();

            Console.Write("Enter Language Book: ");
            Language = Console.ReadLine();
            Console.WriteLine(" ");

            Console.Write("Enter ky hoc: ");
            Semester = Console.ReadLine();
            Console.WriteLine(" ");
        }

        //_ Sử dụng Override thêm các proprety Language + Semester cho phương thức hiển thị của class cha Book
        public override void HienThi()
        {
            //Sử dụng base để kế thừa metho HienThi() của thằng cha
            base.HienThi();

            //Cách Hiện thị thứ 1
            Console.WriteLine("Language: " + Language);
            Console.WriteLine("Semester: " + Semester);
            Console.WriteLine("----- End Book -----");

            //Cách Hiện thị thứ 2
            //Console.WriteLine("sach [ name: {0}, author: {1}, producer: {2}, year: {3}, price: {4}, Language: {5}, Semester: {6} ]",
            //                   Name,Author,Producer,Year,Price,Language,Semester);
        }
    }
}
