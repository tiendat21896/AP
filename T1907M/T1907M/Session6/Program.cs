using System;

namespace T1907M.Session6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TaxMoney tm = TaxCalc.GetTax("VN");
            float tax = tm(100000000);
            Console.WriteLine("Thue Phai Nop : "+tax);
            
            // Tao 1 Ham an danh bang delegate
            TaxMoney tm2 = delegate(float salary) { return salary * 40 / 100; } ;
            float frTax = tm2(10000);
            Console.WriteLine("Thue Tai Phap : "+frTax);
        }
    }
}