namespace Laboratorio12_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double calificacionA;

            if (double.TryParse(textBox1.Text, out calificacionA))
            {

            }
            else
            {
                MessageBox.Show("Por favor ingrese un número válido para la primera nota.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double calificacionB;

            if (double.TryParse(textBox2.Text, out calificacionB))
            {

            }
            else
            {
                MessageBox.Show("Por favor ingrese un número válido para la segunda nota.");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double calificacionC;

            if (double.TryParse(textBox3.Text, out calificacionC))
            {

            }
            else
            {
                MessageBox.Show("Por favor ingrese un número válido para la tercera nota.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor1, valor2, valor3;

            if (double.TryParse(textBox1.Text, out valor1) &&
                double.TryParse(textBox2.Text, out valor2) &&
                double.TryParse(textBox3.Text, out valor3))
            {
                double promedioFinal = (valor1 + valor2 + valor3) / 3;
                textBox4.Text = promedioFinal.ToString("F2"); 
            }
            else
            {
                MessageBox.Show("Ingrese solo valores numéricos válidos en los campos de notas.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
