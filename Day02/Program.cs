using System;

namespace Day02 {

    class Program {

        static void Main(string[] args) {

            int N, m;
            Console.WriteLine("Nhap So N = ");
            N = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                if (checkNum(i)) {
                    Console.WriteLine("{0}, ", i);
                }
            }


        }

        static bool  checkNum(int num) {
            // Neu num chia het cho 1 trong cac so chay tu 2 ==> num/2
            // num ko phai là số nguyên tô
            // num là số nguyên tố : khi no chia het cho 1 và chính num

            int max = num / 2;
            for (int i = 2; i <= max; i++) {
                if (num % i == 0) {
                    return false;
                }                               
            }
            return true;
        }
    }
}