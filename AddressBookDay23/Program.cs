using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDay23
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program:");
            AddressBook ab = new AddressBook("Yuvraj", "Rai", "3006", "Noida", "UP", "uv@gmail.com", 201016, 8218501015);
            ab.DisplayContacts();

        }
    }
}