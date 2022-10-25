using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Wpfdziennik
{
    public class Uczen 
    {
        public string imie;
        public string nazwisko;
        public string plec;
        public int inteligencja;
        public int nr;
        public int zwinnosc;
        public int id_ucznia;

        public Uczen(string imie, string nazwisko, string plec, int inteligencja, int nr, int zwinnosc, int id_ucznia)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.plec = plec;
            this.inteligencja = inteligencja;
            this.nr = nr;
            this.zwinnosc = zwinnosc;
            this.id_ucznia = id_ucznia;
        }

        public string DajDane()
        {
            string Output = "";
            Output += "Imie: " + this.imie + "\n";
            Output += "Nazwisko: " + this.nazwisko + "\n";
            Output += "Płeć: " + this.plec + "\n";
            Output += "IQ: " + this.inteligencja + "\n";
            Output += "Nr: " + this.nr + "\n";
            Output += "Zwinność: " + this.zwinnosc + "\n";
            Output += "ID: " + this.id_ucznia + "\n";

            return Output;
        }
        
    }
}
