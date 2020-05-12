using System;

namespace T1907M.Assignment5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();
            phoneBook.insertPhone("Dat","0998999999");
            phoneBook.insertPhone("Nam","0988888888");
            phoneBook.insertPhone("Viet","0911111111");
            phoneBook.removePhone("Viet"); 
            phoneBook.updatePhone("Dat","0989797979");
            phoneBook.insertPhone("Nam","0779999999");
            phoneBook.show();
            Console.WriteLine("Phone Search :");
            phoneBook.searchPhone("Dat");
        }
    }
}