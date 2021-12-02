using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KalitimUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            bilgisayar B1 = new bilgisayar();
            // B1.id = 1; Girmek istemiyorum uygulamanın bana bu alanı set edilebilir şekilde bırakmasını da istemiyorum.
            B1.marka = "Lenova";
            B1.model = "z50";
            B1.islemci = "i5";
            B1.alisFiyat = 1000;
            B1.satisFiyat = 1500;
            B1.kampanyaFiyat = 1000;
            B1.barkod = "1234567890";

            sanalDatabase.yeniUrunEkle(B1);

            bilgisayar B2 = new bilgisayar();
            // B1.id = 1; Girmek istemiyorum uygulamanın bana bu alanı set edilebilir şekilde bırakmasını da istemiyorum.
            B2.marka = "Excalıbur";
            B2.model = "g770";
            B2.islemci = "i5";
            B2.alisFiyat = 2000;
            B2.satisFiyat = 2500;
            B2.kampanyaFiyat = 2000;
            B2.barkod = "1234567891";
             
            sanalDatabase.yeniUrunEkle(B2);

            sanalDatabase.yazdir();


            Console.ReadKey();

        }
    }
}
