using System;
using System.Collections.Generic;

namespace Projekt
{
    [Serializable]
    public class Sedziowie
    {
        private List<Sedzia> listaSedziow;
        public Sedziowie() { listaSedziow = new List<Sedzia>(); }
        public override string ToString()
        {
            string napis = "";
            for (int i = 0; i < listaSedziow.Count; i++)
                napis += $"{i}:   { listaSedziow[i]}\n";
            return napis;
        }
        public void DodajSedziego(Sedzia nowySedzia)
        {
            listaSedziow.Add(nowySedzia);
        }
        public bool UsunSedziego(string imie, string nazwisko)
        {
            return listaSedziow.Remove(new Sedzia(imie, nazwisko));
        }
        public List<Sedzia> GetListaSedziow() { return listaSedziow; }
        public int WyszukajSedziego(string imie, string nazwisko)
        {
            Sedzia szukanySedzia = new Sedzia(imie, nazwisko);
            return listaSedziow.IndexOf(szukanySedzia);
        }
        public Sedzia WybierzLosowegoSedziego()
        {
            var rand = new Random();
            return listaSedziow[rand.Next(listaSedziow.Count)];
        }
    }
}
