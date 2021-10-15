using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string namaSaya = "Aliefia";    //tipe data string atau teks(menampilkan text tidak bisa diproses aritmatika)
            int umurSaya = 7;               //tipe data integer atau bilangan bulat(bisa diproses aritmatika)
            bool sayaTua = umurSaya > 40;   //tipe data boolean atau logika isinya cuma true(benar) atau false(salah)

            Console.WriteLine(namaSaya);    //menampilkan nilai atau isi dari variable namaSaya
            Console.WriteLine(umurSaya);    //menampilkan nilai atau isi dari variable umurSaya
            Console.WriteLine(sayaTua);     //menampilkan 'True' jika umurSaya lebih besar dari 40 dan 'False' jika umurSaya lebih kecil dari 40
            Console.ReadKey();
        }
    }
}
