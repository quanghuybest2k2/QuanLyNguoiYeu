using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNguoiYeu
{
    interface ICrush
    {
        int ID
        {
            get;
            set;
        }

        string FullName
        {
            get;
            set;
        }

        DateTime DateofBirth
        {
            get;
            set;
        }

        string Native
        {
            get;
            set;
        }

        string Class
        {
            get;
            set;
        }

        int Mobile
        {
            get;
            set;
        }

        void Display();
    }
}
