using System;

namespace T1907M.Lab6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculator: ");
            Console.WriteLine("Cong, Tru, Nhan, Chia");
            string choose;
            int a, b;
            Console.WriteLine("Nhap vao chuc nang: ");
            choose = Console.ReadLine();
            Console.WriteLine("Nhap a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());
            CalNumber cm = Calculator.Result(choose);
            if (choose =="Cong")
            {
                int addNumber = cm(a,b);
                Console.WriteLine("Tong= "+addNumber);
            } else if (choose =="Tru")
            {
                int subNumber = cm(a,b);
                Console.WriteLine("Hieu= "+subNumber);
            } else if (choose =="Nhan")
            {
                int MulNumber = cm(a,b);
                Console.WriteLine("Tich= "+MulNumber);
            }
            else
            {
                int divNumber = cm(a,b);
                Console.WriteLine("Thuong= "+divNumber);
            }
        }
    }
}