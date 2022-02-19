using PortalAukcyjny;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PortalAukcyjny
{
    public class Aukcja
    {
        public Aukcja()
        {
            StworzProdukty();
        }

        public List<Produkt> Produkty { get; set; } = new List<Produkt>();

        private void StworzProdukty()
        {
            Produkt.Add(new Produkt(1, "iPhone 12 Pro", "elektronika", 4600m, true));
            Produkt.Add(new Produkt(2, "Konsola Playstation 5", "elektronika", 2899m, false));
            Produkt.Add(new Produkt(3, "Bluza Adidas Męska Szara", "odzież", 249m, true));
            Produkt.Add(new Produkt(4, "Spodnie Wrangler Arizona", "odzież", 189m, false));
            Produkt.Add(new Produkt(5, "Basen ogrodowy Premium", "dom i ogród", 1199m, false));
            Produkt.Add(new Produkt(6, "Krzesło skandynawskie granatowe", "dom i ogród", 88m, false));
        }

        public List<Karta> Karty { get; set; } = new List<Karta>();

        private void StworzKarty()
        {
            Karta.Add(new Karta(1, "Visa", "0001", 100m));
            Karta.Add(new Karta(2, "Mastercard", "0002", 10000m));
            Karta.Add(new Karta(3, "American Express", "0003", 3000m));
            Karta.Add(new Karta(4, "Diners Club", "0004", 1000m));

        }
    }
}


