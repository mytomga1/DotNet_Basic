using System;

namespace Day02
{
    class Program
    {
        static void Main(string[] args)
        {

            int N;
            Console.WriteLine("Nhap So N = ");
            N = Int32.Parse(Console.ReadLine());

            // tạo 1 mãng t
            int[] t = new int[N];
            Console.WriteLine("Nhap element cho mãng t");
            for (int i = 0; i < N; i++) { 
                
                Console.WriteLine("Nhap t[{0}] = ", i);
                t[i] = Int32.Parse(Console.ReadLine());
            }

            //Sắp xếp dữ liệu, số chẳn nằm phía bên phải, lẻ bên trái.
            // t = {1, 5, 2, 7, 6, 9}
            // tạo 1 var: currentindex -> trỏ tới vị trí index cuối cùng số chẳn trong mãng.
            // currentindex = -1
            // i = 2, t[i] = 2 -> so chan ->chuyen t[i] = 2 đến sau vi trí của currentindex -> update currentindex mới

            int currentIndex = -1;
            for (int i = 0; i < N; i++) {
                if (t[i]%2==0) { 
                    
                    currentIndex++;
                    int tmp = t[i];
                    t[i] = t[currentIndex];
                    t[currentIndex] = tmp;
                }  
            }

            Console.WriteLine("ket qua xap sep mang t");
            for (int i = 0; i < N; i++)
            {

                Console.Write("{0}, ",t[i]);
            }
        }

    }
}