using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpfdziennik
{
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

        public string nazwaSzkoly;

        public Szkola(string nazwaSzkoly)
        {
            this.nazwaSzkoly = nazwaSzkoly;

        }



    }
}
