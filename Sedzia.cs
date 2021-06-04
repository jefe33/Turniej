using System;

namespace Projekt
{
    [Serializable]
    public class Sedzia : Czlowiek
    {
        public Sedzia(string imie, string nazwisko) : base(imie, nazwisko) { }
        public override string ToString() { return base.ToString(); }

        public bool Equals(Sedzia inny)
        {
            return (inny != null) && (Imie.Equals(inny.Imie)) && (Nazwisko.Equals(inny.Nazwisko));
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
