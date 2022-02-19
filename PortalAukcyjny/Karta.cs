using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalAukcyjny
{
    public class Karta
    {
        public Karta(int id, string nazwa, string numerKarty, decimal limit)
        {
            Id = id;
            Nazwa = nazwa;
            NumerKarty = numerKarty;
            Limit = limit;
        }


        public int Id { get; set; }
        public string? Nazwa { get; set; }
        public string NumerKarty { get; set; }
        public decimal Limit { get; set; }

        internal static void Add(Karta karta)
        {
            throw new NotImplementedException();
        }
    }
}
