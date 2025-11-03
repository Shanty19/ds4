namespace Laboratorio121
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double velocidadIngresada;

            if (double.TryParse(textBox1.Text, out velocidadIngresada))
            {
            }
            else
            {
                MessageBox.Show("Por favor, introduzca un valor válido para la velocidad.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double tiempoTranscurrido;

            if (double.TryParse(textBox2.Text, out tiempoTranscurrido))
            {

            }
            else
            {
                MessageBox.Show("Por favor, introduzca un valor válido para el tiempo.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double datoVelocidad, datoTiempo;

            if (double.TryParse(textBox1.Text, out datoVelocidad) && double.TryParse(textBox2.Text, out datoTiempo))
            {
                double resultadoDistancia = datoVelocidad * datoTiempo;
                textBox3.Text = resultadoDistancia.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos en ambos campos.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

