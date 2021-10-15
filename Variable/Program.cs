using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Siapa nama kamu : ");
            string inputNama = Console.ReadLine(); //input
            Console.WriteLine("Nama kamu adalah " + inputNama); //output
            Console.ReadKey();
        }
    }
}
