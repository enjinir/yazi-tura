using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazı_tura
{
    class Program
    {
        static void Main(string[] args)
        {
            int yazi = 0;
            int tura = 0;
            
            char check=' ';
            Random rnd = new Random();
            while (check != 'x')
            {
                Console.WriteLine("Lutfen Kac Karsilastirilma Yapilmasini Istediginizi Girin: ");
                int karsilastirma;

                if (!Int32.TryParse(Console.ReadLine(), out karsilastirma))
                {
                    Console.WriteLine("Lutfen Tam Sayi Girin");
                    Console.WriteLine("Cikmak Icin X'e , Yeniden Sayi Girmek Icin Icin Herhangi Bir Tusa Basin");
                    ConsoleKeyInfo key0 = Console.ReadKey(true);
                    check = key0.KeyChar;
                    continue;
                }
                Console.WriteLine("İslem Yapilirken Lutfen Bekleyiniz...");
                for (int i = 0; i < karsilastirma; i++)
                {


                    
                    int sayi = rnd.Next(0, 2);
                    if (sayi == 0)
                        yazi++;
                    else if (sayi == 1)
                        tura++;


                }
                if (tura > yazi)
                    Console.WriteLine("Sonuc: Tura");
                else if (tura < yazi)
                    Console.WriteLine("Sonuc: Yazi");
                else
                    Console.WriteLine("Sonuc: Esit");



                double yuzde;
                double fark;
                fark = Math.Abs(yazi - tura);
                yuzde = fark / (Convert.ToDouble(karsilastirma)/100);


                Console.WriteLine("Yazi: {0} Tura: {1} Fark: {2} Fark Yuzdesi: % {3} Karsilastirma Sayisi: {4} ", yazi, tura, fark, yuzde, karsilastirma);
                yazi = 0; tura = 0;
                Console.WriteLine("Cikmak Icin X'e , Yeniden Atmak Icin Herhangi Bir Tusa Basin");
                ConsoleKeyInfo key =  Console.ReadKey(true);
                check = key.KeyChar;
            }
        }
    }
}
