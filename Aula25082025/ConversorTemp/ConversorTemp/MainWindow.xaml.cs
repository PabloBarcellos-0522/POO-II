using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ConversorTemp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double tempC;
        public double tempF;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tempC = double.Parse(InputTMP.Text);
                tempF = tempC * 1.8 + 32;


                OutputTMP.Content = tempF + "º Fahrenheit";
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex);
            }


        }

        private void InputTMP_TextChanged(object sender, TextChangedEventArgs e)
        {

            try
            {
                tempC = double.Parse(InputTMP.Text);
                tempF = tempC * 1.8 + 32;


                OutputTMP.Content = tempF + "º Fahrenheit";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}