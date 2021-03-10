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

namespace PrezzoQuantitàWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMostra_Click(object sender, RoutedEventArgs e)
        {
            int sco;
            if (txtSconto.Text != "")
                sco = int.Parse(txtSconto.Text);
            else
                sco = 0;
            
                if (sco < 0 || sco > 100)
                {
                    MessageBox.Show("Sconto al difuori dei limiti", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    if (txtQuantita.Text != "" && txtPrezzo.Text != "")
                    {


                        try
                        {
                            double p = double.Parse(txtPrezzo.Text);
                            int q = int.Parse(txtQuantita.Text);
                            double tot = p * q;
                            if (txtSconto.Text == "" || sco < 20)
                            {
                                lblRisultato.Content = tot;
                            }
                            else
                            {
                                double sconto = (tot * sco) / 100;
                                double prezzo_scontato = tot - sconto;
                                lblRisultato.Content = prezzo_scontato;
                            }

                        }
                        catch (Exception ex)
                        {
                            lblRisultato.Content = ex.Message;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Devi compilare tutti i campi", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }

            }
        }
    }




