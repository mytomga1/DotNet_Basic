using System;

/* 
  Phần 2:
  _ Array trong C#
  _ Class Oject trong C#
    + Tạo
    + Getter/ Setter
    + Thuộc tính truy xuất
      . Private
      . Protected
      . Public
 _ Các tính chất trong lập trình OOP
    + Tính Chất Đóng gói (public, private, protected,....)
    + Tính Chất Kế thừa
        .Override : thêm một số thuộc tính vào phương thức dc kế thừa từ lớp cha
        .Overloading : trong 1 lớp đối tượng mà nó có nhiều phương thức giống nhau như khác về tham số đầu vào thì người ta sài thằng này
    + Tính Chất đa hình: có nghĩa là cùng 1 hành động nhưng ở những ngữ cảnh khác nhau thì cho ra những hàng động khác nhau, hoặc kết quả khác nhau
        VD: chúng ta tạo ra 1 phương thức cùng 1 hành động thanh toán Payment của ứng dụng.  
            ở những ngữ cảnh khác nhau thì cho ra những hàng động khác nhau khách hàng có thể hành động khác nhau như sử dụng thẻ visa hay mastercard
            Thì trả về kết quả khác nhau là nếu sử dụng thanh toán thẻ visa chúng ta sử dụng theo phương thức trả bằng thẻ visa và ngược lại.
        Khi trong 1 bài toán dc đưa ra 1 hành động nhưng mà đc thể hiện giải quyết bằng nhiều cách khác nhau khi to ta sài Tính Chất đa hình
         
    + Tính Chất trừu tượng : sử dụng key abstract cho thằng cha. 
        .vd trong thằng cha Peole có phương thức Running 
         2 thằng con student1 và 2 điều cũng có phương thức Running và ghi đè lại phương thức Running của thằng cha.
         vậy áp dụng Tính Chất đa hình ta có thể tạo phương thức gắn key abstract Running của thăng cha và để nó rổng. 
         2 thằng con kế thừa và ghi đè phương thức của thằng cha People mà vẫn có thể hoạt dộng theo cách 2 thằng con mong muốn.
        ==> từ đó phương thức Running của thằng cha trở nên đa hình theo cách của các thằng con mong  muốn.
*/

namespace Day04_OOP
{
    class Program{
        static void Main(string[] args)
        {
            testOOP();
        }

        static void testOOP() { 
            People people = new People();
            //people.Name = "Thao";

            //Console.Write("Enter Adress: ");
            //string ad = Console.ReadLine();
            //people.Address = ad;
            //Console.WriteLine("Address : {0}",people.Address);

            people.Nhap();
            people.Display();

            People people1 = new Student();
            people1.Running();
        }
    }
}
