using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Sedziowie
    {
        private List<Sedzia> listaSedziow;
        public Sedziowie() { listaSedziow = new List<Sedzia>(); }
        public Sedziowie(string nazwaPliku) { } //Niedokonczony konstruktor
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
