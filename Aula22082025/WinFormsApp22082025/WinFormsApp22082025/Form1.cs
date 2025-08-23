namespace WinFormsApp22082025
{
    public partial class Form1 : Form
    {
        private int contador = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contador++;
            Labal_Contador.Text = contador.ToString();
        }
    }
}
