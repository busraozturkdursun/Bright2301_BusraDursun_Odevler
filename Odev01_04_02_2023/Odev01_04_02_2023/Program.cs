namespace Odev01_04_02_2023;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("1. Notunuzu Giriniz: ");
        int not1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("2. Notunuzu Giriniz: ");
        int not2 = Convert.ToInt32(Console.ReadLine());


        int toplam = not1 + not2;
        int ortalama = toplam / 2;

        if (ortalama >=50)
        {
            Console.WriteLine("Geçti");
        }
        else
        {
            Console.WriteLine("Kaldı");
        }
    }
}

