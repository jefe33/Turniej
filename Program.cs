using System;
using Projekt.Exceptions;

namespace Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kod sprawdzajacy czy dziala klasa turniej (mozna usunac)
            /*
            Druzyna d1 = new Druzyna("Czarne smoki");
            Druzyna d2 = new Druzyna("Zlote orly");
            Druzyna d3 = new Druzyna("Mroczni wyznawcy");
            Druzyna d4 = new Druzyna("Ogniste demony");
            Druzyna d5 = new Druzyna("Bohaterscy Herosi");
            Druzyna d6 = new Druzyna("Bogowie Olimpu");
            Druzyna d7 = new Druzyna("Apostolowie Smierci");
            Druzyna d8 = new Druzyna("Wrozki i Kucyki");

            Zawodnik z1 = new Zawodnik("A", "B", 1);
            Zawodnik z2 = new Zawodnik("C", "D", 2);
            Zawodnik z3 = new Zawodnik("E", "F", 3);
            Zawodnik z4 = new Zawodnik("G", "H", 4);
            Zawodnik z5 = new Zawodnik("I", "J", 5);
            Zawodnik z6 = new Zawodnik("K", "L", 6);
            Zawodnik z7 = new Zawodnik("M", "N", 7);
            Zawodnik z8 = new Zawodnik("O", "P", 8);
            Zawodnik z9 = new Zawodnik("Q", "R", 9);
            Zawodnik z10 = new Zawodnik("S", "T", 10);
            Zawodnik z11 = new Zawodnik("U", "W", 11);
            Zawodnik z12 = new Zawodnik("V", "X", 12);
            Zawodnik z13 = new Zawodnik("Y", "Z", 13);
            Zawodnik z14 = new Zawodnik("AA", "BB", 14);
            Zawodnik z15 = new Zawodnik("CC", "DD", 15);
            Zawodnik z16 = new Zawodnik("EE", "FF", 16);
            Zawodnik z17 = new Zawodnik("GG", "HH", 17);
            Zawodnik z18 = new Zawodnik("II", "JJ", 18);
            Zawodnik z19 = new Zawodnik("KK", "LL", 19);
            Zawodnik z20 = new Zawodnik("MM", "NN", 20);

            d1.DodajZawodnika(z1);
            d1.DodajZawodnika(z2);
            d1.DodajZawodnika(z3);
            d1.DodajZawodnika(z4);
            d1.DodajZawodnika(z5);

            d2.DodajZawodnika(z6);
            d2.DodajZawodnika(z7);
            d2.DodajZawodnika(z8);
            d2.DodajZawodnika(z9);
            d2.DodajZawodnika(z10);

            d3.DodajZawodnika(z11);
            d3.DodajZawodnika(z12);
            d3.DodajZawodnika(z13);
            d3.DodajZawodnika(z14);
            d3.DodajZawodnika(z15);

            d4.DodajZawodnika(z16);
            d4.DodajZawodnika(z17);
            d4.DodajZawodnika(z18);
            d4.DodajZawodnika(z19);
            d4.DodajZawodnika(z20);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            Sedzia s1 = new Sedzia("S1", "G1");
            Sedzia s2 = new Sedzia("P1", "p1");
            Sedzia s3 = new Sedzia("P2", "p2");
            Sedzia s4 = new Sedzia("S4", "G4");
            Sedzia s5 = new Sedzia("P5", "p5");
            Sedzia s6 = new Sedzia("P6", "P6");
            Sedziowie sad1 = new Sedziowie();
            sad1.DodajSedziego(s1);
            sad1.DodajSedziego(s2);
            sad1.DodajSedziego(s3);
            sad1.DodajSedziego(s4);
            sad1.DodajSedziego(s5);
            sad1.DodajSedziego(s6);

            Turniej t1 = new Turniej("przeciaganie liny");
            t1.DodajDruzyne(d1);
            t1.DodajDruzyne(d2);
            t1.DodajDruzyne(d3);
            t1.DodajDruzyne(d4);
            t1.DodajDruzyne(d5);
            t1.DodajDruzyne(d6);
            t1.DodajDruzyne(d7);
            t1.DodajDruzyne(d8);
            t1.UsunDruzyne(d8);
            Console.WriteLine("            " + t1);
            Console.WriteLine("\nTabela wynikow przed faza grupowa\n"+t1.TabelaWynikow());
            t1.GenerujFazeGrupowa(sad1);
            Console.WriteLine("            " + t1);
            Console.WriteLine("tabela wynikow po fazie grupowej\n" + t1.TabelaWynikow());
            //Console.WriteLine("\n");
            
            //Console.WriteLine(t1);
            //Console.WriteLine("\n\n\n\n");
            Console.WriteLine("tabela wynikow po polfinale\n" + t1.TabelaWynikow());
            Plik.Zapisz("tpf.bin", t1);
            t1.GenerujFinal(sad1);
            Console.WriteLine("tabela wynikow po finale\n" + t1.TabelaWynikow());

            Console.WriteLine("Zapisanie i wczytanie z pliku stanow turnieju:\n");
            Turniej tur = Plik.Wczytaj<Turniej>("tpf.bin");
            Console.WriteLine("tabela wynikow po polfinale\n" + tur.TabelaWynikow());
            Plik.Zapisz("turniej.bin", t1);
            tur = Plik.Wczytaj<Turniej>("turniej.bin");
            Console.WriteLine("tabela wynikow po finale\n" + tur.TabelaWynikow());
            try
            {
                t1.UsunDruzyne(d8);
                t1.GenerujPolFinal(sad1);
            }
            catch (NotEnoughTeamsException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
            */
        }
    }
}
