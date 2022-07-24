using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilimi Gelishtirici Yetishdirme Kampi";
            string kurs2 = "Programlamaya bashlangic icin temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            string[] kurslar = new string[] { "Yazilimi Gelishtirici Yetishdirme Kampi" , "Programlamaya bashlangic icin temel kurs" , "Java" , "Python" , "C#"};

            
            for (int i = 0; i < kurslar.Length ; i++ )
            {
                Console.WriteLine(kurslar[i]);
            }
                
            Console.WriteLine("For bitti");
 
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayifa sonu - footer");
        }
    }
}
