using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_BaiTap_QLSinhVien_CSDL.Utils
{
    public class Utility
    {   
        // Tạo 1 Hàm bắt lỗi Nhập số
        public static int ReadInt() {
            Console.OutputEncoding = Encoding.UTF8;

            int value;
            while (true) {

                try{

                    value = Convert.ToInt32(Console.ReadLine());
                    return value;
                }catch (Exception)
                { 
                    Console.WriteLine("Nhập Lại");
                }
            }
        }
    }
}
