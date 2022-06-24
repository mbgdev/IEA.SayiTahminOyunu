
/*Kodlar .net6 ortamında yazılmıştır*/

using System;
namespace IEA.SayiTahminOyunu
{
    public class Program
    {
      public static  int sayac=0;
   
        static void Main(string[] args)
        {
            
            Random rnd = new Random();
            int oyunDegeri = rnd.Next(1, 120);
            Console.WriteLine($"Test amaçlı random degeri konulmuştur {oyunDegeri}");
            string deger= degerAlma();
            tipSorgulama(deger);
            int sayi = Convert.ToInt32(deger);
            
            sayi=aralikSorgulama(sayi);

            int oyunSonuc=sonuc(sayi,oyunDegeri);
            Console.WriteLine($"Tebrikler Bildiniz {oyunSonuc} Sonuca {sayac} denemede bildiniz Dev:Mustafa Burak Gürener ");

            Console.WriteLine("Tekrar oynamak için herhangi bir  tuşa basınız");

            string devam = Console.ReadLine();
            if((String.IsNullOrEmpty(devam)))
            {
                Main(args);
            }

            Console.ReadKey();
        }



        static string degerAlma()
        {
            Console.Write("1-120 arasında bir değer giriniz: ");
            string deger = Console.ReadLine();
            sayac++;
            return deger;
        }

        static string tipSorgulama(string deger)
        {
            int sayi;
            bool sonuc = Int32.TryParse(deger, out sayi);
            while (sonuc == false)
            {
                Console.Write("Lütfen numerik bir değer giriniz: ");
                deger = Console.ReadLine();
                sayac++;
                sonuc = Int32.TryParse(deger, out sayi);
            }

            return deger;
        }


        static int aralikSorgulama(int sayi)
        {
            if (0 < sayi && sayi < 121)
                return sayi;
            else
            {
                Console.Write("Lütfen 1-120 arasında bir değer giriniz: ");
               string deger = Console.ReadLine();
                sayac++;
                string sonuc =tipSorgulama(deger);

                int yeniSayi = Convert.ToInt32(sonuc);
                  return aralikSorgulama(yeniSayi);
                


                
            }
        }


        static int sonuc(int sayi, int rnd)
        {
            if(sayi<rnd)
            {
                Console.Write("Yukarı: ");
                
                string deger =Console.ReadLine();
                sayac++;
                string tipSonuc = tipSorgulama(deger);
                int yeniSayi = Convert.ToInt32(tipSonuc);
                int aralik= aralikSorgulama(yeniSayi);
                return sonuc(aralik, rnd);

            }
            else if(sayi>rnd)
            {
                Console.Write("Aşağı: ");

                string deger = Console.ReadLine();
                sayac++;
                string tipSonuc = tipSorgulama(deger);
                int yeniSayi = Convert.ToInt32(tipSonuc);
                int aralik = aralikSorgulama(yeniSayi);
                return sonuc(aralik, rnd);
            }
            else
            return sayi;



        }








    }
}
