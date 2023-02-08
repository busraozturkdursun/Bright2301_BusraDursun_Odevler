namespace Odev03_04_02_2023;
class Program
{
    static void Main(string[] args)
    {

        Console.Write("Bir sayı Giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        Console.Write("Karesi için 1 yazınız, küp için 2 yazınız. ");
        int tercih = Convert.ToInt32(Console.ReadLine());

        int kare = sayi * sayi;
        int kup = sayi * sayi * sayi;

        if (tercih == 1)
        {
            Console.WriteLine("kare: " + kare);
        }

        else if (tercih == 2)
        {
            Console.WriteLine("küp:" + kup);
        }
        else 
            Console.WriteLine("Geçersiz sayı girdiniz. ");


    }
}

