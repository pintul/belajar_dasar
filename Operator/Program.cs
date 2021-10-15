using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Operator Penugasan (=)
            //  Digunakan untuk memberikan nilai kedalam variable atau konstanta
            //  misalnya :

            int umur = 7;                                                   //artinya variable umur kita beri nilai 7
            
            Console.WriteLine("Nilai dari variable umur adalah " + umur);   //menampilkan nilai dari variable umur
            
            //============================================================================================================
            
            //2.Operator Aritmatika
            //  Digunakan untuk operasi perhitungan
            //  misalnya :

            int a = 20 + 50;                                                //artinya variable a kita beri nilai 20 + 50 = 70
            Console.WriteLine("Nilai dari variable a adalah " + a);         //menampilkan nilai dari variable a

            int b = 50 - 20;                                                //artinya variable b kita beri nilai 50 - 20 = 30. dst
            Console.WriteLine("Nilai dari variable b adalah " + b);         //menampilkan nilai dari variable b

            //============================================================================================================

            //3.Operator Pembanding
            //  Digunakan untuk memberikan nilai dengan tipe data boolean yang isinya cuma True(benar) atau False(salah)
            //  ------------------------------------
            //  Operator    Operasi
            //  ------------------------------------
            //     <        Lebih kecil dari
            //     >        Lebih besar dari
            //    <=        Kurang dari sama dengan
            //    >=        Lebih  dari sama dengan
            //    ==        Sama dengan
            //    !=        Tidak sama dengan
            //  ------------------------------------
            //  misalnya :

            bool lima_lebih_kecil_dari_enam = 5 < 6;    //akan menampilkan True(benar)
            bool lima_lebih_besar_dari_enam = 5 > 6;    //akan menampilkan False(salah)
            bool lima_sama_dengan_lima = 5 == 5;        //akan menampilkan True(benar)
            bool lima_sama_dengan_enam = 5 == 6;        //akan menampilkan False(salah)

            Console.WriteLine("5 < 6 adalah "  + lima_lebih_kecil_dari_enam);
            Console.WriteLine("5 > 6 adalah "  + lima_lebih_besar_dari_enam);
            Console.WriteLine("5 == 5 adalah " + lima_sama_dengan_lima);
            Console.WriteLine("5 == 6 adalah " + lima_sama_dengan_enam);

            // bedanya operator '=' dengan operator '==' adalah
            // '=' digunakan untuk memberikan nilai ke sebuah variable atau konstanta
            // '==' digunakan untuk membandingkan nilai atau isi variable yang satu dengan lainnya
            Console.ReadKey();
        }
    }
}
