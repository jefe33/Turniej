using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Zawodnik : Czlowiek
    {
        public int NrZawodnika { get; set; }
        public Zawodnik(string imie, string nazwisko, int nrZawodnika)
            : base(imie, nazwisko) { NrZawodnika = nrZawodnika; }
        public override string ToString() { return $"nr.{NrZawodnika} {base.ToString()}"; }

        public bool Equals(Zawodnik inna)
        {
            return (inna != null) && (Imie.Equals(inna.Imie)) && (Nazwisko.Equals(inna.Nazwisko));
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || !(obj is Zawodnik))
                return false;
            else
                return Equals(obj as Zawodnik);
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
