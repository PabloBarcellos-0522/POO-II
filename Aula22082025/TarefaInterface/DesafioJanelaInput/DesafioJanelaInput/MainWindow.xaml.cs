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

namespace DesafioJanelaInput
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string nome;
        public string sobrenome;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            nome = Input1.Text;
            sobrenome = Input2.Text;

            Output1.Text = nome + " " + sobrenome;
        }

        private void Input1_TextChanged(object sender, TextChangedEventArgs e)
        {
            nome = Input1.Text;
            sobrenome = Input2.Text;

            Output1.Text = nome + " " + sobrenome;
        }

        private void Input2_TextChanged(object sender, TextChangedEventArgs e)
        {
            nome = Input1.Text;
            sobrenome = Input2.Text;

            Output1.Text = nome + " " + sobrenome;
        }
    }
}