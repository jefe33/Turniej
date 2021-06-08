using System;
using Projekt.Exceptions;

namespace Projekt
{
    class Program
    {
        static private string wczytajint()
        {
            string inputS;
            short tmpshort;

            inputS = Console.ReadLine();
            while (Int16.TryParse(inputS, out tmpshort) == false)
            {
                Console.WriteLine("Nieprawidlowy numer. Wpisz ponownie.");
                inputS = Console.ReadLine();
            }
            return inputS;
        }

        static void Main(string[] args)
        {
            Turniej siatka= new Turniej("siatkowka");
            Turniej ognie = new Turniej("2ognie");
            Turniej lina = new Turniej("przeciaganie liny");

            int fazaS = 0;
            int fazaO = 0;
            int fazaL = 0; 

            Sedziowie sed = new Sedziowie();
            Sedzia s1 = new Sedzia("S1", "G1");
            Sedzia s2 = new Sedzia("P1", "p1");
            Sedzia s3 = new Sedzia("p3", "p5");
            sed.DodajSedziego(s1);
            sed.DodajSedziego(s2);
            sed.DodajSedziego(s3);

            ConsoleKeyInfo input1;
            int inputINT;


            #region tmp

            Druzyna tmpD = new Druzyna("TMP");

            Zawodnik tmpZ1 = new Zawodnik("TMP", "TMP", 101);
            Zawodnik tmpZ2 = new Zawodnik("TMP", "TMP", 102);
            Zawodnik tmpZ3 = new Zawodnik("TMP", "TMP", 103);
            Zawodnik tmpZ4 = new Zawodnik("TMP", "TMP", 104);
            Zawodnik tmpZ5 = new Zawodnik("TMP", "TMP", 105);

            tmpD.DodajZawodnika(tmpZ1);
            tmpD.DodajZawodnika(tmpZ2);
            tmpD.DodajZawodnika(tmpZ3);
            tmpD.DodajZawodnika(tmpZ4);
            tmpD.DodajZawodnika(tmpZ5);

            #endregion

            #region druzyny

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

            d5.DodajZawodnika(z1);
            d5.DodajZawodnika(z2);
            d5.DodajZawodnika(z3);
            d5.DodajZawodnika(z4);
            d5.DodajZawodnika(z5);

            d6.DodajZawodnika(z6);
            d6.DodajZawodnika(z7);
            d6.DodajZawodnika(z8);
            d6.DodajZawodnika(z9);
            d6.DodajZawodnika(z10);

            d7.DodajZawodnika(z11);
            d7.DodajZawodnika(z12);
            d7.DodajZawodnika(z13);
            d7.DodajZawodnika(z14);
            d7.DodajZawodnika(z15);

            d8.DodajZawodnika(z16);
            d8.DodajZawodnika(z17);
            d8.DodajZawodnika(z18);
            d8.DodajZawodnika(z19);
            d8.DodajZawodnika(z20);

            #endregion

            #region dodawanie druzyn

            siatka.DodajDruzyne(d1);
            siatka.DodajDruzyne(d2);
            siatka.DodajDruzyne(d3);
            siatka.DodajDruzyne(d4);
            siatka.DodajDruzyne(d5);
            siatka.DodajDruzyne(d6);
            siatka.DodajDruzyne(d7);
            siatka.DodajDruzyne(d8);

            ognie.DodajDruzyne(d1);
            ognie.DodajDruzyne(d2);
            ognie.DodajDruzyne(d3);
            ognie.DodajDruzyne(d4);
            ognie.DodajDruzyne(d5);
            ognie.DodajDruzyne(d6);
            ognie.DodajDruzyne(d7);
            ognie.DodajDruzyne(d8);

            lina.DodajDruzyne(d1);
            lina.DodajDruzyne(d2);
            lina.DodajDruzyne(d3);
            lina.DodajDruzyne(d4);
            lina.DodajDruzyne(d5);
            lina.DodajDruzyne(d6);
            lina.DodajDruzyne(d7);
            lina.DodajDruzyne(d8);

            #endregion

            #region menu

            while (2 > 0)
            {
                Console.Clear();
                Console.WriteLine("Projekt:Kopakabana");
                Console.WriteLine("Wybierz turniej po przez wpisanie liczby:\n1 - Siatkowka\n2 - 2 ognie\n3 - przeciagnie liny\nbadz wpisz:\n4 - by edytowac druzyny\n5 - by edytowac sedziow\nEsc - by wyjsc");
                input1 = Console.ReadKey();
                while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.D2 && input1.Key != ConsoleKey.D3 && input1.Key != ConsoleKey.D4 && input1.Key != ConsoleKey.D5 && input1.Key != ConsoleKey.Escape)
                {
                    input1 = Console.ReadKey();
                }
                switch (input1.Key)
                {
                    case ConsoleKey.D1:

                        #region sekcja turniej siatkowki
                        //petla menu rozgrywek siatkowki
                        do {
                            Console.Clear();

                            #region przed rozpoczeciem rozgrywek
                            //rozgrywka generuj faze grupową
                            if (fazaS == 0)
                            {
                                Console.WriteLine(siatka.ToString());
                                Console.WriteLine("Nie zaczeto");
                                Console.WriteLine("Wcisnij 1 by rozpocząć pierwsza faze rozgrywek, Esc by wyjsc");
                                input1 = Console.ReadKey();
                                while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.Escape)
                                {
                                    input1 = Console.ReadKey();
                                }
                                if(input1.Key == ConsoleKey.D1)
                                {
                                    siatka.GenerujFazeGrupowa(sed);
                                    fazaS = 1;
                                    Console.Clear();
                                }
                            }
                            #endregion

                            #region po rozegraniu rozgrywek grupowych
                            //rozgrywka generuj pol final
                            if (fazaS == 1)
                            {
                                Console.WriteLine(siatka.TabelaWynikow());
                                Console.WriteLine("Wcisnij 1 by rozpocząć druga faze rozgrywek, 2 by wyswietlic historie rozgrywek, Esc by wyjsc"); input1 = Console.ReadKey();
                                while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.D2 && input1.Key != ConsoleKey.Escape)
                                {
                                    input1 = Console.ReadKey();
                                }
                                switch (input1.Key)
                                {
                                    case ConsoleKey.D1:
                                        siatka.GenerujPolFinal(sed);
                                        fazaS = 2;
                                        Console.Clear();
                                        break;
                                    case ConsoleKey.D2:
                                        Console.Clear();
                                        Console.WriteLine(siatka.ToString());
                                        Console.WriteLine("Nacisnij dowolny klawisz by wrocic");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                }
                            }
                            #endregion

                            #region po rozegraniu polfinalu
                            //rozgrywka generuj final
                            if (fazaS == 2)
                            {
                                Console.WriteLine(siatka.TabelaWynikow());
                                Console.WriteLine("Wcisnij 1 by rozpocząć trzecia faze rozgrywek, 2 by wyswietlic historie rozgrywek, Esc by wyjsc"); input1 = Console.ReadKey();
                                while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.D2 && input1.Key != ConsoleKey.Escape)
                                {
                                    input1 = Console.ReadKey();
                                }
                                switch (input1.Key)
                                {
                                    case ConsoleKey.D1:
                                        siatka.GenerujFinal(sed);
                                        fazaS = 3;
                                        Console.Clear();
                                        break;
                                    case ConsoleKey.D2:
                                        Console.Clear();
                                        Console.WriteLine(siatka.ToString());
                                        Console.WriteLine("Nacisnij dowolny klawisz by wrocic");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                }
                            }
                            #endregion

                            #region po rozegraniu finalu
                            //wyswietl rezultat
                            if (fazaS == 3)
                            {
                                Console.WriteLine(siatka.TabelaWynikow());
                                Console.WriteLine("ZWYCIEZCA: " + siatka.ListaDruzyn[0]);
                                Console.WriteLine("Wcisnij 1 by wyswietlic historie rozgrywek, Esc by wrocic");
                                input1 = Console.ReadKey();
                                while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.Escape)
                                {
                                    input1 = Console.ReadKey();
                                }
                                if (input1.Key == ConsoleKey.D1)
                                {
                                    Console.Clear();
                                    Console.WriteLine(siatka.ToString());
                                    Console.WriteLine("Nacisnij dowolny klawisz by wrocic");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            #endregion

                        } while (input1.Key != ConsoleKey.Escape) ;
                        input1 = new ConsoleKeyInfo();

                        #endregion

                        break;
                    case ConsoleKey.D2:

                        #region sekcja turniej 2ogni
                        //petla menu rozgrywek 2ogni
                        do
                        {
                            Console.Clear();

                            #region przed rozpoczeciem rozgrywek
                            //rozgrywka generuj faze grupową
                            if (fazaO == 0)
                            {
                                Console.WriteLine(ognie.ToString());
                                Console.WriteLine("Nie zaczeto");
                                Console.WriteLine("Wcisnij 1 by rozpocząć pierwsza faze rozgrywek, Esc by wyjsc");
                                input1 = Console.ReadKey();
                                while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.Escape)
                                {
                                    input1 = Console.ReadKey();
                                }
                                if (input1.Key == ConsoleKey.D1)
                                {
                                    ognie.GenerujFazeGrupowa(sed);
                                    fazaO = 1;
                                    Console.Clear();
                                }
                            }
                            #endregion

                            #region po rozegraniu rozgrywek grupowych
                            //rozgrywka generuj pol final
                            if (fazaO == 1)
                            {
                                Console.WriteLine(ognie.TabelaWynikow());
                                Console.WriteLine("Wcisnij 1 by rozpocząć druga faze rozgrywek, 2 by wyswietlic historie rozgrywek, Esc by wyjsc"); input1 = Console.ReadKey();
                                while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.D2 && input1.Key != ConsoleKey.Escape)
                                {
                                    input1 = Console.ReadKey();
                                }
                                switch (input1.Key)
                                {
                                    case ConsoleKey.D1:
                                        ognie.GenerujPolFinal(sed);
                                        fazaO = 2;
                                        Console.Clear();
                                        break;
                                    case ConsoleKey.D2:
                                        Console.Clear();
                                        Console.WriteLine(ognie.ToString());
                                        Console.WriteLine("Nacisnij dowolny klawisz by wrocic");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                }
                            }
                            #endregion

                            #region po rozegraniu polfinalu
                            //rozgrywka generuj final
                            if (fazaO == 2)
                            {
                                Console.WriteLine(ognie.TabelaWynikow());
                                Console.WriteLine("Wcisnij 1 by rozpocząć trzecia faze rozgrywek, 2 by wyswietlic historie rozgrywek, Esc by wyjsc"); input1 = Console.ReadKey();
                                while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.D2 && input1.Key != ConsoleKey.Escape)
                                {
                                    input1 = Console.ReadKey();
                                }
                                switch (input1.Key)
                                {
                                    case ConsoleKey.D1:
                                        ognie.GenerujFinal(sed);
                                        fazaO = 3;
                                        Console.Clear();
                                        break;
                                    case ConsoleKey.D2:
                                        Console.Clear();
                                        Console.WriteLine(ognie.ToString());
                                        Console.WriteLine("Nacisnij dowolny klawisz by wrocic");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                }
                            }
                            #endregion

                            #region po rozegraniu finalu
                            //wyswietl rezultat
                            if (fazaO == 3)
                            {
                                Console.WriteLine(ognie.TabelaWynikow());
                                Console.WriteLine("ZWYCIEZCA: " + ognie.ListaDruzyn[0]);
                                Console.WriteLine("Wcisnij 1 by wyswietlic historie rozgrywek, Esc by wrocic");
                                input1 = Console.ReadKey();
                                while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.Escape)
                                {
                                    input1 = Console.ReadKey();
                                }
                                if (input1.Key == ConsoleKey.D1)
                                {
                                    Console.Clear();
                                    Console.WriteLine(ognie.ToString());
                                    Console.WriteLine("Nacisnij dowolny klawisz by wrocic");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            #endregion

                        } while (input1.Key != ConsoleKey.Escape) ;
                        input1 = new ConsoleKeyInfo();

                        #endregion

                        break;
                    case ConsoleKey.D3:

                        #region sekcja turniej przeciagania liny
                        //petla menu rozgrywek przeciagania liny
                        do
                        {
                            Console.Clear();

                            #region przed rozpoczeciem rozgrywek
                            //rozgrywka generuj faze grupową
                            if (fazaL == 0)
                            {
                                Console.WriteLine(lina.ToString());
                                Console.WriteLine("Nie zaczeto");
                                Console.WriteLine("Wcisnij 1 by rozpocząć pierwsza faze rozgrywek, 2 by wyjsc");
                                input1 = Console.ReadKey();
                                while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.D2)
                                {
                                    input1 = Console.ReadKey();
                                }
                                if (input1.Key == ConsoleKey.D1)
                                {
                                    lina.GenerujFazeGrupowa(sed);
                                    fazaL = 1;
                                    Console.Clear();
                                }
                            }
                            #endregion

                            #region po rozegraniu rozgrywek grupowych
                            //rozgrywka generuj pol final
                            if (fazaL == 1)
                            {
                                Console.WriteLine(lina.TabelaWynikow());
                                Console.WriteLine("Wcisnij 1 by rozpocząć druga faze rozgrywek, 2 by wyswietlic historie rozgrywek, Esc by wyjsc"); input1 = Console.ReadKey();
                                while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.D2 && input1.Key != ConsoleKey.Escape)
                                {
                                    input1 = Console.ReadKey();
                                }
                                switch (input1.Key)
                                {
                                    case ConsoleKey.D1:
                                        lina.GenerujPolFinal(sed);
                                        fazaL = 2;
                                        Console.Clear();
                                        break;
                                    case ConsoleKey.D2:
                                        Console.Clear();
                                        Console.WriteLine(lina.ToString());
                                        Console.WriteLine("Nacisnij dowolny klawisz by wrocic");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                }
                            }
                            #endregion

                            #region po rozegraniu polfinalu
                            //rozgrywka generuj final
                            if (fazaL == 2)
                            {
                                Console.WriteLine(lina.TabelaWynikow());
                                Console.WriteLine("Wcisnij 1 by rozpocząć trzecia faze rozgrywek, 2 by wyswietlic historie rozgrywek, Esc by wyjsc"); input1 = Console.ReadKey();
                                while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.D2 && input1.Key != ConsoleKey.Escape)
                                {
                                    input1 = Console.ReadKey();
                                }
                                switch (input1.Key)
                                {
                                    case ConsoleKey.D1:
                                        lina.GenerujFinal(sed);
                                        fazaL = 3;
                                        Console.Clear();
                                        break;
                                    case ConsoleKey.D2:
                                        Console.Clear();
                                        Console.WriteLine(lina.ToString());
                                        Console.WriteLine("Nacisnij dowolny klawisz by wrocic");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;

                                }
                            }
                            #endregion

                            #region po rozegraniu finalu
                            //wyswietl rezultat
                            if (fazaL == 3)
                            {
                                Console.WriteLine(lina.TabelaWynikow());
                                Console.WriteLine("ZWYCIEZCA: " + lina.ListaDruzyn[0]);
                                Console.WriteLine("Wcisnij 1 by wyswietlic historie rozgrywek, Esc by wrocic");
                                input1 = Console.ReadKey();
                                while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.Escape)
                                {
                                    input1 = Console.ReadKey();
                                }
                                if (input1.Key == ConsoleKey.D1)
                                {
                                    Console.Clear();
                                    Console.WriteLine(lina.ToString());
                                    Console.WriteLine("Nacisnij dowolny klawisz by wrocic");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                            }
                            #endregion

                        } while (input1.Key != ConsoleKey.Escape) ;
                        input1 = new ConsoleKeyInfo();

                        #endregion

                        break;
                    case ConsoleKey.D4:

                        #region sekcja zarzadzenie druzynami
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Wybierz turniej w ktorym chcesz zarzadzac druzynami\n1 - Siatkowka\n2 - 2 ognie\n3 - przeciagnie liny\nbadz wpisz:\nEsc - by wrocic");
                            input1 = Console.ReadKey();
                            while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.D2 && input1.Key != ConsoleKey.D3 && input1.Key != ConsoleKey.Escape)
                            {
                                input1 = Console.ReadKey();
                            }
                            switch (input1.Key)
                            {
                                case ConsoleKey.D1:

                                    #region zarzadzanie druzynami w siatkowce
                                    do
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Lista druzyn biorace udzial w siatkowce:");
                                        int i = 1;
                                        foreach (Druzyna d in siatka.ListaDruzyn)
                                        {
                                            Console.WriteLine("Nr." + i);
                                            Console.WriteLine(d.ToString());
                                            i++;
                                        }
                                        if (fazaS < 2)
                                        {
                                            Console.WriteLine("Wpisz 1 by dodac druzyne, 2 by usunac druzyne, Esc by wrocic");
                                            input1 = Console.ReadKey();
                                            while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.D2 && input1.Key != ConsoleKey.Escape)
                                            {
                                                input1 = Console.ReadKey();
                                            }
                                            switch (input1.Key)
                                            {
                                                case ConsoleKey.D1:

                                                    #region dodaj zawodnika
                                                    Console.WriteLine("Wpisz nazwe druzyny");
                                                    tmpD = new Druzyna(Console.ReadLine());
                                                    Console.WriteLine("Wpisz imie, nazwisko i numer pierwszego zawodnika, oddzielajac enterem");
                                                    tmpZ1.Imie = Console.ReadLine();
                                                    tmpZ1.Nazwisko = Console.ReadLine();
                                                    tmpZ1.NrZawodnika = Int16.Parse(wczytajint());
                                                    Console.WriteLine("Wpisz imie, nazwisko i numer drugiego zawodnika, oddzielajac enterem");
                                                    tmpZ2.Imie = Console.ReadLine();
                                                    tmpZ2.Nazwisko = Console.ReadLine();
                                                    tmpZ2.NrZawodnika = Int16.Parse(wczytajint());
                                                    Console.WriteLine("Wpisz imie, nazwisko i numer trzeciego zawodnika, oddzielajac enterem");
                                                    tmpZ3.Imie = Console.ReadLine();
                                                    tmpZ3.Nazwisko = Console.ReadLine();
                                                    tmpZ3.NrZawodnika = Int16.Parse(wczytajint());
                                                    Console.WriteLine("Wpisz imie, nazwisko i numer czwartego zawodnika, oddzielajac enterem");
                                                    tmpZ4.Imie = Console.ReadLine();
                                                    tmpZ4.Nazwisko = Console.ReadLine();
                                                    tmpZ4.NrZawodnika = Int16.Parse(wczytajint());
                                                    Console.WriteLine("Wpisz imie, nazwisko i numer piatego zawodnika, oddzielajac enterem");
                                                    tmpZ5.Imie = Console.ReadLine();
                                                    tmpZ5.Nazwisko = Console.ReadLine();
                                                    tmpZ5.NrZawodnika = Int16.Parse(wczytajint());

                                                    tmpD.DodajZawodnika(tmpZ1);
                                                    tmpD.DodajZawodnika(tmpZ2);
                                                    tmpD.DodajZawodnika(tmpZ3);
                                                    tmpD.DodajZawodnika(tmpZ4);
                                                    tmpD.DodajZawodnika(tmpZ5);
                                                    siatka.DodajDruzyne(tmpD);

                                                    Console.WriteLine("Dodano druzyne. Nacisnij dowolny klawisz by wrocic");
                                                    Console.ReadKey();
                                                    #endregion

                                                    break;
                                                case ConsoleKey.D2:

                                                    #region usun zawodnika
                                                    Console.WriteLine("Wpisz numer druzyny ktora chcesz usunac");
                                                    inputINT = Int16.Parse(wczytajint());
                                                    while (inputINT > siatka.ListaDruzyn.Count || inputINT < 0)
                                                    {
                                                        Console.WriteLine("Niepoprawny numer. Wpisz ponownie");
                                                        inputINT = Int16.Parse(wczytajint());
                                                    }
                                                    siatka.UsunDruzyne(siatka.ListaDruzyn[inputINT-1]);
                                                    Console.WriteLine("Usunieto druzyne. Nacisnij dowolny klawisz by wrocic");
                                                    Console.ReadKey();
                                                    #endregion

                                                    break;
                                                case ConsoleKey.Escape:
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Rozgrywki zostaly juz rozpoczete. Modyfikacja na typ etapie nie jest mozliwa.\nNacisnij Esc by powrocic.");
                                            input1 = Console.ReadKey();
                                            while (input1.Key != ConsoleKey.Escape)
                                            {
                                                input1 = Console.ReadKey();
                                            }
                                        }
                                    } while (input1.Key != ConsoleKey.Escape);
                                    input1 = new ConsoleKeyInfo();
                                    #endregion

                                    break;
                                case ConsoleKey.D2:

                                    #region zarzadzanie druzynami w 2 ogniach
                                    do
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Lista druzyn biorace udzial w 2 ogniach:");
                                        int i = 1;
                                        foreach (Druzyna d in ognie.ListaDruzyn)
                                        {
                                            Console.WriteLine("Nr." + i);
                                            Console.WriteLine(d.ToString());
                                            i++;
                                        }
                                        if (fazaO < 2)
                                        {
                                            Console.WriteLine("Wpisz 1 by dodac druzyne, 2 by usunac druzyne, Esc by wrocic");
                                            input1 = Console.ReadKey();
                                            while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.D2 && input1.Key != ConsoleKey.Escape)
                                            {
                                                input1 = Console.ReadKey();
                                            }
                                            switch (input1.Key)
                                            {
                                                case ConsoleKey.D1:

                                                    #region dodaj zawodnika
                                                    Console.WriteLine("Wpisz nazwe druzyny");
                                                    tmpD = new Druzyna(Console.ReadLine());
                                                    Console.WriteLine("Wpisz imie, nazwisko i numer pierwszego zawodnika, oddzielajac enterem");
                                                    tmpZ1.Imie = Console.ReadLine();
                                                    tmpZ1.Nazwisko = Console.ReadLine();
                                                    tmpZ1.NrZawodnika = Int16.Parse(wczytajint());
                                                    Console.WriteLine("Wpisz imie, nazwisko i numer drugiego zawodnika, oddzielajac enterem");
                                                    tmpZ2.Imie = Console.ReadLine();
                                                    tmpZ2.Nazwisko = Console.ReadLine();
                                                    tmpZ2.NrZawodnika = Int16.Parse(wczytajint());
                                                    Console.WriteLine("Wpisz imie, nazwisko i numer trzeciego zawodnika, oddzielajac enterem");
                                                    tmpZ3.Imie = Console.ReadLine();
                                                    tmpZ3.Nazwisko = Console.ReadLine();
                                                    tmpZ3.NrZawodnika = Int16.Parse(wczytajint());
                                                    Console.WriteLine("Wpisz imie, nazwisko i numer czwartego zawodnika, oddzielajac enterem");
                                                    tmpZ4.Imie = Console.ReadLine();
                                                    tmpZ4.Nazwisko = Console.ReadLine();
                                                    tmpZ4.NrZawodnika = Int16.Parse(wczytajint());
                                                    Console.WriteLine("Wpisz imie, nazwisko i numer piatego zawodnika, oddzielajac enterem");
                                                    tmpZ5.Imie = Console.ReadLine();
                                                    tmpZ5.Nazwisko = Console.ReadLine();
                                                    tmpZ5.NrZawodnika = Int16.Parse(wczytajint());

                                                    tmpD.DodajZawodnika(tmpZ1);
                                                    tmpD.DodajZawodnika(tmpZ2);
                                                    tmpD.DodajZawodnika(tmpZ3);
                                                    tmpD.DodajZawodnika(tmpZ4);
                                                    tmpD.DodajZawodnika(tmpZ5);
                                                    ognie.DodajDruzyne(tmpD);

                                                    Console.WriteLine("Dodano druzyne. Nacisnij dowolny klawisz by wrocic");
                                                    Console.ReadKey();
                                                    #endregion

                                                    break;
                                                case ConsoleKey.D2:

                                                    #region usun zawodnika
                                                    Console.WriteLine("Wpisz numer druzyny ktora chcesz usunac");
                                                    inputINT = Int16.Parse(wczytajint());
                                                    while (inputINT > ognie.ListaDruzyn.Count || inputINT < 0)
                                                    {
                                                        Console.WriteLine("Niepoprawny numer. Wpisz ponownie");
                                                        inputINT = Int16.Parse(wczytajint());
                                                    }
                                                    ognie.UsunDruzyne(ognie.ListaDruzyn[inputINT-1]);
                                                    Console.WriteLine("Usunieto druzyne. Nacisnij dowolny klawisz by wrocic");
                                                    Console.ReadKey();
                                                    #endregion

                                                    break;
                                                case ConsoleKey.Escape:
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Rozgrywki zostaly juz rozpoczete. Modyfikacja na typ etapie nie jest mozliwa.\nNacisnij Esc by powrocic.");
                                            input1 = Console.ReadKey();
                                            while(input1.Key != ConsoleKey.Escape)
                                            {
                                                input1 = Console.ReadKey();
                                            }
                                        }
                                    } while (input1.Key != ConsoleKey.Escape);
                                    input1 = new ConsoleKeyInfo();
                                    #endregion

                                    break;
                                case ConsoleKey.D3:

                                    #region zarzadzanie druzynami w przeciagniu liny
                                    do
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Lista druzyn biorace udzial w przeciagniu liny:");
                                        int i = 1;
                                        foreach (Druzyna d in lina.ListaDruzyn)
                                        {
                                            Console.WriteLine("Nr." + i);
                                            Console.WriteLine(d.ToString());
                                            i++;
                                        }
                                        if (fazaL < 2)
                                        {
                                            Console.WriteLine("Wpisz 1 by dodac druzyne, 2 by usunac druzyne, Esc by wrocic");
                                            input1 = Console.ReadKey();
                                            while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.D2 && input1.Key != ConsoleKey.Escape)
                                            {
                                                input1 = Console.ReadKey();
                                            }
                                            switch (input1.Key)
                                            {
                                                case ConsoleKey.D1:

                                                    #region dodaj zawodnika
                                                    Console.WriteLine("Wpisz nazwe druzyny");
                                                    tmpD = new Druzyna(Console.ReadLine());
                                                    Console.WriteLine("Wpisz imie, nazwisko i numer pierwszego zawodnika, oddzielajac enterem");
                                                    tmpZ1.Imie = Console.ReadLine();
                                                    tmpZ1.Nazwisko = Console.ReadLine();
                                                    tmpZ1.NrZawodnika = Int16.Parse(wczytajint());
                                                    Console.WriteLine("Wpisz imie, nazwisko i numer drugiego zawodnika, oddzielajac enterem");
                                                    tmpZ2.Imie = Console.ReadLine();
                                                    tmpZ2.Nazwisko = Console.ReadLine();
                                                    tmpZ2.NrZawodnika = Int16.Parse(wczytajint());
                                                    Console.WriteLine("Wpisz imie, nazwisko i numer trzeciego zawodnika, oddzielajac enterem");
                                                    tmpZ3.Imie = Console.ReadLine();
                                                    tmpZ3.Nazwisko = Console.ReadLine();
                                                    tmpZ3.NrZawodnika = Int16.Parse(wczytajint());
                                                    Console.WriteLine("Wpisz imie, nazwisko i numer czwartego zawodnika, oddzielajac enterem");
                                                    tmpZ4.Imie = Console.ReadLine();
                                                    tmpZ4.Nazwisko = Console.ReadLine();
                                                    tmpZ4.NrZawodnika = Int16.Parse(wczytajint());
                                                    Console.WriteLine("Wpisz imie, nazwisko i numer piatego zawodnika, oddzielajac enterem");
                                                    tmpZ5.Imie = Console.ReadLine();
                                                    tmpZ5.Nazwisko = Console.ReadLine();
                                                    tmpZ5.NrZawodnika = Int16.Parse(wczytajint());

                                                    tmpD.DodajZawodnika(tmpZ1);
                                                    tmpD.DodajZawodnika(tmpZ2);
                                                    tmpD.DodajZawodnika(tmpZ3);
                                                    tmpD.DodajZawodnika(tmpZ4);
                                                    tmpD.DodajZawodnika(tmpZ5);
                                                    lina.DodajDruzyne(tmpD);

                                                    Console.WriteLine("Dodano druzyne. Nacisnij dowolny klawisz by wrocic");
                                                    Console.ReadKey();
                                                    #endregion

                                                    break;
                                                case ConsoleKey.D2:

                                                    #region usun zawodnika
                                                    Console.WriteLine("Wpisz numer druzyny ktora chcesz usunac");
                                                    inputINT = Int16.Parse(wczytajint());
                                                    while (inputINT > lina.ListaDruzyn.Count || inputINT < 0)
                                                    {
                                                        Console.WriteLine("Niepoprawny numer. Wpisz ponownie");
                                                        inputINT = Int16.Parse(wczytajint());
                                                    }
                                                    lina.UsunDruzyne(lina.ListaDruzyn[inputINT - 1]);
                                                    Console.WriteLine("Usunieto druzyne. Nacisnij dowolny klawisz by wrocic");
                                                    Console.ReadKey();
                                                    #endregion

                                                    break;
                                                case ConsoleKey.Escape:
                                                    break;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Rozgrywki zostaly juz rozpoczete. Modyfikacja na typ etapie nie jest mozliwa.\nNacisnij Esc by powrocic.");
                                            input1 = Console.ReadKey();
                                            while (input1.Key != ConsoleKey.Escape)
                                            {
                                                input1 = Console.ReadKey();
                                            }
                                        }
                                    } while (input1.Key != ConsoleKey.Escape);
                                    input1 = new ConsoleKeyInfo();
                                    #endregion

                                    break;
                                case ConsoleKey.Escape:
                                    break;
                            }
                        } while (input1.Key != ConsoleKey.Escape);
                        #endregion

                        break;
                    case ConsoleKey.D5:

                        #region sekcja zarzadanie sedziami
                        Console.Clear();
                        Console.WriteLine();

                        #endregion

                        break;
                    case ConsoleKey.Escape:

                        #region sekcja wyjdz z aplikacji
                        return;
                        #endregion

                        break;
                    default:
                        //opcja domyslna na wypadek zepsucia wejscia
                        break;

                }

            }

            #endregion


            #region test komentarz
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

            d5.DodajZawodnika(z16);
            d5.DodajZawodnika(z17);
            d5.DodajZawodnika(z18);
            d5.DodajZawodnika(z19);
            d5.DodajZawodnika(z20);

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
            t1.UsunDruzyne(d5);
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

            #endregion
        }
    }
}
