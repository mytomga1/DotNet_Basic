using System;

namespace Day01 {

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int x = 5;
            int y = x++;// gáng y = 5 trước, sau đó tăng x = 6
            int z = ++x;//tăng x = 7 trước ,sau đó gáng z = 7
            Console.WriteLine("x = {0}, y = {1}, t = {2}", x, y, z);
            // x = 7, y =5, z = 7

            int t = x++ + ++x - --y + z++ + 1;
            //  t = 7(x=8) + (x=9)9 - (y=4)4 + 7(z=8) +1
            // cách thức tính thằng t
            //  t =   7    +   9    -   4    +  7     +1

            Console.WriteLine("x = {0}, y = {1}, z = {2}, t = {3}", x, y, z, t);
            // x = 9, y = 4, z = 8, t = 20

            int k = 10;
            string str = (k != 10) ? ("K khác 10") : ("K = 10 ");
            Console.WriteLine(str);
        }
    }
}
