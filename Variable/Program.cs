using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Siapa nama kamu : ");                //menampilkan text "Siapa nama kamu :"

            string inputNama = Console.ReadLine();              //input teks yang nantinya akan disimpan di variable inputNama

            Console.WriteLine("Nama kamu adalah " + inputNama); //menampilkan "Nama kamu adalah " ditambah teks isi dari variable inputNama

            Console.ReadKey();
        }
    }
}
