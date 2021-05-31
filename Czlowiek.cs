using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public abstract class Czlowiek
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public Czlowiek(string imie, string nazwisko) { Imie = imie; Nazwisko = nazwisko; }
        public override string ToString() { return $"{Imie} {Nazwisko}"; }
    }
}
