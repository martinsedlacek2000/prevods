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

namespace prevod
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float number1 = 0;
        long zadana = 0;
        float centimetry = 0;
        long vysledna = 0;
        float vysledek = 0;
        


        public MainWindow()
        {
            InitializeComponent();
            zadana = cmbZadana.SelectedIndex;
            
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            vysledna = cmbVysledna.SelectedIndex;
            zadana = cmbZadana.SelectedIndex;
            number1 = (number1 * 10) + 1;
            txtDisplay.Text = number1.ToString();
            if(zadana==0)
            {
                centimetry = number1 / 10;
            }
            if (zadana == 1)
            {
                centimetry = number1;
            }
            if (zadana == 2)
            {
                centimetry = number1 * 10;
            }
            if (zadana == 3)
            {
                centimetry = number1 * 100;
            }
            if (zadana == 4)
            {
                centimetry = number1 * 100000;
            }
            
            if(vysledna==0)
            {
                vysledek = centimetry * 10;
            }
            if (vysledna == 1)
            {
                vysledek = centimetry;
            }
            if (vysledna == 2)
            {
                vysledek = centimetry / 10;
            }
            if (vysledna == 3)
            {
                vysledek = centimetry / 100;
            }
            if (vysledna == 4)
            {
                vysledek = centimetry / 100000;
            }


            txtDisplay2.Text = vysledek.ToString();

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            vysledna = cmbVysledna.SelectedIndex;
            zadana = cmbZadana.SelectedIndex;
            number1 = (number1 * 10) + 2;
            txtDisplay.Text = number1.ToString();
            if (zadana == 0)
            {
                centimetry = number1 / 10;
            }
            if (zadana == 1)
            {
                centimetry = number1;
            }
            if (zadana == 2)
            {
                centimetry = number1 * 10;
            }
            if (zadana == 3)
            {
                centimetry = number1 * 100;
            }
            if (zadana == 4)
            {
                centimetry = number1 * 100000;
            }

            if (vysledna == 0)
            {
                vysledek = centimetry * 10;
            }
            if (vysledna == 1)
            {
                vysledek = centimetry;
            }
            if (vysledna == 2)
            {
                vysledek = centimetry / 10;
            }
            if (vysledna == 3)
            {
                vysledek = centimetry / 100;
            }
            if (vysledna == 4)
            {
                vysledek = centimetry / 100000;
            }


            txtDisplay2.Text = vysledek.ToString();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            vysledna = cmbVysledna.SelectedIndex;
            zadana = cmbZadana.SelectedIndex;
            number1 = (number1 * 10) + 3;
            txtDisplay.Text = number1.ToString();
            if (zadana == 0)
            {
                centimetry = number1 / 10;
            }
            if (zadana == 1)
            {
                centimetry = number1;
            }
            if (zadana == 2)
            {
                centimetry = number1 * 10;
            }
            if (zadana == 3)
            {
                centimetry = number1 * 100;
            }
            if (zadana == 4)
            {
                centimetry = number1 * 100000;
            }

            if (vysledna == 0)
            {
                vysledek = centimetry * 10;
            }
            if (vysledna == 1)
            {
                vysledek = centimetry;
            }
            if (vysledna == 2)
            {
                vysledek = centimetry / 10;
            }
            if (vysledna == 3)
            {
                vysledek = centimetry / 100;
            }
            if (vysledna == 4)
            {
                vysledek = centimetry / 100000;
            }


            txtDisplay2.Text = vysledek.ToString();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            vysledna = cmbVysledna.SelectedIndex;
            zadana = cmbZadana.SelectedIndex;
            number1 = (number1 * 10) + 4;
            txtDisplay.Text = number1.ToString();
            if (zadana == 0)
            {
                centimetry = number1 / 10;
            }
            if (zadana == 1)
            {
                centimetry = number1;
            }
            if (zadana == 2)
            {
                centimetry = number1 * 10;
            }
            if (zadana == 3)
            {
                centimetry = number1 * 100;
            }
            if (zadana == 4)
            {
                centimetry = number1 * 100000;
            }

            if (vysledna == 0)
            {
                vysledek = centimetry * 10;
            }
            if (vysledna == 1)
            {
                vysledek = centimetry;
            }
            if (vysledna == 2)
            {
                vysledek = centimetry / 10;
            }
            if (vysledna == 3)
            {
                vysledek = centimetry / 100;
            }
            if (vysledna == 4)
            {
                vysledek = centimetry / 100000;
            }


            txtDisplay2.Text = vysledek.ToString();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            vysledna = cmbVysledna.SelectedIndex;
            zadana = cmbZadana.SelectedIndex;
            number1 = (number1 * 10) + 5;
            txtDisplay.Text = number1.ToString();
            if (zadana == 0)
            {
                centimetry = number1 / 10;
            }
            if (zadana == 1)
            {
                centimetry = number1;
            }
            if (zadana == 2)
            {
                centimetry = number1 * 10;
            }
            if (zadana == 3)
            {
                centimetry = number1 * 100;
            }
            if (zadana == 4)
            {
                centimetry = number1 * 100000;
            }

            if (vysledna == 0)
            {
                vysledek = centimetry * 10;
            }
            if (vysledna == 1)
            {
                vysledek = centimetry;
            }
            if (vysledna == 2)
            {
                vysledek = centimetry / 10;
            }
            if (vysledna == 3)
            {
                vysledek = centimetry / 100;
            }
            if (vysledna == 4)
            {
                vysledek = centimetry / 100000;
            }


            txtDisplay2.Text = vysledek.ToString();
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            vysledna = cmbVysledna.SelectedIndex;
            zadana = cmbZadana.SelectedIndex;
            number1 = (number1 * 10) + 6;
            txtDisplay.Text = number1.ToString();
            if (zadana == 0)
            {
                centimetry = number1 / 10;
            }
            if (zadana == 1)
            {
                centimetry = number1;
            }
            if (zadana == 2)
            {
                centimetry = number1 * 10;
            }
            if (zadana == 3)
            {
                centimetry = number1 * 100;
            }
            if (zadana == 4)
            {
                centimetry = number1 * 100000;
            }

            if (vysledna == 0)
            {
                vysledek = centimetry * 10;
            }
            if (vysledna == 1)
            {
                vysledek = centimetry;
            }
            if (vysledna == 2)
            {
                vysledek = centimetry / 10;
            }
            if (vysledna == 3)
            {
                vysledek = centimetry / 100;
            }
            if (vysledna == 4)
            {
                vysledek = centimetry / 100000;
            }


            txtDisplay2.Text = vysledek.ToString();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            vysledna = cmbVysledna.SelectedIndex;
            zadana = cmbZadana.SelectedIndex;
            number1 = (number1 * 10) + 7;
            txtDisplay.Text = number1.ToString();
            if (zadana == 0)
            {
                centimetry = number1 / 10;
            }
            if (zadana == 1)
            {
                centimetry = number1;
            }
            if (zadana == 2)
            {
                centimetry = number1 * 10;
            }
            if (zadana == 3)
            {
                centimetry = number1 * 100;
            }
            if (zadana == 4)
            {
                centimetry = number1 * 100000;
            }

            if (vysledna == 0)
            {
                vysledek = centimetry * 10;
            }
            if (vysledna == 1)
            {
                vysledek = centimetry;
            }
            if (vysledna == 2)
            {
                vysledek = centimetry / 10;
            }
            if (vysledna == 3)
            {
                vysledek = centimetry / 100;
            }
            if (vysledna == 4)
            {
                vysledek = centimetry / 100000;
            }


            txtDisplay2.Text = vysledek.ToString();
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            vysledna = cmbVysledna.SelectedIndex;
            zadana = cmbZadana.SelectedIndex;
            number1 = (number1 * 10) + 8;
            txtDisplay.Text = number1.ToString();
            if (zadana == 0)
            {
                centimetry = number1 / 10;
            }
            if (zadana == 1)
            {
                centimetry = number1;
            }
            if (zadana == 2)
            {
                centimetry = number1 * 10;
            }
            if (zadana == 3)
            {
                centimetry = number1 * 100;
            }
            if (zadana == 4)
            {
                centimetry = number1 * 100000;
            }

            if (vysledna == 0)
            {
                vysledek = centimetry * 10;
            }
            if (vysledna == 1)
            {
                vysledek = centimetry;
            }
            if (vysledna == 2)
            {
                vysledek = centimetry / 10;
            }
            if (vysledna == 3)
            {
                vysledek = centimetry / 100;
            }
            if (vysledna == 4)
            {
                vysledek = centimetry / 100000;
            }


            txtDisplay2.Text = vysledek.ToString();
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            vysledna = cmbVysledna.SelectedIndex;
            zadana = cmbZadana.SelectedIndex;
            number1 = (number1 * 10) + 9;
            txtDisplay.Text = number1.ToString();
            if (zadana == 0)
            {
                centimetry = number1 / 10;
            }
            if (zadana == 1)
            {
                centimetry = number1;
            }
            if (zadana == 2)
            {
                centimetry = number1 * 10;
            }
            if (zadana == 3)
            {
                centimetry = number1 * 100;
            }
            if (zadana == 4)
            {
                centimetry = number1 * 100000;
            }

            if (vysledna == 0)
            {
                vysledek = centimetry * 10;
            }
            if (vysledna == 1)
            {
                vysledek = centimetry;
            }
            if (vysledna == 2)
            {
                vysledek = centimetry / 10;
            }
            if (vysledna == 3)
            {
                vysledek = centimetry / 100;
            }
            if (vysledna == 4)
            {
                vysledek = centimetry / 100000;
            }


            txtDisplay2.Text = vysledek.ToString();
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            vysledna = cmbVysledna.SelectedIndex;
            zadana = cmbZadana.SelectedIndex;
            number1 = (number1 * 10);
            txtDisplay.Text = number1.ToString();
            if (zadana == 0)
            {
                centimetry = number1 / 10;
            }
            if (zadana == 1)
            {
                centimetry = number1;
            }
            if (zadana == 2)
            {
                centimetry = number1 * 10;
            }
            if (zadana == 3)
            {
                centimetry = number1 * 100;
            }
            if (zadana == 4)
            {
                centimetry = number1 * 100000;
            }

            if (vysledna == 0)
            {
                vysledek = centimetry * 10;
            }
            if (vysledna == 1)
            {
                vysledek = centimetry;
            }
            if (vysledna == 2)
            {
                vysledek = centimetry / 10;
            }
            if (vysledna == 3)
            {
                vysledek = centimetry / 100;
            }
            if (vysledna == 4)
            {
                vysledek = centimetry / 100000;
            }


            txtDisplay2.Text = vysledek.ToString();
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = " ";
            txtDisplay2.Text = " ";
            number1 = 0;
            vysledek = 0;
        }

        private void cmbZadana_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
    
        }
    }
}
