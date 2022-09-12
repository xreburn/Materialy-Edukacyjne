using System;
using System.Collections.Generic;
using System.Linq;

namespace LEARNING
{
    public class Program
    {
        static void Main()
        {
            var uczen1 = new Uczen();
            uczen1.imie = "Krzysztof";
            uczen1.nazwisko = "Jasinski";
            uczen1.inteligencja = 10;
            uczen1.zwinnosc = 7;
            uczen1.pkt_zachowania = 150;
            uczen1.id_ucznia = 1;

            var uczen2 = new Uczen();
            uczen2.imie = "Adam";
            uczen2.nazwisko = "Kowalski";
            uczen2.inteligencja = 140;
            uczen2.zwinnosc = 8;
            uczen2.pkt_zachowania = 120;
            uczen2.id_ucznia = 2;

            var uczen3 = new Uczen();
            uczen3.imie = "Janusz";
            uczen3.nazwisko = "Nowak";
            uczen3.inteligencja = 90;
            uczen3.zwinnosc = 10;
            uczen3.pkt_zachowania = 60;
            uczen3.id_ucznia = 3;

            var uczen4 = new Uczen();
            uczen4.imie = "Robert";
            uczen4.nazwisko = "Lewandowski";
            uczen4.inteligencja = 120;
            uczen4.zwinnosc = 10;
            uczen4.pkt_zachowania = 180;
            uczen4.id_ucznia = 4;

            var uczen5 = new Uczen();
            uczen5.imie = "Pawel";
            uczen5.nazwisko = "Sobieraj";
            uczen5.inteligencja = 80;
            uczen5.zwinnosc = 4;
            uczen5.pkt_zachowania = 40;
            uczen5.id_ucznia = 5;

            var klasa1 = new Klasa();
            var klasa2 = new Klasa();
            var klasa3 = new Klasa();

            klasa1.dodajUcznia(uczen1);
            klasa1.dodajUcznia(uczen4);
            klasa2.dodajUcznia(uczen2);
            klasa2.dodajUcznia(uczen5);
            klasa3.dodajUcznia(uczen3);

            var szkola1 = new Szkola();

            szkola1.dodajKlase(klasa1);
            szkola1.dodajKlase(klasa2);
            szkola1.dodajKlase(klasa3);

            List<Szkola> listaSzkol = new List<Szkola>();

            Console.WriteLine("Witamy w bazie danych szkoly!");
            Console.WriteLine(" ");


            Console.WriteLine("Uczniowe klasy 1: ");
            foreach(Uczen uczen in klasa1.listaUczniow)
            {
                Console.WriteLine(uczen.imie + " " + uczen.nazwisko);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Srednia inteligencja klasy 1 wynosi: " + klasa1.ObliczSredniaInteligencjiKlasa());
            Console.WriteLine("Srednia punktow zachowania klasy 1 wynosi: " + klasa1.ObliczSredniaZachowaniaKlasa());
            Console.WriteLine("Srednia punktow zwinnosc klasy 1 wynosi: " + klasa1.ObliczSredniaZwinnosciKlasa());
            Console.WriteLine("Suma punktow zachowania klasy 1 wynosi: " + klasa1.ObliczSumaZachowaniaKlasa());
            Console.WriteLine("________________________________________________");
            Console.WriteLine(" ");

            Console.WriteLine("Uczniowe klasy 2: ");
            foreach (Uczen uczen in klasa2.listaUczniow)
            {
                Console.WriteLine(uczen.imie + " " + uczen.nazwisko);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Srednia inteligencja klasy 2 wynosi: " + klasa2.ObliczSredniaInteligencjiKlasa());
            Console.WriteLine("Srednia punktow zachowania klasy 2 wynosi: " + klasa2.ObliczSredniaZachowaniaKlasa());
            Console.WriteLine("Srednia punktow zwinnosc klasy 2 wynosi: " + klasa2.ObliczSredniaZwinnosciKlasa());
            Console.WriteLine("Suma punktow zachowania klasy 2 wynosi: " + klasa2.ObliczSumaZachowaniaKlasa());
            Console.WriteLine("________________________________________________");
            Console.WriteLine(" ");

            Console.WriteLine("Uczniowe klasy 3: ");
            foreach (Uczen uczen in klasa3.listaUczniow)
            {
                Console.WriteLine(uczen.imie + " " + uczen.nazwisko);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Srednia inteligencja klasy 3 wynosi: " + klasa3.ObliczSredniaInteligencjiKlasa());
            Console.WriteLine("Srednia punktow zachowania klasy 3 wynosi: " + klasa3.ObliczSredniaZachowaniaKlasa());
            Console.WriteLine("Srednia punktow zwinnosc klasy 3 wynosi: " + klasa3.ObliczSredniaZwinnosciKlasa());
            Console.WriteLine("Suma punktow zachowania klasy 3 wynosi: " + klasa3.ObliczSumaZachowaniaKlasa());
            Console.WriteLine("________________________________________________");
            Console.WriteLine(" ");

            Console.WriteLine("Srednia inteligencja wszystkich klas wynosi " + (klasa1.ObliczSredniaInteligencjiKlasa() + klasa2.ObliczSredniaInteligencjiKlasa() + klasa3.ObliczSredniaInteligencjiKlasa())/3);
            Console.WriteLine("Srednia punktow zachowania wszystkich klas wynosi " + (klasa1.ObliczSredniaZachowaniaKlasa() + klasa2.ObliczSredniaZachowaniaKlasa() + klasa3.ObliczSredniaZachowaniaKlasa()) / 3);
            Console.WriteLine("Srednia zwinnosc wszystkich klas wynosi " + (klasa1.ObliczSredniaZwinnosciKlasa() + klasa2.ObliczSredniaZwinnosciKlasa() + klasa3.ObliczSredniaZwinnosciKlasa()) / 3);
            Console.WriteLine("Suma punktow zachowania wszystkich klas wynosi " + (klasa1.ObliczSumaZachowaniaKlasa() + klasa2.ObliczSumaZachowaniaKlasa() + klasa3.ObliczSumaZachowaniaKlasa()));






        }
    }
    public class Uczen
    {
        public string? imie;
        public string? nazwisko;
        public int inteligencja;
        public int zwinnosc;
        public int pkt_zachowania;
        public int id_ucznia;
    }
    public class Klasa
    {
        public List<Uczen> listaUczniow = new List<Uczen>();
        public void dodajUcznia(Uczen uczen)
        {
            listaUczniow.Add(uczen);
        }

        public float ObliczSredniaInteligencjiKlasa()
        {
            float srednia_int_klasy = 0;
            int i = 0;
            for (i = 0; i < listaUczniow.Count; i++) 
            {
                srednia_int_klasy += listaUczniow[i].inteligencja;
            }
            srednia_int_klasy /= listaUczniow.Count;
            return srednia_int_klasy;

        }

        public float ObliczSredniaZwinnosciKlasa()
        {
            float srednia_zwin_klasy = 0;
            int i = 0;
            for (i = 0; i < listaUczniow.Count; i++)
            {
                srednia_zwin_klasy += listaUczniow[i].zwinnosc;
            }
            srednia_zwin_klasy /= listaUczniow.Count;
            return srednia_zwin_klasy;
        }

        public float ObliczSumaZachowaniaKlasa()
        {
            float suma_pkt_klasy = 0;
            int i = 0;
            for (i = 0; i < listaUczniow.Count; i++)
            {
                suma_pkt_klasy += listaUczniow[i].inteligencja;
            }
            return suma_pkt_klasy;
        }
        public float ObliczSredniaZachowaniaKlasa()
        {
            float srednia_pkt_klasy = 0;
            int i = 0;
            for (i = 0; i < listaUczniow.Count; i++)
            {
                srednia_pkt_klasy += listaUczniow[i].pkt_zachowania;
            }
            srednia_pkt_klasy /= listaUczniow.Count;
            return srednia_pkt_klasy;
        }

    }
    public class Szkola
    {
        public List<Klasa> listaKlas = new List<Klasa>();
        public void dodajKlase(Klasa klasa)
        {
            listaKlas.Add(klasa);
        }

        public float ObliczSredniaInteligencjiSzkola()
        {
            float srednia_int_szkoly = 0;
            int i = 0;
            for (i = 0; i < listaKlas.Count; i++)
            {
                srednia_int_szkoly += listaKlas[i].ObliczSredniaInteligencjiKlasa();
            }
            srednia_int_szkoly /= listaKlas.Count;
            return srednia_int_szkoly;
        }
        public float ObliczSredniaZwinnoscSzkola()
        {
            float srednia_zwin_szkoly = 0;
            int i = 0;
            for (i = 0; i < listaKlas.Count; i++)
            {
                srednia_zwin_szkoly += listaKlas[i].ObliczSredniaZwinnosciKlasa();
            }
            srednia_zwin_szkoly /= listaKlas.Count;
            return srednia_zwin_szkoly;
        }
        public float ObliczSumaZachowaniaSzkoly()
        {
            float suma_pkt_szkoly = 0;
            int i = 0;
            for (i = 0; i < listaKlas.Count; i++)
            {
                suma_pkt_szkoly += listaKlas[i].ObliczSumaZachowaniaKlasa();
            }
            return suma_pkt_szkoly;
        }
    }
}
