using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class RozgrywkaSiatkowki : Rozgrywka
    {
        private Sedzia sedziaPomocniczy1;
        private Sedzia sedziaPomocniczy2;
        public RozgrywkaSiatkowki(Druzyna druzynaA, Druzyna druzynaB, Sedzia sedziaGlowny, Sedzia sedziaPomocniczy1, Sedzia sedziaPomocniczy2, int wynik)
            : base(druzynaA, druzynaB, sedziaGlowny, wynik) 
        {
            this.sedziaPomocniczy1 = sedziaPomocniczy1;
            this.sedziaPomocniczy2 = sedziaPomocniczy2;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nSedziowie pomocniczy: {sedziaPomocniczy1} i {sedziaPomocniczy2}";
        }
    }
}
