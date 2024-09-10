using ispitpripremaZadatak01;
using System;

namespace Zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Vozilo*****");

            // Kreirajte dva objekta Motocikl
            Motocikl motocikl1 = new Motocikl("Yamaha", 2021, 'A', true);
            Motocikl motocikl2 = new Motocikl("Suzuki", 2019, 'B', false);

            // Ispis podataka za prvi motocikl
            Console.WriteLine($"Model: {motocikl1.Model}, Godina: {motocikl1.GodinaProizvodnje}, Kategorija: {motocikl1.Kategorija}, Jednosjed: {motocikl1.Jednosjed}");
            Console.WriteLine(motocikl1.Kotaci());

            // Ispis podataka za drugi motocikl
            Console.WriteLine($"Model: {motocikl2.Model}, Godina: {motocikl2.GodinaProizvodnje}, Kategorija: {motocikl2.Kategorija}, Jednosjed: {motocikl2.Jednosjed}");
            Console.WriteLine(motocikl2.Kotaci());

            // Dodajemo Console.ReadLine() da konzola ostane otvorena
            Console.ReadLine();
        }
    }
}