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
    public sealed partial class FormaUnosPredsjednik : Page
    {
        public FormaUnosPredsjednik()
        {
            this.InitializeComponent();
            textBoxUsername.Text = GlobalneVarijable.korickoIme;
            textBoxPassword.Text = GlobalneVarijable.lozinka;
        }

        private void buttonOtkazi_Click(object sender, RoutedEventArgs e)
        {
            MainPage mp = new MainPage();
            this.Content = mp;
        }

        private void buttonUnosPredsjednika_Click(object sender, RoutedEventArgs e)
        {

            //nakon provjere podataka
            GlobalneVarijable.imaPredsjednik = true;

            GlobalneVarijable.korickoIme = textBoxUsername.Text;
            GlobalneVarijable.lozinka = textBoxPassword.Text;

            MainPage mp = new MainPage();
            this.Content = mp;
        }
    }
}
