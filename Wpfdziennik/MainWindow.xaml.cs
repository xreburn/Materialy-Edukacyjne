using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpfdziennik
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Szkola> listaSzkol = new List<Szkola>();
        public MainWindow()
        {
            InitializeComponent();
            var uczen1 = new Uczen("Krzysztof","Jasiński","M",1,10,7,1);

            var uczen2 = new Uczen("Adam","Kowalski","M",2,140,8,2);

            var uczen3 = new Uczen("Blażej", "Kowalski", "M", 3, 145, 6, 3);

            var uczen4 = new Uczen("Stanislaw", "Kowalski", "M", 2, 130, 1, 7);

            var uczen5 = new Uczen("Pawel", "Sobieraj", "M", 1, 140, 4, 2);


            var klasa1 = new Klasa();
            klasa1.profil = "informatyk";
            var klasa2 = new Klasa();
            klasa2.profil = "programista";
            var klasa3 = new Klasa();
            klasa3.profil = "teleinformatyk";

            klasa1.dodajUcznia(uczen1);
            klasa1.dodajUcznia(uczen4);
            klasa2.dodajUcznia(uczen2);
            klasa2.dodajUcznia(uczen5);
            klasa3.dodajUcznia(uczen3);

            var szkola1 = new Szkola("szkola1");
            var szkola2 = new Szkola("szkola2");



            szkola1.dodajKlase(klasa1);
            szkola1.dodajKlase(klasa2);
            szkola1.dodajKlase(klasa3);

            listaSzkol.Add(szkola1);
            listaSzkol.Add(szkola2);

            ListBox1.ItemsSource = listaSzkol;


        }

        private void ListBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                Szkola s = ListBox1.SelectedItem as Szkola;
                ListBox2.ItemsSource = s.listaKlas;
            }
            TB.Text = "";
            ListBox3.ItemsSource = null;

        }

        private void ListBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                Klasa k = ListBox2.SelectedItem as Klasa;
                ListBox3.ItemsSource = k.listaUczniow;
            }
            TB.Text = "";
        }

        private void ListBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                Uczen u = ListBox3.SelectedItem as Uczen;
                TB.Text = u.DajDane();
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
