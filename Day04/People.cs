using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_OOP
{
    public  class People {
        // mục đích tạo getter/ setter
        // Tạo method cho getter/ setter => public cho các thuộc tính nhứ Name, GioiTinh, ...... 
        public string Name { get; set; }
        public string GioiTinh { get; set; }
        
        // set điều kiện cho address giới hạn từ 5 - 10 từ
        private string _address;
        public string Address {
            get { return _address; }
            set {
                if (value.Length > 5 && value.Length < 10)
                {
                    this._address = value;
                } else Console.WriteLine("Address Toi Thieu 5 chu tro len & ko dc qua 10 tu !");
            }
        }
        public string Birthday { get; set; }

        public People() {             
            
        }

        public virtual void Running()
        {

            Console.WriteLine("People is running");
        }

        //public abstract void Running();

        public void Nhap() {

            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Gioi Tinh: ");
            GioiTinh = Console.ReadLine();

            Console.Write("Enter Adress: ");
            Address = Console.ReadLine();

            Console.Write("Enter Birthday: ");
            Birthday = Console.ReadLine();
        }

        public void Display() {

            Console.WriteLine("people => name: {0}, gioi tinh: {1}, address: {2}, birthday: {3} ", 
                                     Name,GioiTinh,Address,Birthday);
            Console.WriteLine("");
        }

    }
}
