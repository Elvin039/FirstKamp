using System;

namespace FirstKamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kagoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirishYapmishMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalish buttonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artish buttonu");
            }
            else
            {
                Console.WriteLine("Eshitdir buttonu");
            }

            if (sistemeGirishYapmishMi == true)
            {
                Console.WriteLine("Kullanici ayarlari buttonu");
            }
            else
            {
                Console.WriteLine("Girish yap buttonu");
            }
            Console.WriteLine(kagoriEtiketi);
            


        }
    }
}
