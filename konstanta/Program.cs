using System;

namespace konstanta
{
    class Program
    {
        const string NamaSaya = "Aliefia";  //konstanta = sifatnya konstan atau tetap tidak dapat di ubah
        static void Main(string[] args)
        {
            Console.WriteLine(NamaSaya);    //menampilkan nilai atau isi dari konstanta NamaSaya

            NamaSaya = "fouris";            //akan error kalau kita coba rubah isinya

            Console.ReadKey();
        }
    }
}
