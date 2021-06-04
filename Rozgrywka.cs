using System;
using Projekt.Exceptions;

namespace Projekt
{
    [Serializable]
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
            if (wynik != 0 && wynik != 1)
            {
                throw new IncorrectScoreException("Nieprawidlowy wynik!!!");
            }
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
