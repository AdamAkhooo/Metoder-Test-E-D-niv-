using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("skriv in bredden på din rektangel");
        int tal1 = int.Parse(Console.ReadLine());
        Console.WriteLine("skriv in höjden på din rektangel");
        int tal2 = int.Parse(Console.ReadLine());

        int produkt = Area(tal1, tal2);
        Console.WriteLine("Arean av din rektangel är " + produkt + "cm");// hgh

    }
    static int Area(int tal1, int tal2)
    {
        int produkt = tal1 * tal2;
        return produkt;
    }



}