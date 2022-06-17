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

            TestArray02();
        }
        static void TestArray01() {

            // mãng gồm 10 số nguyên 
            int[] t = new int[9];
            // cách gắn giá trị vào mãng
            t[0] = 11;
            t[1] = 12;
            t[2] = 21;


            Console.Write("Nhap N: ");
            int N = Int32.Parse(Console.ReadLine());
            int[] r = new int[N];
            for (int index = 0; index < r.Length; index++)
            {

                Console.Write("Nhap elememt cho array k[] = ", index);
                r[index] = Int32.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                if (r[i] % 2 == 0)
                {
                    sum += r[i];
                }
            }

            Console.Write("Mãng r []: ");
            for (int index = 0; index < r.Length; index++)
            {
                Console.Write(" {0},", r[index]);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Tong các phan tu so chan trong mang r[] : {0}", sum);
        }

        static void TestArray02() {
            
            // Quản lý dữ liệu trong 1 mảng động

            List<int> list = new List<int>();
            Console.WriteLine("Length: {0}", list.Count);

            // cách thứ thêm element vào mảng động list[]
            list.Add(11);
            list.Add(12);
            list.Add(32);

            int l = list[1];
            Console.WriteLine("list[1] = {0}",l);


            Console.Write("list[] = ");
            for (int i = 0; i < list.Count; i++) { 
                
                Console.Write(" {0},", list[i]);
            }
        }
    }
}