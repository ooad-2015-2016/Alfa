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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PogrebnoDrustvo.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FormaPredsjednik : Page
    {
        public FormaPredsjednik()
        {
            this.InitializeComponent();
        }

        private void buttonUnosZaposlenika_Click(object sender, RoutedEventArgs e)
        {
            FormaUnosUposlenik fuu = new FormaUnosUposlenik();
            this.Content = fuu;
        }

        private void buttonUnosMenadera_Click(object sender, RoutedEventArgs e)
        {
            FormaUnosMenađera fum = new FormaUnosMenađera();
            this.Content = fum;
        }

        private void buttonIzvjestaj_Click(object sender, RoutedEventArgs e)
        {
            FormaIzvjestaj fi = new FormaIzvjestaj();
            this.Content = fi;
        }

        private void buttonOdjava_Click(object sender, RoutedEventArgs e)
        {
            MainPage mp = new MainPage();
            this.Content = mp;
        }

        private void buttonPromjenaLozinke_Click(object sender, RoutedEventArgs e)
        {
            /*//nakon provjere
            GlobalneVarijable.lozinka = PassPotvrdaPass.Password;

            PassNoviPass.Password = "";
            PassStariPass.Password = "";
            PassPotvrdaPass.Password = "";*/

        }
    }
}
