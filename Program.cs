using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        // Fibonacci();      // *** Kolay Seviye Projeler - Ortalama Hesaplama  *** Kulanıcıdan alınan derinliğe göre fibonacci
                             // serisindeki rakamların ortalamasını alıp ekrana yazdıran uygulamayı yazınız.

        //Triangle();        // *** Kolay Seviye Projeler - Ortalama Hesaplama
                             // Kullanıcıdan alınan boyut bilgisine göre console'a Üçgen çizen uygulamayı yazınız.

        // Circle();         // Kullanıcıdan alınan yarıçapa göre console'a Daire çizen uygulama 

        Algoritma();        //Ekrandan bir string bir de sayı alan (aralarında virgül ile), ilgili string
                            //ifade içerisinden verilen indexteki karakteri çıkartıp ekrana yazdıran console uygulasını yazınız.

    }

    public static void Fibonacci()   // Ortalama Hesaplama
    {
        Console.Write("Fibonacci seriniz kaç rakamdan oluşsun?");
        float derinlik = int.Parse(Console.ReadLine());

        float[] fibo = new float[(int)derinlik];
        fibo[0] = 0; fibo[1] = 1; fibo[2] = 1;   

        for(int i=3; i<fibo.Length; i++)
        {
            fibo[i] = fibo[i - 2] + fibo[i - 1];
        }

        float fiboort = fibo.Sum()/fibo.Length;

        Console.WriteLine(fiboort);        
    }
    public static void Triangle()    // Üçgen çizen
    {
        Console.Write("Üçgenin kenar uzunluğunu girin: ");
        int kenarUzunlugu = int.Parse(Console.ReadLine());

        for (int i = 1; i <= kenarUzunlugu; i++)
        {
            for (int j = 1; j <= kenarUzunlugu - i; j++)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    public static void Circle()      // Çember çizen
    {
        Console.Write("Dairenin yarıçapını girin: ");
        int radius = int.Parse(Console.ReadLine());

        for (double y = -radius; y <= radius; y++)
        {
            for (double x = -radius; x <= radius; x += 0.5)
            {
                if ((x * x) + (y * y) >= radius * radius)
                    Console.Write(" ");
                else
                    Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    public static void Algoritma()
    {
        Console.Write("bir kelime ve bir sayı giriniz (virgül ile ayırınız):    "   );
        string input = Console.ReadLine();
        string[] _input = input.Split(',');
        int sayi = int.Parse(_input[1]);
        Console.WriteLine(sayi);
        _input[0].Remove(sayi - 1);
        Console.WriteLine(_input[0].Remove(sayi-1,1));
        

              

       
        

    }
}