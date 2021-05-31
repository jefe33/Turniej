using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Rozgrywka
    {
        private Druzyna druzynaA;
        private Druzyna druzynaB;
        private Sedzia sedziaGlowny;
        private int wynik;
        public Rozgrywka(Druzyna druzynaA, Druzyna druzynaB, Sedzia sedziaGlowny, int wynik) 
        {
            this.druzynaA = druzynaA;
            this.druzynaB = druzynaB;
            this.sedziaGlowny = sedziaGlowny;
            this.wynik = wynik; //tu powinien byc wyjatek sprawdzajacy czy wynik = 0 lub wynik = 1
        }
        public override string ToString() 
        {
            string napis = $"{druzynaA.NazwaDruzyny} - {druzynaB.NazwaDruzyny} {wynik}:{(wynik+1)%2}";
            napis += $"\nSedzia Glowny: {sedziaGlowny}";
            return napis;
        }
    }
}
