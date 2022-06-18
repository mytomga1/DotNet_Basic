using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09_BaiTap_QLSach.Models
{
    public class Validate
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
                    Console.WriteLine("<< Nhập sai định dạng, yêu cầu nhập đúng định dạng >>");
                }
            }
        }
    }
}
