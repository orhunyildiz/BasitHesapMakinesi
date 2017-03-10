using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubHesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2, sayi3;
            Console.WriteLine("*****Orhun'un Console Hesap Makinesine Hoşgeldiniz!*****\n");
            do
            {
                Console.Write("Birinci sayıyı giriniz: ");
                sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("İkinci sayıyı giriniz: ");
                sayi2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("- Yapmak İstediğiniz İşlemi Seçiniz -\n1 - Toplama\n2 - Çıkarma\n3 - Çarpma\n4 - Bölme\n");
                Console.Write("Yapmak İstediğiniz İşlemin Başındaki Katsayıyı Giriniz: ");
                sayi3 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();
                if (sayi3 == 1)
                {
                    Console.Write("Sonuç: " + (sayi1 + sayi2) + "\n\n");
                }
                else if (sayi3 == 2)
                {
                    Console.Write("Sonuç: " + (sayi1 - sayi2) + "\n\n");
                }
                else if (sayi3 == 3)
                {
                    Console.Write("Sonuç: " + (sayi1 * sayi2) + "\n\n");
                }
                else if (sayi3 == 4)
                {
                    Console.Write("Sonuç: " + (sayi1 / sayi2) + "\n\n");
                }
                else
                {
                    Console.Write("Lütfen Geçerli Bir İfade Giriniz!");
                }
            }
            while (sayi3 != 56);

            Console.ReadKey();
        }
    }
}
