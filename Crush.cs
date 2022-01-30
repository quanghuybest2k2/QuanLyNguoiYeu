using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNguoiYeu
{
    class Crush:ICrush
    {
        string ClassName;
        public string Class
        {
            get
            {
                return ClassName;
            }

            set
            {
                ClassName = value;
            }
        }

        DateTime dateofBirth;
        public DateTime DateofBirth
        {
            get
            {
                return dateofBirth;
            }

            set
            {
                dateofBirth = value;
            }
        }

        string fullName;
        public string FullName
        {
            get
            {
                return fullName;
            }

            set
            {
                fullName = value;
            }
        }

        int id;
        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        int mobile;
        public int Mobile
        {
            get
            {
                return mobile;
            }

            set
            {
                mobile = value;
            }
        }

        string native;
        public string Native
        {
            get
            {
                return native;
            }

            set
            {
                native = value;
            }
        }

        public void Display()
        {
            Console.WriteLine("Họ và tên: " + FullName);
            Console.WriteLine("Ngày sinh: " + DateofBirth.ToString("dd/MM/yyyy"));
            Console.WriteLine("Quê quán: " + Native);
            Console.WriteLine("Lớp: " + Class);
            Console.WriteLine("Số điện thoại : " + Mobile);
        }
    }
}
