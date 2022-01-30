using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNguoiYeu
{
    class Program
    {
        static Dictionary<int, Crush> listDictionary = new Dictionary<int, Crush>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            while (true)
            {
                Console.WriteLine("+--------------------------------------------+");
                Console.WriteLine("|============ Quản lý Crush ==================");
                Console.WriteLine("+--------------------------------------------+");
                Console.WriteLine("|1. Thêm Crush mới");
                Console.WriteLine("|2. Xem Crush");
                Console.WriteLine("|3. Tìm Crush");
                Console.WriteLine("|4. Thoát");
                Console.WriteLine("+--------------------------------------------+");
                Console.Write("Mời bạn chọn chức năng --> ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        InsertCrush();
                        break;
                    case 2:
                        ViewList();
                        break;
                    case 3:
                        Search();
                        break;
                    case 4:
                        Console.WriteLine("Chương trình đã thoát!!!");
                        return;
                }
                Console.WriteLine("+-------------------------------------------+");
                Console.Write("Nhấn 1 phím bất kỳ để tiếp tục!");
                Console.ReadLine();
                Console.Clear();
            }
        }

        private static void Search()
        {
            bool found = false;
            Console.Write("Thêm lớp: ");
            String search = Console.ReadLine();
            Console.WriteLine("Tất cả Crush của lớp " + search);
            foreach (Crush crush in listDictionary.Values)
            {
                if (crush.Class.Equals(search))
                //if (String.Compare(Crush.Class, search, true) == 0)
                {
                    Console.WriteLine("----------------------------");
                    crush.Display();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("không có Crush nào được tìm thấy!");
            }
        }

        private static void ViewList()
        {
            foreach (Crush i in listDictionary.Values)
            {
                Console.WriteLine("----------------------------");
                i.Display();
            }
        }

        private static void InsertCrush()
        {
            Crush crush = new Crush();

            //Increament ID
            crush.ID = listDictionary.Count + 1;

            //Input name
            Console.Write("Nhập họ và tên: ");
            crush.FullName = Console.ReadLine();

            //Input date
            while (true)
            {
                Console.Write("Nhập ngày sinh (tùy format máy): ");
                DateTime dDate;
                try
                {
                    crush.DateofBirth = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Không đúng format hàm date!");
                    Console.WriteLine(ex.Message);
                }
            }

            //Input Native
            Console.Write("Nhập quê quán: ");
            crush.Native = Console.ReadLine();

            //Input Class
            Console.Write("Nhập lớp: ");
            crush.Class = Console.ReadLine();

            //Input Mobile
            while (true)
            {
                Console.Write("Nhập số điện thoại di động: ");
                try
                {
                    crush.Mobile = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Số điện thoại không đúng định dạng!");
                    Console.WriteLine(ex.Message);
                }
            }

            listDictionary.Add(crush.ID, crush);
            Console.WriteLine("+-------------------------------------------+");
            Console.WriteLine("Thêm Crush thành công!");
        }
    }
}
