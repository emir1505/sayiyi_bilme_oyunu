using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();

        while (true)
        {
            int sayi = rnd.Next(1, 101); 
            int tahmin;
            int denemeSayisi = 0;

            Console.Clear();
            Console.WriteLine("=== SAYI TAHMİN OYUNU ===");
            Console.WriteLine("Aklimdan 1 ile 100 arasinda bir sayi tuttum. Bakalım kac adimda bulabileceksiniz!");

            do
            {
                Console.Write("Tahmininizi buraya giriniz: ");
                string girdi = Console.ReadLine();

                if (!int.TryParse(girdi, out tahmin))
                {
                    Console.WriteLine("Lutfen gecerli bir sayi giriniz.");
                    continue;
                }

                denemeSayisi++;

                if (tahmin < sayi)
                {
                    Console.WriteLine("CİK!");
                }
                else if (tahmin > sayi)
                {
                    Console.WriteLine("İN!");
                }
                else
                {
                    Console.WriteLine($"Tebrik Ederim! {denemeSayisi} denemede dogru sayiyi buldunuz.");
                }

            } while (tahmin != sayi);

            Console.Write("Oyunu tekrar oynamak ister misiniz? (E/H): ");
            string cevap = Console.ReadLine().ToUpper();
            if (cevap != "E")
                break;
        }
    }
}
