using PortalAukcyjny;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PortalAukcyjny
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Aukcja produkt = new Aukcja();

            Console.WriteLine("Wybierz Opcję");
            Console.WriteLine("1 => Zakup");
            Console.WriteLine("2 => Sprzedaż");
            Console.WriteLine("3 => Zakończ Program");
            Console.WriteLine("Wybierz 1, 2 Lub 3:");
            string wybor = Console.ReadLine();



            switch (wybor)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Lista Przedmiotów na Aukcji");
                    Console.WriteLine("------------------------------");
                    foreach (var c in produkt.Produkty)
                    {
                        Console.WriteLine($"{c.Przedmiot} {c.Kategoria} Cena: {c.Cena} zł");
                    }




                    Console.WriteLine("Podaj Numer Produktu, który chcesz zakupić: ");
                    var wybor2 = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine("Podaj Numer Karty Kredytowej (Cztery cyfry)");
                    var karta = Console.ReadLine();





                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nieprawidłowy numer karty");
                        Console.WriteLine("Podaj Numer Karty Kredytowej (Cztery cyfry)");
                    }
                    break;
                case "2":

                    Console.Clear();
                    Console.WriteLine("PODAJ NAZWĘ PRZEDMIOTU, KTÓRY CHCESZ SPRZEDAĆ:");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("PODAJ KATEGORIĘ PRZEDMIOTU, DO KTÓREJ NALEŻY PRODUKT:");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("PODAJ CENĘ PRZEDMIOTU, KTÓRĄ CHCESZ OTRZYMAĆ:");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("NAPISZ \"tak\" JEŻELI PRZEDMIOT MA BYĆ PROMOWANY:");
                    Console.ReadLine();
                    foreach (var c in produkt.Produkty)
                    {
                        Console.WriteLine($"{c.Przedmiot} {c.Kategoria} Cena: {c.Cena} zł");
                    }
                    break;

                case "3":
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Wybierz 1-Zakup, 2-Sprzedaż, 3-Zakończ program");
                    Console.ReadLine();
                    break;
            }
        }


    }




}



