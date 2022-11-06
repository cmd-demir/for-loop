internal class Program
{
    private static void Main(string[] args)
    {
        //Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
        Console.WriteLine("Lütfen bir sayı giriniz");
        int sayac = int.Parse(Console.ReadLine());

        for (int i = 1; i < sayac; i++)
        {
            if(i%2 == 1)
            Console.WriteLine(i);
        }
        //1 ile 100 arasındaki tek ve çift sayıların kendi aralarında toplamı
        int tektoplam = 0;
        int cifttoplam = 0;
        for (int i = 1; i < 1000; i++)
        {
            if(i%2 == 1)
            tektoplam += i; //tektoplam = tektoplam + i
            else
            cifttoplam += i; //cifttoplam = cifttoplam + i

        }
            Console.WriteLine("Tek Toplam:" + tektoplam);
            Console.WriteLine("Çift Toplam:" + cifttoplam);

            //break, continue

            for (int i = 0; i < 10; i++)
            {
                if(i==4)
                    break;
                    Console.WriteLine(i);
            }
            for (int i = 0; i < 10; i++)
            {
                if(i==4)
                    continue;
                    Console.WriteLine(i);
            }

    }
}