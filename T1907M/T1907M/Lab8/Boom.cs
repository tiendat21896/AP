using System;
using System.Threading;

namespace T1907M.Lab8
{
    public class Boom
    {
        public static void Main(string[] args)
        {
            int count1 = 9;
            int count2 = 59;
            for (int i = count1; i > 0; i--)
            {
                for (int j = count2; j >0; j--)
                {
                    Console.WriteLine(i + ":" + j);
                    Thread.Sleep(100);
                }
            }
            Console.WriteLine("BOOMMMMM!!!!!!!!!!!!!!!!!!!!");
        }
    }
}