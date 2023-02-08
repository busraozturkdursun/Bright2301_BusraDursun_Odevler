namespace Odev02_04_02_2023;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Vize puanını giriniz: ");
        int vize = Convert.ToInt32(Console.ReadLine());

        Console.Write("Final puanını giriniz: ");
        int final = Convert.ToInt32(Console.ReadLine());

        double vizeToplam = vize * 0.40;
        double finalToplam = final * 0.60;

        double toplam = vizeToplam + finalToplam;

        if (toplam >= 60)
        {
            Console.WriteLine("Başarılı ");
        }
        else
        {
            Console.WriteLine("Başarısız");
        }


    }
}

