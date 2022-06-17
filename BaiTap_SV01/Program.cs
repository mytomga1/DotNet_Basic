using System;

namespace BaiTapSV1
{
    /* 
     _ Cài Đặt lớp StudentMark gồm các thông tin sau : Rollnumber, Tên, Môn, Điểm
     _ Tạo 2 constructor, các phương thức set/get
     _ Cài Đặt hàm nhập, hiển thị
     _ khai báo luôn hàm main trong lớp này :
     _ Khai báo 2 đối tượng bằng constructor(Hàm Nhap & HienThi) ko tham số. Gọi hàm Nhập
       vào các thông tin và hàm hiển thị để hiện thị các thông tin.
     _ So sanh điểm số SV
    */

    class StudentMark
    {
        public string Rollno { get; set; }
        public string Fullname { get; set; }
        public string Subject { get; set; }
        public float Mark { get; set; }
        public StudentMark() { }
        public StudentMark(string rollno, string fullname, string subject, float mark)
        {

            this.Rollno = rollno;
            this.Fullname = fullname;
            this.Subject = subject;
            this.Mark = mark;
        }

        public void Nhap()
        {

            Console.WriteLine("Enter rollno :");
            Rollno = Console.ReadLine();

            Console.WriteLine("Enter Fullname :");
            Fullname = Console.ReadLine();

            Console.WriteLine("Enter subject :");
            Subject = Console.ReadLine();

            Console.WriteLine("Enter Mark :");
            Mark = float.Parse(Console.ReadLine());
        }

        public void HienThi()
        {

            Console.WriteLine("Thong Tin Sinh Vien = " +
                               "Rollno: {0}, Fullname: {1}, Subject: {2}, Mark: {3}",
                               Rollno, Fullname, Subject, Mark);
        }

        static void Main(string[] args)
        {
            StudentMark studentMark1 = new StudentMark();
            StudentMark studentMark2 = new StudentMark();

            studentMark1.Nhap();
            studentMark2.Nhap();

            studentMark1.HienThi();
            studentMark2.HienThi();

            // so sanh diểm 2 sv

            if (studentMark1.Mark > studentMark2.Mark)
            {
                Console.WriteLine("SV 1 mark cao hon SV2");
            }
            else if (studentMark1.Mark.Equals(studentMark2.Mark))
            {
                Console.WriteLine("2 SV = nhau");
            }
            else Console.WriteLine("SV 2 mark cao hon SV1");

        }
    }
}