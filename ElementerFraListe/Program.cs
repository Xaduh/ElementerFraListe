using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementerFraListe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> talListe = new List<int>() { 4, 7, 12, 17, -3, 8, 0, -45, 101 };
            List<int> lig7 = talListe.Where(number => number == 7).ToList();
            List<int> størrer4 = talListe.Where(number => number > 4).ToList();
            List<int> mindreLig0 = talListe.Where(number => number <= 0).ToList();
            Console.WriteLine("Tal lig 7");
            UdskrivListe(lig7);
            Console.WriteLine("\nTal størrer end 4");
            UdskrivListe(størrer4);
            Console.WriteLine("\nTal mindre eller lig 0");
            UdskrivListe(mindreLig0);
            Console.ReadKey();
            Console.Clear();
            Car c1 = new Car( 1, "Rio", "Kia", 2006, 250000, "Red");
            Car c2 = new Car( 2, "Rio", "Kia", 2007, 265000, "Black");
            Car c3 = new Car( 3, "Panda", "Fiat", 2017, 265000, "Black");
            Car c4 = new Car( 4, "Panda", "Fiat", 2017, 365000, "Yellow");
            Car c5 = new Car( 5, "S40", "Volvo", 2018, 665000, "White");
            Car c6 = new Car( 6, "S65", "Volvo", 2018, 600000, "White");
            Car c7 = new Car( 7, "Gorm", "Ferrari", 2000, 4665000, "White");
            Car c8 = new Car( 8, "Gorm", "Ferrari", 2018, 4665000, "White");
            List<Car> carList = new List<Car> { c1, c2, c3, c4, c5, c6, c7, c8 };
            List<Car> modelRio = carList.Where(mdl => mdl.Model == "Rio").ToList();
            List<Car> brandFerrari = carList.Where(mdl => mdl.Brand == "Ferrari").ToList();
            List<Car> fra2010OgFrem = carList.Where(mdl => mdl.Year >= 2010).ToList();
            List<Car> hvideBile = carList.Where(mdl => mdl.Color == "White").ToList();
            List<Car> car8 = carList.Where(mdl => mdl.Id == 8).ToList();
            Console.WriteLine("Model Rio:");
            UdskrivListe(modelRio);
            Console.WriteLine("\nFerrari:");
            UdskrivListe(brandFerrari);
            Console.WriteLine("\nFra 2010 og frem");
            UdskrivListe(fra2010OgFrem);
            Console.WriteLine("\nHvide biler");
            UdskrivListe(hvideBile);
            Console.WriteLine("\nBil med id 8");
            UdskrivListe(car8);
            Console.ReadKey();
        }

        /*Udvælg:
1 - alle med Model Rio
2 - alle Brand Ferrari
3 - alle fra 2010 og frem
4 - alle hvide biler
5 - udvælg Car objekt med Id 8*/

        static void UdskrivListe(List<int> modtagetListe)
        {
            foreach (var item in modtagetListe)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static void UdskrivListe(List<Car> modtagetListe)
        {
            foreach (var item in modtagetListe)
            {
                Console.WriteLine($"ID: {item.Id}\nModel: {item.Model}\nBrand: {item.Brand}\nYear: {item.Year}" +
                    $"\nPrice: {item.Price}\nColor: {item.Color}");
            }
        }
    }
}
