using System;

namespace tahmin_et
{
    class Program
    {
        static void Main(string[] args)
        {   Random randomSayi = new Random(); // rastgele sayiyi tanimlamak için kullanilan fonksiyon :)
            int rastegeleSayi = randomSayi.Next(1, 1000);// buradaki parametre rastgele gelecek olan sayinin 1 ile 1000 arasinda olmasını sağlar 
            Console.WriteLine("Sayiyi Tahmin Ediniz :");
            int tahmin = Convert.ToInt32(Console.ReadLine());
            int tahminSayaci = 1;
            while(rastegeleSayi != tahmin)
            {
                if (rastegeleSayi > tahmin)
                {
                    Console.WriteLine("tahmin ettiginiz sayidan büyüktür !");
                }
                else
                {
                    Console.WriteLine("tahmin ettiginiz sayidan küçüktür");
                }
                Console.WriteLine("Sayiyi tekrardan tahmin ediniz");
                tahmin = Convert.ToInt32(Console.ReadLine());
                tahminSayaci++;
            }
            Console.WriteLine("Tebrikler Sayiyi Doğru Tahmin ettiniz");
            Console.WriteLine("Sayiyi Tahmin edene kadar " + tahminSayaci + " kere denediniz ");

            Console.ReadLine();
        }
    }
}
