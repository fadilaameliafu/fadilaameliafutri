using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masukn_jumlahangka
{
    class Program
    {
        static void Main(string[] args)
        {
            //DESKRIPSI
            int a, bil;
            string genap, ganjil;
            //CODING
            Console.WriteLine(“=============================================”);
            Console.Write(“Masukan jumlah Angka               :  “);
            bil = Convert.ToInt16(Console.ReadLine());
            genap = “”;
            ganjil = “”;
            Console.WriteLine();
            for (a = 1; a <= bil; a++)
            {
                if (a % 2 == 0)
                    genap = genap + a + ” “;
                else
                    ganjil = ganjil + a + ” “;
            }
            Console.WriteLine(“Bilangan Genap  = ” + genap);
            Console.WriteLine(“Bilangan Ganjil =  ” + ganjil);
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}