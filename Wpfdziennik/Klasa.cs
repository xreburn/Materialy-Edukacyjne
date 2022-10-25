using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpfdziennik
{
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


        public string profil;
    }
}
