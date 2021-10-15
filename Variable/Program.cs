using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            //string nama;
            Console.Write("Siapa nama kamu : ");
            string inputNama = Console.ReadLine(); //input
            Console.WriteLine("Nama kamu : " + inputNama); //output
            Console.ReadKey();
        }
    }
}
