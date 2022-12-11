using System;

namespace odev_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // out parameter ;

            string sayi = "9999";
            bool sonuc =int.TryParse(sayi, out int outsayi);
            if(sonuc)
            {
                Console.WriteLine("Başarili !");
                Console.WriteLine(outsayi);
            }
            else
            {
                Console.WriteLine("Başarisiz");
            }
            Metotlar İnstance = new Metotlar();
            İnstance.Topla(4,5, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);
            // Over Loading
            int ifade =998;
            İnstance.ekranayaz(Convert.ToString(ifade));
            İnstance.ekranayaz(ifade);
            İnstance.ekranayaz("Ömür","Can");
            //metot imzaso
            // metotAdı +Parametre sayisi + parametre
            // bu koşullarda overloading olur
        }
    }
    class Metotlar
        {
            public void Topla(int a, int b , out int toplam)
            {
                toplam=a+b;
            } 

            public void ekranayaz(string veri)
            {
                Console.WriteLine(veri);
                                                    // hem string hem de int tipinde veri almış oldu
            }
            public void ekranayaz(int veri)
            {
                Console.WriteLine(veri);

            }
            public void ekranayaz(string veri1 , string veri2)
            {
                Console.WriteLine(veri1+veri2);

            }
        }
}

