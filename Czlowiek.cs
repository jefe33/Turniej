using System;

namespace Projekt
{
    [Serializable]
    public abstract class Czlowiek
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public Czlowiek(string imie, string nazwisko) { Imie = imie; Nazwisko = nazwisko; }
        public override string ToString() { return $"{Imie} {Nazwisko}"; }
    }
}
