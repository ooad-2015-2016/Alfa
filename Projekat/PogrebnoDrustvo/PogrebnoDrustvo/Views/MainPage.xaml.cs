using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using PogrebnoDrustvo.Database.Models;
using PogrebnoDrustvo.Views;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PogrebnoDrustvo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        //Korisnik2 f = new Korisnik2();
        //this.Content = f;
        //FormaPreminuli fp = new FormaPreminuli();
        //this.Content = fp;

        private List<Oprema> listaopreme;

        public MainPage()
        { 
            this.InitializeComponent();

             
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //Korisnik2 f = new Korisnik2();
            //this.Content = f;
            //FormaPreminuli fp = new FormaPreminuli();
            //this.Content = fp;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            FormaIzvjestaj izvjestaj = new FormaIzvjestaj();
            this.Content = izvjestaj;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Cjenovnik cj = new Cjenovnik();
            this.Content = cj;
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {
        }

        private void buttonPrijava_Click(object sender, RoutedEventArgs e)
        {

            FormaPreminuli fp = new FormaPreminuli();
            this.Content = fp;
        }

        private void buttonRegistracija_Click(object sender, RoutedEventArgs e)
        {
            FormaKorisnik fk = new FormaKorisnik();
            this.Content = fk;    
        }
    }
}
