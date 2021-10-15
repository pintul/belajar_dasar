using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstanta
{
    class Program
    {
        const string NamaSaya = "Aliefia"; //konstanta = sifat nya konstan atau tetap tidak dapat di ubah
        static void Main(string[] args)
        {
            Console.WriteLine(NamaSaya);
            NamaSaya = "fouris"; //akan error kalau kita coba rubah isinya
            Console.ReadKey();
        }
    }
}
