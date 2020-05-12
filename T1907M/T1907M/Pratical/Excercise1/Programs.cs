using System;

namespace PraticalC.Excercise1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double radius, height;
            Cylinder cl = new Cylinder();
            Console.WriteLine("Enter radius");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height");
            height = Convert.ToDouble(Console.ReadLine());
            cl.Process(radius,height);
            cl.Result();
            
        }
    }
}