using System;
using System.Threading;

namespace T1907M.Assignment6
{
    public class Fibonaci
    {
        public static void Main(string[] args)
        {
            string str;
            int fb1, fb2, fb3;
            Console.WriteLine();
            int n = Convert.ToInt32(Console.ReadLine());
            fb1 = 0;
            fb2 = 1;
            fb3 = 1;
            do
            {
                fb1 = fb2 + fb3;
                fb3 = fb2;
                fb2 = fb1;
                Console.WriteLine("\n" +fb2);
                Thread.Sleep(100);
            } while (fb2 + fb3 < n);


        }
    }
}