using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Sedzia : Czlowiek
    {
        public Sedzia(string imie, string nazwisko) : base(imie, nazwisko) { }
        public override string ToString() { return base.ToString(); }

        public bool Equals(Sedzia inna)
        {
            return (inna != null) && (Imie.Equals(inna.Imie)) && (Nazwisko.Equals(inna.Nazwisko));
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || !(obj is Sedzia))
                return false;
            else
                return Equals(obj as Sedzia);
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
