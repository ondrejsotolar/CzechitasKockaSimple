using System;
using System.Windows;

namespace KockaSimple
{
    public partial class MainWindow : Window
    {
        private KockaData kockaData;

        public MainWindow()
        {
            InitializeComponent();
            InicializujPopisky();

            kockaData = new KockaData();
        }

        private void InicializujPopisky()
        {
            lblPocetTydnu.Content = KockaPopisky.PocetTydnuCS;
            lblPocetKocek.Content = KockaPopisky.PocetKocekCS;
            lblMnozstviMasaNaKocku.Content = KockaPopisky.MnozstviMasaNaKockuCS;
            btnSpocitejVysledek.Content = KockaPopisky.VypocitejVysledekCS;
        }

        private void BtnSpocitejVysledek_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                kockaData.PocetTydnu = int.Parse(txtPocetTydnu.Text);
                kockaData.PocetKocek = int.Parse(txtPocetKocek.Text);
                kockaData.MnozstviMasaNaKocku = int.Parse(txtMnozstviMasaNaKocku.Text);
            }
            catch (FormatException)
            {
                lblVystup.Content = KockaPopisky.SpatnyFormatCS;
                return;
            }

            lblVystup.Content = string.Format(
                KockaPopisky.VysledekZpravaCS, kockaData.PocetTydnu, kockaData.VypoctiSpotrebuMasa());
        }
    }
}
