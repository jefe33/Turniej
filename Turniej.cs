using System;
using System.Collections.Generic;

namespace Projekt
{
    [Serializable]
    public class Turniej
    {
        private string nazwaSportu;
        private List<Druzyna> listaDruzyn;
        private List<Rozgrywka> listaRozgrywek;
        public Turniej(string nazwaSportu) 
        {
            //Wyjatek sprawdzajacy czy nazwa sportu to siatkowka/2ognie/przeciaganie liny
            this.nazwaSportu = nazwaSportu;
            listaDruzyn = new List<Druzyna>();
            listaRozgrywek = new List<Rozgrywka>();
        }
        public override string ToString()
        {
            string napis = $"Turniej {nazwaSportu}\nLista Druzyn bioracych aktualnie udzial w turnieju:\n";
            foreach (Druzyna d in listaDruzyn)
                napis += d.NazwaDruzyny+"\n";
            napis += "\nLista Rozgrywek:\n";
            foreach (Rozgrywka r in listaRozgrywek)
                napis += r+"\n\n"; //napis += r.ToString()+"\n\n";
            return napis;
        }
        public void DodajDruzyne(Druzyna nowaDruzyna) 
        { 
            listaDruzyn.Add(nowaDruzyna); 
        }
        public bool UsunDruzyne(Druzyna druzynaDoUsuniecia)
        {
            return listaDruzyn.Remove(druzynaDoUsuniecia);
        }
        public void DodajRozgrywke(Druzyna druzynaA, Druzyna druzynaB, Sedzia sedziaGlowny, int wynik)
        {
            //Wyjatek sprawdzajacy czy nazwa sporu to 2ognie albo przeciaganie liny
            listaRozgrywek.Add(new Rozgrywka(druzynaA, druzynaB, sedziaGlowny, wynik));
            //Wyjatek sprawdzajacy czy wynik jest rowny 0 albo 1
            if(nazwaSportu.ToLower() == "2ognie")
            {
                if (wynik == 1)
                    druzynaA.Wynik2Ognie++;
                else
                    druzynaB.Wynik2Ognie++;
            }
            else if(nazwaSportu.ToLower() == "przeciaganie liny")
            {
                if (wynik == 1)
                    druzynaA.WynikPrzeciaganieLiny++;
                else
                    druzynaB.WynikPrzeciaganieLiny++;
            }
        }
        public void DodajRozgrywkeSiatkowki(Druzyna druzynaA, Druzyna druzynaB, Sedzia sedziaGlowny, Sedzia sedziaPomocniczy1, Sedzia sedziaPomocniczy2, int wynik)
        {
            //Wyjatek sprawdzajacy czy nazwa sporu to siatkowka
            listaRozgrywek.Add(new RozgrywkaSiatkowki(druzynaA, druzynaB, sedziaGlowny, sedziaPomocniczy1, sedziaPomocniczy2, wynik));
            //Wyjatek sprawdzajacy czy wynik jest rowny 0 albo 1
            if (wynik == 1)
                druzynaA.WynikSiatkowka++;
            else
                druzynaB.WynikSiatkowka++;
        }
        public void GenerujFazeGrupowa(Sedziowie dostepniSedziowie) //Zmiana wzgledem diagramu UML dodalem parametr Sedziowie, bo byl potrzebny
        {
            var rand = new Random();
            if (nazwaSportu.ToLower() != "siatkowka")
                for (int i=0; i < listaDruzyn.Count-1; i++)
                    for (int j=i+1; j < listaDruzyn.Count; j++)
                        DodajRozgrywke(listaDruzyn[i], listaDruzyn[j], dostepniSedziowie.WybierzLosowegoSedziego(), rand.Next(2));
            else
                for (int i=0; i < listaDruzyn.Count-1; i++)
                    for (int j=i+1; j < listaDruzyn.Count; j++)
                        DodajRozgrywkeSiatkowki(listaDruzyn[i], listaDruzyn[j], dostepniSedziowie.WybierzLosowegoSedziego(), dostepniSedziowie.WybierzLosowegoSedziego(), dostepniSedziowie.WybierzLosowegoSedziego(), rand.Next(2));
        }
        public void GenerujPolFinal(Sedziowie dostepniSedziowie) //Zmiana wzgledem diagramu UML dodalem parametr Sedziowie, bo byl potrzebny
        {
            SortujListeDruzyn();
            var rand = new Random();
            //Wyjatek sprawdzajacy czy sa przynajmniej 4 druzyny na liscie
            while (listaDruzyn.Count > 4) //wersja mocno uproszczona usuwajaca druzyny z konca rankingu (brak dogrywek jesli druzyny mialy tyle samo punktow na np. 4 i 5 miejscu)
            {
                listaDruzyn.Remove(listaDruzyn[listaDruzyn.Count-1]);
            }
            //Wyzerowanie wynikow druzyn finalowej czworki
            WyzerowanieWynikowDruzyn();
            //Tworzenie meczy polfinalowych
            if (nazwaSportu.ToLower() != "siatkowka")
            {
                DodajRozgrywke(listaDruzyn[0], listaDruzyn[3], dostepniSedziowie.WybierzLosowegoSedziego(), rand.Next(2));
                DodajRozgrywke(listaDruzyn[1], listaDruzyn[2], dostepniSedziowie.WybierzLosowegoSedziego(), rand.Next(2));
            }
            else if(nazwaSportu.ToLower() == "siatkowka")
            {
                DodajRozgrywkeSiatkowki(listaDruzyn[0], listaDruzyn[3], dostepniSedziowie.WybierzLosowegoSedziego(), dostepniSedziowie.WybierzLosowegoSedziego(), dostepniSedziowie.WybierzLosowegoSedziego(), rand.Next(2));
                DodajRozgrywkeSiatkowki(listaDruzyn[1], listaDruzyn[2], dostepniSedziowie.WybierzLosowegoSedziego(), dostepniSedziowie.WybierzLosowegoSedziego(), dostepniSedziowie.WybierzLosowegoSedziego(), rand.Next(2));
            }
        }
        public void GenerujFinal(Sedziowie dostepniSedziowie) //Zmiana wzgledem diagramu UML dodalem parametr Sedziowie, bo byl potrzebny
        {
            SortujListeDruzyn();
            while (listaDruzyn.Count > 2)
                listaDruzyn.Remove(listaDruzyn[listaDruzyn.Count - 1]);
            WyzerowanieWynikowDruzyn();
            var rand = new Random();
            if (nazwaSportu.ToLower() != "siatkowka")
                DodajRozgrywke(listaDruzyn[0], listaDruzyn[1], dostepniSedziowie.WybierzLosowegoSedziego(), rand.Next(2));
            else if (nazwaSportu.ToLower() == "siatkowka")
                DodajRozgrywkeSiatkowki(listaDruzyn[0], listaDruzyn[1], dostepniSedziowie.WybierzLosowegoSedziego(), dostepniSedziowie.WybierzLosowegoSedziego(), dostepniSedziowie.WybierzLosowegoSedziego(), rand.Next(2));
        }
        public string TabelaWynikow() //Zmiana wzgledem diagramu UML usunalem parametr, bo nie jest portrzebny
        { //Tabela wynikow pokazuje aktualna ilosc wygranych druzyn, poniewaz ilosc wygranych sie zeruje w polfinale, bedzie trzeba w interfejsie robic jej kopie albo cos
            SortujListeDruzyn();
            string napis = $"Sport: {nazwaSportu}\nNazwa Druzyny:               wynik:\n";
            foreach (Druzyna d in listaDruzyn)
            {
                napis += $"{d.NazwaDruzyny,-30} ";
                if (nazwaSportu.ToLower() == "2ognie")
                    napis += $"{d.Wynik2Ognie}\n";
                if (nazwaSportu.ToLower() == "przeciaganie liny")
                    napis += $"{d.WynikPrzeciaganieLiny}\n";
                if (nazwaSportu.ToLower() == "siatkowka")
                    napis += $"{d.WynikSiatkowka}\n";
            }
            return napis;
        }
        
        private void SortujListeDruzyn()
        {
            if (nazwaSportu.ToLower() == "2ognie")
                listaDruzyn.Sort(CompareDruzynyByWynik2ognie);
            else if (nazwaSportu.ToLower() == "przeciaganie liny")
                listaDruzyn.Sort(CompareDruzynyByWynikPrzeciaganieLiny);
            else if (nazwaSportu.ToLower() == "siatkowka")
                listaDruzyn.Sort(CompareDruzynyByWynikSiatkowka);
        }

        private void WyzerowanieWynikowDruzyn()
        {
            for (int i = 0; i < listaDruzyn.Count; i++)
            {
                if (nazwaSportu.ToLower() == "2ognie")
                    listaDruzyn[i].Wynik2Ognie = 0;
                else if (nazwaSportu.ToLower() == "przeciaganie liny")
                    listaDruzyn[i].WynikPrzeciaganieLiny = 0;
                else if (nazwaSportu.ToLower() == "siatkowka")
                    listaDruzyn[i].WynikSiatkowka = 0;
            }
        }

        //Ponizsze metody sa potrzebne do sortowania bo metoda Sort() przyjmuje jako parametr metode porownujaca dwa obiekty
        private static int CompareDruzynyByWynik2ognie(Druzyna druzynaA, Druzyna druzynaB)
        {
            if (druzynaA == null)
            {
                if (druzynaB == null)
                    return 0;
                else
                    return -1;
            }
            else
            {
                if (druzynaB == null)
                    return 1;
                else
                    return druzynaB.Wynik2Ognie - druzynaA.Wynik2Ognie;
            }
        }
        private static int CompareDruzynyByWynikPrzeciaganieLiny(Druzyna druzynaA, Druzyna druzynaB)
        {
            if (druzynaA == null)
            {
                if (druzynaB == null)
                    return 0;
                else
                    return -1;
            }
            else
            {
                if (druzynaB == null)
                    return 1;
                else
                    return druzynaB.WynikPrzeciaganieLiny - druzynaA.WynikPrzeciaganieLiny;
            }
        }
        private static int CompareDruzynyByWynikSiatkowka(Druzyna druzynaA, Druzyna druzynaB)
        {
            if (druzynaA == null)
            {
                if (druzynaB == null)
                    return 0;
                else
                    return -1;
            }
            else
            {
                if (druzynaB == null)
                    return 1;
                else
                    return druzynaB.WynikSiatkowka - druzynaA.WynikSiatkowka;
            }
        }
    }
}
