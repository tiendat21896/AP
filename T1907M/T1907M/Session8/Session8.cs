using System;
using System.Threading;

namespace T1907M.Session8
{
    public class Session8
    {
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(ThreadRun);
            t1.Start();// Chay luong moi
            
            Thread t2 = new Thread(new Session8().Run2);
            t2.Start();
            
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Main i = "+i);
                Thread.Sleep(100);
            }
        }

        public static void ThreadRun(object o)
        {
            string msg = (string) o;//Down casting
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("i = "+i);
                Thread.Sleep(100);
            }
        }

        public void Run2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Xin Chao i ="+i);
                Thread.Sleep(100);
            }
        }
        
    }
}