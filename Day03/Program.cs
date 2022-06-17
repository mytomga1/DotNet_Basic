using System;

namespace Day01
{
    /* 
      Phần 1:
      _ Array trong C#
      _ Class Oject trong C#
        + Tạo
        + Getter/ Setter
        + Thuộc tính truy xuất
          . Private
          . Protected
          . Public
       
    */
    class Program
    {
        static void Main(string[] args)
        {
            // mãng gồm 10 số nguyên 
            int[] t = new int[9];
            // cách gắn giá trị vào mãng
            t[0] = 11;
            t[1] = 12;
            t[2] = 21;

            
            Console.WriteLine("Nhap N: ")
            N = int.Parse(Console.ReadLine())
            int[] r = new int[N];
            for (int index = 0; index < r.Length; index++) { 
            
                Console.WriteLine("Nhap phan tu k{0} = ", index);
                r[index] = int.Parse(Console.ReadLine());
            }
        }
    }
}