using System;
using System.Collections.Generic;

namespace Projekt
{
    [Serializable]
    public class Druzyna
    {
        public string NazwaDruzyny { get; set; }
        private List<Zawodnik> zawodnicy;
        public int WynikSiatkowka { get; set; }
        public int WynikPrzeciaganieLiny { get; set; }
        public int Wynik2Ognie { get; set; }
        public Druzyna(string nazwaDruzyny) 
        { 
            zawodnicy = new List<Zawodnik>(); 
            NazwaDruzyny = nazwaDruzyny; 
        }
        public override string ToString()
        {
            string napis = $"Druzyna {NazwaDruzyny}\n";
            for (int i = 0; i < zawodnicy.Count; i++)
                napis += $"{ zawodnicy[i]}\n";
            return napis;
        }
        public void DodajZawodnika(Zawodnik nowyZawodnik)
        {
            zawodnicy.Add(nowyZawodnik);
        }
        public bool UsunZawodnika(Zawodnik zawodnikDoUsuniecia)
        {
            return zawodnicy.Remove(zawodnikDoUsuniecia);
        }

        public bool Equals(Druzyna inna)
        {
            return (inna != null) && (NazwaDruzyny.Equals(inna.NazwaDruzyny));
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || !(obj is Druzyna))
                return false;
            else
                return Equals(obj as Druzyna);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        /*public override int GetHashCode()
        {
            return System.HashCode.Combine(Imie, Nazwisko);
        }*/
    }
}
