using System;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıya seçenekleri sun
        Console.WriteLine("Proje haftasına hoş geldiniz! Bu projede sizlerden 3 aşamalı bir uygulama geliştirmeniz isteniyor.");
        Console.WriteLine("Hangi programı çalıştırmak istersiniz - 3 farklı seçenek :");
        Console.WriteLine("1 - Rastgele Sayı Bulma Oyunu");
        Console.WriteLine("2 - Hesap Makinesi");
        Console.WriteLine("3 - Ortalama Hesaplama");

        // Kullanıcıdan seçim yapmasını iste
        Console.Write("Seçiminizi yapınız (1, 2 veya 3): ");
        int secim = int.Parse(Console.ReadLine());

        // Seçime göre ilgili programı çalıştır
        switch (secim)
        {
            case 1:
                RastgeleSayiBulmaOyunu();
                break;
            case 2:
                HesapMakinesi();
                break;
            case 3:
                OrtalamaHesaplama();
                break;
            default:
                Console.WriteLine("Geçersiz seçim. Lütfen 1, 2 veya 3 seçiniz.");
                break;
        }
    }

    static void RastgeleSayiBulmaOyunu()
    {
        Random random = new Random();
        int rastgeleSayi = random.Next(1, 101);
        int tahmin;
        int can = 5;
        Console.WriteLine("1 ile 100 arasında bir sayı tahmin ediniz. 5 tahmin hakkınız var:");

        while (can > 0)
        {
            Console.Write("Tahmininiz: ");
            tahmin = int.Parse(Console.ReadLine());
            can--;

            if (tahmin < rastgeleSayi)
            {
                Console.WriteLine("Daha yüksek bir sayı tahmin ediniz.");
                Console.WriteLine("Kalan tahmin hakkınız: " + can);
            }
            else if (tahmin > rastgeleSayi)
            {
                Console.WriteLine("Daha düşük bir sayı tahmin ediniz.");
                Console.WriteLine("Kalan tahmin hakkınız: " + can);
            }
            else
            {
                Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");
                return;
            }

            if (can == 0)
            {
                Console.WriteLine("Tahmin hakkınız doldu. Doğru sayı: " + rastgeleSayi);
            }
        }
    }

    static void HesapMakinesi()
    {
        Console.Write("İlk sayıyı giriniz: ");
        double sayi1 = double.Parse(Console.ReadLine());
        Console.Write("İkinci sayıyı giriniz: ");
        double sayi2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Yapmak istediğiniz işlemi seçiniz (+, -, *, /): ");
        char islem = Console.ReadLine()[0];

        double sonuc = 0;

        switch (islem)
        {
            case '+':
                sonuc = sayi1 + sayi2;
                break;
            case '-':
                sonuc = sayi1 - sayi2;
                break;
            case '*':
                sonuc = sayi1 * sayi2;
                break;
            case '/':
                if (sayi2 != 0)
                {
                    sonuc = sayi1 / sayi2;
                }
                else
                {
                    Console.WriteLine("Bir sayıyı 0'a bölemezsiniz.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Geçersiz işlem.");
                return;
        }

        Console.WriteLine("Sonuç: " + sonuc);

    }

    static void OrtalamaHesaplama()
    {
        // Kullanıcıdan ders notlarını al
        Console.Write("Birinci ders notunu giriniz: ");
        double not1 = double.Parse(Console.ReadLine());
        Console.Write("İkinci ders notunu giriniz: ");
        double not2 = double.Parse(Console.ReadLine());
        Console.Write("Üçüncü ders notunu giriniz: ");
        double not3 = double.Parse(Console.ReadLine());

        // Notların geçerliliğini kontrol et
        if (not1 < 0 || not1 > 100 || not2 < 0 || not2 > 100 || not3 < 0 || not3 > 100)
        {
            Console.WriteLine("Geçersiz not girdiniz. Notlar 0-100 aralığında olmalıdır.");
            return;
        }

        // Notların ortalamasını hesapla
        double ortalama = (not1 + not2 + not3) / 3;
        Console.WriteLine("Ortalamanız: " + ortalama);

        // Ortalama notun harf karşılığını göster
        string harfNotu;

        if (ortalama >= 90)
            harfNotu = "AA";
        else if (ortalama >= 85)
            harfNotu = "BA";
        else if (ortalama >= 80)
            harfNotu = "BB";
        else if (ortalama >= 75)
            harfNotu = "CB";
        else if (ortalama >= 70)
            harfNotu = "CC";
        else if (ortalama >= 65)
            harfNotu = "DC";
        else if (ortalama >= 60)
            harfNotu = "DD";
        else if (ortalama >= 55)
            harfNotu = "FD";
        else
            harfNotu = "FF";

        Console.WriteLine("Harf notunuz: " + harfNotu);
    }
}