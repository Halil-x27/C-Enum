using System;

namespace MyNamespace
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Gunler.pazar);
            Console.WriteLine((int)Gunler.cumartesi);

            int sıcaklık = 32;

            if (sıcaklık<=(int)HavaDurumu.normal)
            {
                Console.WriteLine("Dısarıya çıkmak için biraz daha bekleyelim");
            }
            else if (sıcaklık>=(int)HavaDurumu.sıcak)
            {
                Console.WriteLine("dısarıya çıkmak için sıcak bir gün");
            }else if (sıcaklık>=(int)HavaDurumu.normal && sıcaklık<(int)HavaDurumu.cokSıcak)
            {
                Console.WriteLine("dısarıya çıkmak için güzel bir gün");
            }
        }
    }

    enum Gunler
    {
        pazartesi,
        sali,
        carsamba,
        persembe,
        cuma,
        cumartesi,
        pazar
    }

    enum HavaDurumu
    {
        soguk = 5,

        normal = 20,

        sıcak = 25,

        cokSıcak = 30
    }
}