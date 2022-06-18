using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09_BaiTap_QLSach.Models
{
    /*
        * Thiết kế lớp đối tượng tác giả gồm các thuộc tỉnh sau (Tên, tuổi, bút danh, ngày sinh, quê quán)
        - Chú ý : cài đặt tất cả các thuộc tỉnh chỉ có thuộc tính đọc dữ liệu
        - Tạo các hàm tạo ko đối và đầy đủ đối số
        - Tạo phương thức nhập thông tin tác giả, và xem thông tin tác giả
        - Chú ý : Mỗi tác giả có bút danh duy nhất, ko được phép nhập trùng lặp tên bút danh của tác giả
    */
    public class Author
    {
        public string Name { get; private set; }
        public string BirthDate { get; private set; }
        public string NickName { get; private set; }
        public string Address { get; private set; }

        public Author() { }

        public Author(string nickName) { // Mục Đích hàm này lấy dữ liệu bút danh đã check ko tồn tại khi tạo mới quyển sách và sử dụng bút danh này cho hàm nhập ko cần nhập bút danh
            
            this.NickName = nickName; 
        }

        public Author(string name, string birthDate, string nickName, string address)
        {
            this.Name = name;
            this.BirthDate = birthDate;
            this.NickName = nickName;
            this.Address = address;
        }

        #region Nhập Thông Tin Tác Giả
        public void Nhap(List<Author> authorList)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("=========[Add New Author]===============");
            Console.Write("Nhập Tên Tác Giả : ");
            Name = Console.ReadLine();

            Console.Write("Nhập Ngày Sinh : ");
            BirthDate = Console.ReadLine();

            Console.Write("Nhập Bút Danh : ");

            while (true)
            {
                NickName = Console.ReadLine();

                if (CheckExitNickName(authorList, NickName))
                {

                    Console.Write("Bút Danh {0} Đã Tồn Tại, Yêu Cầu Nhập Bút Danh Khác: ", NickName);

                }
                else
                {

                    break;
                }
            }

            Console.Write("Nhập Quê Quán : ");
            Address = Console.ReadLine();
        }
        #endregion

        #region Nhập Thông Tin Tác Giả Trong Trường Hợp Thằng Book tìm ko thấy Tác giả bắt nhập mới Tác giả cho quyển sách
        public void NhapWithoutNickName()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("=========[Add New Author]===============");
            Console.Write("Nhập Tên Tác Giả : ");
            Name = Console.ReadLine();

            Console.Write("Nhập Ngày Sinh : ");
            BirthDate = Console.ReadLine();

            Console.Write("Nhập Quê Quán : ");
            Address = Console.ReadLine();
        }
        #endregion

        #region Hàm Check Bút Danh
        private bool CheckExitNickName(List<Author> authorList, string nickname)
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

        #region Hiển Thị DS Tác Giả
        public void HienThi()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("[ Tên Tác Giả: {0}, Ngày Sinh: {1}, Bút Danh: {2}, Quê Quán: {3} ]",
                                 Name, BirthDate, NickName, Address);
        }
        #endregion
    }
}
