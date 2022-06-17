using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_OOP
{
    public class Student : People{

        
        public override void Running()
        {
            Console.WriteLine("");
            Console.Write("day la lop con student su dung phuong thuc override trong ke thua tu lop cha people");
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            base.Running();            
            Console.WriteLine("student is running Too");
        }
    }
}
