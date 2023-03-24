internal class Program
{
    private static void Main(string[] args)
    {
        Fibonacci(); // *** Kolay Seviye Projeler - Ortalama Hesaplama  *** Kulanıcıdan alınan derinliğe göre fibonacci serisindeki
                     // rakamların ortalamasını alıp ekrana yazdıran uygulamayı yazınız.
       

    }

    public static void Fibonacci ()   // Ortalama Hesaplama
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
}