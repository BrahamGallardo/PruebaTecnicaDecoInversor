namespace AbrahamCGPruebaTecnica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string textoEntrada = txtEntrada.Text;
            string textoInvertido = InvertirCadena(textoEntrada);
            txtResultado.Text = textoInvertido;
        }

        private string InvertirCadena(string cadena)
        {
            char[] caracteres = cadena.ToCharArray();
            Array.Reverse(caracteres);
            return new string(caracteres);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEntrada.Text = string.Empty;
            txtResultado.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}