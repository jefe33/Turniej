using System;
using System.Collections.Generic;
using System.IO;
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

        static private void dodajS(Sedziowie sed)
        {
            Console.WriteLine("\nWpisz imie nowego sedziego");
            Sedzia tmpS = new Sedzia("tmp", "tmp");
            tmpS.Imie = Console.ReadLine();
            Console.WriteLine("Wpisz nazwisko");
            tmpS.Nazwisko = Console.ReadLine();
            sed.DodajSedziego(tmpS);
            Console.WriteLine("Dodano sedziego. Nacisnij dowolny klawisz by wrocic");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Turniej siatka= new Turniej("siatkowka");
            Turniej ognie = new Turniej("2ognie");
            Turniej lina = new Turniej("przeciaganie liny");

            Sedziowie sed = new Sedziowie();

            ConsoleKeyInfo input1;
            int inputINT;
            int inputINT2;
            int i;

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

            Sedzia tmpS = new Sedzia("tymczasowy", "sedzia");
            #endregion

            Console.WriteLine("Czy chcesz wczytać stan turnieju? \nY/N");
            do
            {
                input1 = Console.ReadKey();
            } while (input1.Key != ConsoleKey.Y && input1.Key != ConsoleKey.N);

            if (input1.Key == ConsoleKey.Y)
            {
                //wczytaj pliki
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Podaj sciezke/nazwe pliku");
                        string sciezka = Console.ReadLine();
                        List<Object> turnieje = Plik.Wczytaj<List<Object>>(sciezka);
                        siatka = (Turniej) turnieje[0];
                        ognie = (Turniej) turnieje[1];
                        lina = (Turniej) turnieje[2];
                        break;
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        break;
                    }
                }
                
            }
            else
            {
                #region dodawnie sedziow
                Sedzia s1 = new Sedzia("S1", "G1");
                Sedzia s2 = new Sedzia("P1", "p1");
                Sedzia s3 = new Sedzia("p3", "p5");
                sed.DodajSedziego(s1);
                sed.DodajSedziego(s2);
                sed.DodajSedziego(s3);

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
            }

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
                            if (siatka.faza == 0)
                            {
                                Console.WriteLine(siatka.ToString());
                                Console.WriteLine("Nie zaczeto");
                                Console.WriteLine("Wcisnij 1 by rozpocząć faze grupowa, Esc by wyjsc");
                                input1 = Console.ReadKey();
                                while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.Escape)
                                {
                                    input1 = Console.ReadKey();
                                }
                                if(input1.Key == ConsoleKey.D1)
                                {
                                    try
                                    {
                                        siatka.GenerujFazeGrupowa(sed);
                                        siatka.faza = 1;
                                    }
                                    catch (NotEnoughRefereesException)
                                    {
                                        Console.WriteLine("Niewystarczaja ilosc sedziow");
                                        dodajS(sed);
                                    }
                                    catch (NotEnoughTeamsException)
                                    {
                                        Console.WriteLine("Niewystarczaja ilosc druzyn");
                                        #region dodaj druzyne
                                        Console.WriteLine("\nWpisz nazwe druzyny");
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

                                        Console.WriteLine("Dodano druzyne. Nacisnij dowolny klawisz by kontynuowac");
                                        Console.ReadKey();
                                        #endregion
                                    }
                                    Console.Clear();
                                }
                            }
                            #endregion

                            #region po rozegraniu rozgrywek grupowych
                            //rozgrywka generuj pol final
                            if (siatka.faza == 1)
                            {
                                Console.WriteLine(siatka.TabelaWynikow());
                                Console.WriteLine("Wcisnij 1 by rozpocząć faze polfinalowa, 2 by wyswietlic historie rozgrywek, Esc by wyjsc"); input1 = Console.ReadKey();
                                while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.D2 && input1.Key != ConsoleKey.Escape)
                                {
                                    input1 = Console.ReadKey();
                                }
                                switch (input1.Key)
                                {
                                    case ConsoleKey.D1:
                                        try
                                        {
                                            siatka.GenerujPolFinal(sed);
                                            siatka.faza = 2;
                                        }
                                        catch (NotEnoughRefereesException)
                                        {
                                            Console.WriteLine("Niewystarczaja ilosc sedziow");
                                            dodajS(sed);
                                        }
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
                            if (siatka.faza == 2)
                            {
                                Console.WriteLine(siatka.TabelaWynikow());
                                Console.WriteLine("Wcisnij 1 by rozpocząć faze finalowa, 2 by wyswietlic historie rozgrywek, Esc by wyjsc"); input1 = Console.ReadKey();
                                while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.D2 && input1.Key != ConsoleKey.Escape)
                                {
                                    input1 = Console.ReadKey();
                                }
                                switch (input1.Key)
                                {
                                    case ConsoleKey.D1:
                                        try
                                        {
                                            siatka.GenerujFinal(sed);
                                            siatka.faza = 3;
                                        }
                                        catch (NotEnoughRefereesException )
                                        {
                                            Console.WriteLine("Niewystarczaja ilosc sedziow");
                                            dodajS(sed);
                                        }
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
                            if (siatka.faza == 3)
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
                            if (ognie.faza == 0)
                            {
                                Console.WriteLine(ognie.ToString());
                                Console.WriteLine("Nie zaczeto");
                                Console.WriteLine("Wcisnij 1 by rozpocząć faze grupowa, Esc by wyjsc");
                                input1 = Console.ReadKey();
                                while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.Escape)
                                {
                                    input1 = Console.ReadKey();
                                }
                                if (input1.Key == ConsoleKey.D1)
                                {
                                    try
                                    {
                                        ognie.GenerujFazeGrupowa(sed);
                                        ognie.faza = 1;
                                    }
                                    catch (NotEnoughRefereesException )
                                    {
                                        Console.WriteLine("Niewystarczaja ilosc sedziow");
                                        dodajS(sed);
                                    }
                                    catch (NotEnoughTeamsException)
                                    {
                                        Console.WriteLine("Niewystarczaja ilosc druzyn");
                                        #region dodaj druzyne
                                        Console.WriteLine("\nWpisz nazwe druzyny");
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

                                        Console.WriteLine("Dodano druzyne. Nacisnij dowolny klawisz by kontynuowac");
                                        Console.ReadKey();
                                        #endregion
                                    }
                                    Console.Clear();
                                }
                            }
                            #endregion

                            #region po rozegraniu rozgrywek grupowych
                            //rozgrywka generuj pol final
                            if (ognie.faza == 1)
                            {
                                Console.WriteLine(ognie.TabelaWynikow());
                                Console.WriteLine("Wcisnij 1 by rozpocząć faze polfinalowa, 2 by wyswietlic historie rozgrywek, Esc by wyjsc"); input1 = Console.ReadKey();
                                while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.D2 && input1.Key != ConsoleKey.Escape)
                                {
                                    input1 = Console.ReadKey();
                                }
                                switch (input1.Key)
                                {
                                    case ConsoleKey.D1:
                                        try
                                        {
                                            ognie.GenerujPolFinal(sed);
                                            ognie.faza = 2;
                                        }
                                        catch (NotEnoughRefereesException )
                                        {
                                            Console.WriteLine("Niewystarczaja ilosc sedziow");
                                            dodajS(sed);
                                        }
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
                            if (ognie.faza == 2)
                            {
                                Console.WriteLine(ognie.TabelaWynikow());
                                Console.WriteLine("Wcisnij 1 by rozpocząć faze finalowa, 2 by wyswietlic historie rozgrywek, Esc by wyjsc"); input1 = Console.ReadKey();
                                while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.D2 && input1.Key != ConsoleKey.Escape)
                                {
                                    input1 = Console.ReadKey();
                                }
                                switch (input1.Key)
                                {
                                    case ConsoleKey.D1:
                                        try
                                        {
                                            ognie.GenerujFinal(sed);
                                            ognie.faza = 3;
                                        }
                                        catch (NotEnoughRefereesException )
                                        {
                                            Console.WriteLine("Niewystarczaja ilosc sedziow");
                                            dodajS(sed);
                                        }
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
                            if (ognie.faza == 3)
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
                            if (lina.faza == 0)
                            {
                                Console.WriteLine(lina.ToString());
                                Console.WriteLine("Nie zaczeto");
                                Console.WriteLine("Wcisnij 1 by rozpocząć faze grupowa, Esc by wyjsc");
                                input1 = Console.ReadKey();
                                while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.Escape)
                                {
                                    input1 = Console.ReadKey();
                                }
                                if (input1.Key == ConsoleKey.D1)
                                {
                                    try
                                    {
                                        lina.GenerujFazeGrupowa(sed);
                                        lina.faza = 1;
                                    }
                                    catch (NotEnoughRefereesException )
                                    {
                                        Console.WriteLine("Niewystarczaja ilosc sedziow");
                                        dodajS(sed);
                                    }
                                    catch (NotEnoughTeamsException)
                                    {
                                        Console.WriteLine("Niewystarczaja ilosc druzyn");
                                        #region dodaj druzyne
                                        Console.WriteLine("\nWpisz nazwe druzyny");
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

                                        Console.WriteLine("Dodano druzyne. Nacisnij dowolny klawisz by kontynuowac");
                                        Console.ReadKey();
                                        #endregion
                                    }
                                    Console.Clear(); ;
                                }
                            }
                            #endregion

                            #region po rozegraniu rozgrywek grupowych
                            //rozgrywka generuj pol final
                            if (lina.faza == 1)
                            {
                                Console.WriteLine(lina.TabelaWynikow());
                                Console.WriteLine("Wcisnij 1 by rozpocząć faze polfinalowa, 2 by wyswietlic historie rozgrywek, Esc by wyjsc"); input1 = Console.ReadKey();
                                while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.D2 && input1.Key != ConsoleKey.Escape)
                                {
                                    input1 = Console.ReadKey();
                                }
                                switch (input1.Key)
                                {
                                    case ConsoleKey.D1:
                                        try
                                        {
                                            lina.GenerujPolFinal(sed);
                                            lina.faza = 2;
                                        }
                                        catch (NotEnoughRefereesException )
                                        {
                                            Console.WriteLine("Niewystarczaja ilosc sedziow");
                                            dodajS(sed);
                                        }
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
                            if (lina.faza == 2)
                            {
                                Console.WriteLine(lina.TabelaWynikow());
                                Console.WriteLine("Wcisnij 1 by rozpocząć faze finalowa, 2 by wyswietlic historie rozgrywek, Esc by wyjsc"); input1 = Console.ReadKey();
                                while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.D2 && input1.Key != ConsoleKey.Escape)
                                {
                                    input1 = Console.ReadKey();
                                }
                                switch (input1.Key)
                                {
                                    case ConsoleKey.D1:
                                        try
                                        {
                                            lina.GenerujFinal(sed);
                                            lina.faza = 3;
                                        }
                                        catch (NotEnoughRefereesException )
                                        {
                                            Console.WriteLine("Niewystarczaja ilosc sedziow");
                                            dodajS(sed);
                                        }
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
                            if (lina.faza == 3)
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
                                        i = 1;
                                        foreach (Druzyna d in siatka.ListaDruzyn)
                                        {
                                            Console.WriteLine("Nr." + i);
                                            Console.WriteLine(d.ToString());
                                            i++;
                                        }
                                        if (siatka.faza < 1)
                                        {
                                            Console.WriteLine("Wpisz 1 by dodac druzyne, 2 by usunac druzyne, 3 by zmienic zawodnika w danej druzynie, Esc by wrocic");
                                            input1 = Console.ReadKey();
                                            while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.D2 && input1.Key != ConsoleKey.D3 && input1.Key != ConsoleKey.Escape)
                                            {
                                                input1 = Console.ReadKey();
                                            }
                                            switch (input1.Key)
                                            {
                                                case ConsoleKey.D1:

                                                    #region dodaj druzyne
                                                    Console.WriteLine("\nWpisz nazwe druzyny");
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

                                                    #region usun druzyne
                                                    Console.WriteLine("\nWpisz numer druzyny ktora chcesz usunac");
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
                                                case ConsoleKey.D3:

                                                    #region zmien zawodnika
                                                    Console.WriteLine("\nWpisz numer druzyny ktora w ktorej chcesz zmienic zawodnika");
                                                    inputINT = Int16.Parse(wczytajint());
                                                    while (inputINT > siatka.ListaDruzyn.Count || inputINT < 0)
                                                    {
                                                        Console.WriteLine("Niepoprawny numer. Wpisz ponownie");
                                                        inputINT = Int16.Parse(wczytajint());
                                                    }
                                                    Console.WriteLine("Wpisz numer zawodnika");
                                                    inputINT2 = Int16.Parse(wczytajint());
                                                    while (inputINT2 > 5 || inputINT2 < 0)
                                                    {
                                                        Console.WriteLine("Niepoprawny numer. Wpisz ponownie");
                                                        inputINT2 = Int16.Parse(wczytajint());
                                                    }
                                                    Console.WriteLine("Wpisz imie nowego zawodnika");
                                                    siatka.ListaDruzyn[inputINT - 1].Zawodnicy[inputINT2 - 1].Imie = Console.ReadLine();
                                                    Console.WriteLine("Wpisz imie nowego zawodnika");
                                                    siatka.ListaDruzyn[inputINT - 1].Zawodnicy[inputINT2 - 1].Nazwisko = Console.ReadLine();
                                                    Console.WriteLine("Wpisz imie nowego zawodnika");
                                                    siatka.ListaDruzyn[inputINT - 1].Zawodnicy[inputINT2 - 1].NrZawodnika = Int16.Parse(wczytajint());
                                                    Console.WriteLine("Zmieniono zawodnika. Nacisnij dowolny klawisz by wrocic");
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
                                        i = 1;
                                        foreach (Druzyna d in ognie.ListaDruzyn)
                                        {
                                            Console.WriteLine("Nr." + i);
                                            Console.WriteLine(d.ToString());
                                            i++;
                                        }
                                        if (ognie.faza < 1)
                                        {
                                            Console.WriteLine("Wpisz 1 by dodac druzyne, 2 by usunac druzyne, 3 by zmienic zawodnika w danej druzynie, Esc by wrocic");
                                            input1 = Console.ReadKey();
                                            while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.D2 && input1.Key != ConsoleKey.D3 && input1.Key != ConsoleKey.Escape)
                                            {
                                                input1 = Console.ReadKey();
                                            }
                                            switch (input1.Key)
                                            {
                                                case ConsoleKey.D1:

                                                    #region dodaj zawodnika
                                                    Console.WriteLine("\nWpisz nazwe druzyny");
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
                                                    Console.WriteLine("\nWpisz numer druzyny ktora chcesz usunac");
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
                                                case ConsoleKey.D3:

                                                    #region zmien zawodnika
                                                    Console.WriteLine("\nWpisz numer druzyny ktora w ktorej chcesz zmienic zawodnika");
                                                    inputINT = Int16.Parse(wczytajint());
                                                    while (inputINT > ognie.ListaDruzyn.Count || inputINT < 0)
                                                    {
                                                        Console.WriteLine("Niepoprawny numer. Wpisz ponownie");
                                                        inputINT = Int16.Parse(wczytajint());
                                                    }
                                                    Console.WriteLine("Wpisz numer zawodnika");
                                                    inputINT2 = Int16.Parse(wczytajint());
                                                    while (inputINT2 > 5 || inputINT2 < 0)
                                                    {
                                                        Console.WriteLine("Niepoprawny numer. Wpisz ponownie");
                                                        inputINT2 = Int16.Parse(wczytajint());
                                                    }
                                                    Console.WriteLine("Wpisz imie nowego zawodnika");
                                                    ognie.ListaDruzyn[inputINT - 1].Zawodnicy[inputINT2 - 1].Imie = Console.ReadLine();
                                                    Console.WriteLine("Wpisz imie nowego zawodnika");
                                                    ognie.ListaDruzyn[inputINT - 1].Zawodnicy[inputINT2 - 1].Nazwisko = Console.ReadLine();
                                                    Console.WriteLine("Wpisz imie nowego zawodnika");
                                                    ognie.ListaDruzyn[inputINT - 1].Zawodnicy[inputINT2 - 1].NrZawodnika = Int16.Parse(wczytajint());
                                                    Console.WriteLine("Zmieniono zawodnika. Nacisnij dowolny klawisz by wrocic");
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
                                        i = 1;
                                        foreach (Druzyna d in lina.ListaDruzyn)
                                        {
                                            Console.WriteLine("Nr." + i);
                                            Console.WriteLine(d.ToString());
                                            i++;
                                        }
                                        if (lina.faza < 1)
                                        {
                                            Console.WriteLine("Wpisz 1 by dodac druzyne, 2 by usunac druzyne, 3 by zmienic zawodnika w danej druzynie, Esc by wrocic");
                                            input1 = Console.ReadKey();
                                            while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.D2 && input1.Key != ConsoleKey.D3 && input1.Key != ConsoleKey.Escape)
                                            {
                                                input1 = Console.ReadKey();
                                            }
                                            switch (input1.Key)
                                            {
                                                case ConsoleKey.D1:

                                                    #region dodaj druzyne
                                                    Console.WriteLine("\nWpisz nazwe druzyny");
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

                                                    #region usun druzyne
                                                    Console.WriteLine("\nWpisz numer druzyny ktora chcesz usunac");
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
                                                case ConsoleKey.D3:

                                                    #region zmien zawodnika
                                                    Console.WriteLine("\nWpisz numer druzyny ktora w ktorej chcesz zmienic zawodnika");
                                                    inputINT = Int16.Parse(wczytajint());
                                                    while (inputINT > lina.ListaDruzyn.Count || inputINT < 0)
                                                    {
                                                        Console.WriteLine("Niepoprawny numer. Wpisz ponownie");
                                                        inputINT = Int16.Parse(wczytajint());
                                                    }
                                                    Console.WriteLine("Wpisz numer zawodnika");
                                                    inputINT2 = Int16.Parse(wczytajint());
                                                    while (inputINT2 > 5 || inputINT2 < 0)
                                                    {
                                                        Console.WriteLine("Niepoprawny numer. Wpisz ponownie");
                                                        inputINT2 = Int16.Parse(wczytajint());
                                                    }
                                                    Console.WriteLine("Wpisz imie nowego zawodnika");
                                                    lina.ListaDruzyn[inputINT - 1].Zawodnicy[inputINT2 - 1].Imie = Console.ReadLine();
                                                    Console.WriteLine("Wpisz imie nowego zawodnika");
                                                    lina.ListaDruzyn[inputINT - 1].Zawodnicy[inputINT2 - 1].Nazwisko = Console.ReadLine();
                                                    Console.WriteLine("Wpisz imie nowego zawodnika");
                                                    lina.ListaDruzyn[inputINT - 1].Zawodnicy[inputINT2 - 1].NrZawodnika = Int16.Parse(wczytajint());
                                                    Console.WriteLine("Zmieniono zawodnika. Nacisnij dowolny klawisz by wrocic");
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
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Lista Sedziow:");
                            i = 1;
                            foreach (Sedzia S in sed.GetListaSedziow())
                            {
                                Console.WriteLine(i +"." + S.Imie + " " + S.Nazwisko);
                                i++;
                            }
                            Console.WriteLine("Wcisnij 1 by dodac sedziego, 2 by usunac sedziego, Esc by wyjsc");
                            input1 = Console.ReadKey();
                            while (input1.Key != ConsoleKey.D1 && input1.Key != ConsoleKey.D2 && input1.Key != ConsoleKey.Escape)
                            {
                                input1 = Console.ReadKey();
                            }
                            switch (input1.Key)
                            {
                                case ConsoleKey.D1:

                                    #region dodaj sedziego
                                    Console.WriteLine("\nWpisz imie nowego sedziego");
                                    tmpS = new Sedzia("tmp", "tmp");
                                    tmpS.Imie = Console.ReadLine();
                                    Console.WriteLine("Wpisz nazwisko");
                                    tmpS.Nazwisko = Console.ReadLine();
                                    sed.DodajSedziego(tmpS);
                                    Console.WriteLine("Dodano sedziego. Nacisnij dowolny klawisz by wrocic");
                                    Console.ReadKey();
                                    #endregion

                                    break;
                                case ConsoleKey.D2:

                                    #region usun sedziego
                                    Console.WriteLine("\nWpisz imie sedziego ktora chcesz usunac");
                                    tmpS = new Sedzia("tmp", "tmp");
                                    tmpS.Imie = Console.ReadLine();
                                    Console.WriteLine("Wpisz nazwisko sedziego");
                                    tmpS.Nazwisko = Console.ReadLine();
                                    if (sed.UsunSedziego(tmpS.Imie, tmpS.Nazwisko))
                                    {
                                        Console.WriteLine("Usunieto sedziego. Nacisnij dowolny klawisz by wrocic");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nieznaleziono sedziego. Nacisnij dowolny klawisz by wrocic");
                                    }
                                    Console.ReadKey();
                                    #endregion

                                    break;
                                case ConsoleKey.Escape:
                                    break;
                            }
                        } while (input1.Key != ConsoleKey.Escape);
                        #endregion

                        break;
                    case ConsoleKey.Escape:

                        #region sekcja wyjdz z aplikacji
                        Console.Clear();
                        Console.WriteLine("Czy chcesz zapisac stan turnieju? \nY/N");
                        do
                        {
                            input1 = Console.ReadKey();
                        } while (input1.Key != ConsoleKey.Y && input1.Key != ConsoleKey.N);
                        //zapisz dane
                        if (input1.Key == ConsoleKey.Y)
                        {
                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("Podaj sciezke/nazwe pliku do zapisu stanu Turniejow");
                                    string sciezka = Console.ReadLine();
                                    List<Object> turnieje = new List<object>();
                                    turnieje.Add(siatka);
                                    turnieje.Add(ognie);
                                    turnieje.Add(lina);
                                    Plik.Zapisz(sciezka, turnieje);
                                    break;
                                }
                                catch (IOException e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                    break;
                                }
                            }
                        }

                        return;
                        #endregion
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

            #endregion
        }
    }
}
