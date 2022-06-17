using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day07_BaiTap_QLSinhVien_Import.Export_JSON.Models
{
    /*
        2. Tạo 1 lớp đối tượng Phòng Học (ClassRoom) gồm các thuộc tính : Name,Address, và mãng danh sách sinh viên (list<Student>studentList)
           _ Tạo hàm ko đối số 
           _ Tạo hàm getter & setter
           _ Tạo hàm nhập thông tin và hiển thị thông tin sinh vien
    */
    public class ClassRoom
    {
        public string ClassRoomName { get; set; }
        public string Address { get; set; }
        public List<Student> studentList { get; set; }

        public ClassRoom() { 
        
            studentList = new List<Student>();
        }

        public void Nhap()
        {

            Console.Write("Nhập Tên Lớp : ");
            ClassRoomName = Console.ReadLine();

            Console.Write("Nhập Địa Chỉ : ");
            Address = Console.ReadLine();

            Console.Write("Nhập Số Sinh Viên : ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) { 
            
                Student sv = new Student();
                sv.Nhap(); // phần này dùng để gọi nhập dữ liệu sv

                studentList.Add(sv);// sau đó lưu sv vào mãng studentList
            }
        }

        public void HienThi()
        {
            Console.WriteLine("[ Tên Lớp :{0}| Địa Chỉ:{1}]",
                                ClassRoomName, Address);
            foreach (Student sv in studentList) {

                sv.HienThi();
            }
        }
    }
}
