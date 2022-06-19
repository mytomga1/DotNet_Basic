using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_QuanLyBook
{
    internal class checknumber
    {
        public static int ReadInt()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int value;

            while (true)
            {

                try
                {
                    value = Convert.ToInt32(Console.ReadLine());
                    return value;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("<< Nhập Sai Định Dạng Kiễu Dữ Liệu, yêu cầu nhập Lại >>");
                }
            }

        }
    }
}
