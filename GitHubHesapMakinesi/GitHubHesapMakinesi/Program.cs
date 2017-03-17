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
            double sayi1, sayi2, sayi3, sonuc;
            int sayac = 0;
            sayi1 = 0;
            sayi2 = 0;
            sayi3 = 0;
            Console.WriteLine("*****Orhun'un Console Hesap Makinesine Hoşgeldiniz!*****\n");
            do
            {
                if (sayac == 0)
                {
                    Console.Write("Birinci sayıyı giriniz: ");
                    sayi1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("İkinci sayıyı giriniz: ");
                    sayi2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("- Yapmak İstediğiniz İşlemi Seçiniz -\n1 - Toplama\n2 - Çıkarma\n3 - Çarpma\n4 - Bölme\n");
                    Console.Write("Yapmak İstediğiniz İşlemin Başındaki Katsayıyı Giriniz: ");
                    sayi3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    
                   
                }
                else if (sayac>0)
                {
                    Console.Write("İkinci sayıyı giriniz: ");
                    sayi2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("- Yapmak İstediğiniz İşlemi Seçiniz -\n1 - Toplama\n2 - Çıkarma\n3 - Çarpma\n4 - Bölme\n");
                    Console.Write("Yapmak İstediğiniz İşlemin Başındaki Katsayıyı Giriniz: ");
                    sayi3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                }
                if (sayi3 == 1)
                {
                    Console.Clear();
                    sonuc = sayi1 + sayi2;
                    Console.Write("Sonuç: " + sonuc + "\n\n");
                    sayi1 = sonuc;
                    
                }
                else if (sayi3 == 2)
                {
                    Console.Clear();
                    sonuc = sayi1 - sayi2;
                    Console.Write("Sonuç: " + sonuc + "\n\n");
                    sayi1 = sonuc;
                    
                }
                else if (sayi3 == 3)
                {
                    Console.Clear();
                    sonuc = sayi2 * sayi1;
                    Console.Write("Sonuç: " + sonuc + "\n\n");
                    sayi1 = sonuc;
                }
                else if (sayi3 == 4)
                {
                    Console.Clear();
                    sonuc = sayi1 / sayi2;
                    Console.Write("Sonuç: " + (sayi1 / sayi2) + "\n\n");
                    sayi1 = sonuc;
                }
                else
                {
                    Console.Write("Lütfen Geçerli Bir İfade Giriniz!");   
                }
                sayac++;
            }
            while (sayi3 != 56);

            Console.ReadKey();
        }
    }
}
