using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projekt.Exceptions;

namespace Projekt.UnitTests
{
    [TestClass]
    public class TurniejTests
    {
        [TestMethod]
        public void DodajDruzyneDoTurniejuTest()
        {
            Turniej turniej = new Turniej("przeciaganie liny");
            //sprawdzenie czy liczba druzyn przed dodaniem wynosi 0
            Assert.AreEqual(turniej.ListaDruzyn.Count, 0);

            dodajDruzynyDoTurnieju(1, turniej);
            
            //sprawdzenie czy liczba druzyn po dodaniu wynosi 1
            Assert.AreEqual(turniej.ListaDruzyn.Count, 1);
            
            //sprawdzenie czy nazwa dodanej druzyny jest taka sama
            Assert.AreEqual(turniej.ListaDruzyn[0].NazwaDruzyny, "druzyna0");
        }

        
        [TestMethod]
        public void UsunDruzyneZTurniejuTest()
        {
            var turniej = turniejZDruzynami("przeciaganie liny", 1);

            //sprawdzenie czy liczba druzyn po dodaniu wynosi 1
            Assert.AreEqual(turniej.ListaDruzyn.Count, 1);
            
            turniej.UsunDruzyne(turniej.ListaDruzyn[0]);
            
            //sprawdzenie czy liczba druzyn przed dodaniem wynosi 0
            Assert.AreEqual(turniej.ListaDruzyn.Count, 0);
        }

        
        [TestMethod]
        public void DodajTurniejZeZlaNazwaTest_ShouldThrowIncorrectSportNameException()
        {
            //sprawdzenie czy utowrzenie nowego turnieju z niepoprawnym sportem wyrzuca wyjatek
            Assert.ThrowsException<IncorrectSportNameException>(() => new Turniej("pilka nozna"));
        }

        
        [TestMethod]
        public void GenerowanieFinaluTest()
        {
            var turniej = turniejZDruzynami("przeciaganie liny", 2);

            Sedzia s1 = new Sedzia("S1", "G1");
            Sedzia s2 = new Sedzia("P1", "p1");
            Sedzia s3 = new Sedzia("P2", "p2");

            Sedziowie sad1 = new Sedziowie();

            sad1.DodajSedziego(s1);
            sad1.DodajSedziego(s2);
            sad1.DodajSedziego(s3);

            turniej.GenerujFinal(sad1);

            var druzyna1 = turniej.ListaDruzyn[0];
            var druzyna2 = turniej.ListaDruzyn[1];

            //sprawdzenie czy wynik druzyny1 w finale rowna sie 0 lub 1
            Assert.IsTrue(druzyna1.WynikPrzeciaganieLiny == 0 || druzyna1.WynikPrzeciaganieLiny == 1);

            //sprawdzenie czy wynik druzyny2 w finale rowna sie 0 lub 1
            Assert.IsTrue(druzyna2.WynikPrzeciaganieLiny == 0 || druzyna2.WynikPrzeciaganieLiny == 1);

            //sprawdzenie czy wyniki obu druzyn sa rozne
            Assert.AreNotEqual(druzyna1.WynikPrzeciaganieLiny, druzyna2.WynikPrzeciaganieLiny);
        }

        
        [TestMethod]
        public void GenerowaniePolFinaluBezSedziow_ShouldThrowNotEnoughRefereesException()
        {
            var turniej = turniejZDruzynami("przeciaganie liny", 4);

            Sedziowie sad1 = new Sedziowie();

            //sprawdzenie czy proba wygenerowania polfianlu bez sedziow wyrzuci wyjatek
            Assert.ThrowsException<NotEnoughRefereesException>(() => turniej.GenerujPolFinal(sad1));
        }

        
        private static Turniej turniejZDruzynami(string nazwaSportu, int iloscDruzyn)
        {
            Turniej turniej = new Turniej(nazwaSportu);

            dodajDruzynyDoTurnieju(iloscDruzyn, turniej);

            return turniej;
        }

        
        private static void dodajDruzynyDoTurnieju(int iloscDruzyn, Turniej turniej)
        {
            char c = 'A';
            for (int i = 0; i < iloscDruzyn; i++)
            {
                Druzyna druzyna = new Druzyna("druzyna" + i);

                for (int j = 0; j < 5; j++, c++)
                {
                    if (c == '[') c = 'a';

                    druzyna.DodajZawodnika(new Zawodnik(c.ToString(), (++c).ToString(), j + i * 5));
                }

                turniej.DodajDruzyne(druzyna);
            }
        }
    }
}