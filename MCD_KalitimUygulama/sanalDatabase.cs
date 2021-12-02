using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KalitimUygulama
{
    public static class sanalDatabase
    {
        public static ArrayList db = new ArrayList();
        public static void yeniUrunEkle(baseClass data)
        {
            if (data!=null && !string .IsNullOrEmpty (data.barkod ))
            {
                db.Add(data);
            }
        }

        public static bool dbBarkodkontrol(string dbbarkod)
        {
            bool kontrolIslemi = false;

            if (db!= null && db.Count >0)
            {
                for (int i = 0; i < db.Count ; i++)
                {
                    baseClass bc = (baseClass )db[i];

                    if (bc.barkod ==dbbarkod )
                    {
                        kontrolIslemi = true;
                    }
                }
            }
            return kontrolIslemi;
        }

        public static void yazdir()
        {
            foreach (bilgisayar item in sanalDatabase.db)
            {
                Console.WriteLine("Marka: " + item.marka + " model: " + item.model + " işlemci: " + item.islemci + " alış fiyatı: " + item.alisFiyat + " satış fiyatı: " + item.satisFiyat + " kampanya fiyatı: " + item.kampanyaFiyat + " barkod: " + item.barkod);
            }
        }
            
}
}
