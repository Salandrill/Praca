using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalAukcyjny
{
    public class Produkt
    {
        public Produkt(int id, string przedmiot, string kategoria, decimal cena, bool czyWyrozniony)
        {
            Id = id;
            Przedmiot = przedmiot;
            Kategoria = kategoria;
            Cena = cena;
            CzyWyrozniony = czyWyrozniony;
        }


        public int Id { get; set; }
        public string? Przedmiot { get; set; }
        public string? Kategoria { get; set; }
        public decimal Cena { get; set; }

        internal static void Add(Produkt produkt)
        {
            throw new NotImplementedException();
        }

        public bool CzyWyrozniony { get; set; }

    }
}
