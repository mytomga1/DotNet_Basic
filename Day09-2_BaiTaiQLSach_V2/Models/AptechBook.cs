using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

/*
    Cài đặt lớp AptechBook kế thừa lớp Book và bổ sung thêm vào thuộc tính:

    private String language;

    private int semester;
 

    Cài đặt 2 constructor trong đó sử dụng super để gọi đến constructor của lớp cha.

    Cài đặt các phương thức get/set cho các thuộc tính bổ sung

    Override các phương thức input() và display()
*/

namespace Day09_2_BaiTaiQLSach_V2.Models
{
    [Serializable]
    public class AptechBook:Book 
    {
        private String language;
        public String Language { get { return language; } set { language = value; } }

        private int semester;
        public int Semester { get { return semester; } set { semester = value; } }

        public AptechBook() : base() { }

        //public AptechBook(string bookName, string bookAuthor, string producer, int yearPublishing, float price, string language, int semester):base(bookName,bookAuthor,producer,yearPublishing,price) 
        //{
        //    this.Language = language;
        //    this.Semester = semester;
        //}

        public override void Nhap() {
            
            base.Nhap();

            Console.Write("Nhập Ngôn Ngữ: ");
            Language = Console.ReadLine();

            Console.Write("Kỳ Mấy: ");
            Semester = CheckValidate.ReadInt();
        }

        public override void HienThi() {
            base.HienThi();

            Console.WriteLine(" Ngôn ngữ: {0}, kỳ: {1} ]", Language, Semester);
        }
    }
}
