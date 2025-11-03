namespace Laboratorio_12_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double ladoZ;
            double.TryParse(textBox3.Text, out ladoZ);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double ladoX;
            double.TryParse(textBox1.Text, out ladoX);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double ladoY;
            double.TryParse(textBox2.Text, out ladoY);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorA, valorB, valorC;

            if (double.TryParse(textBox1.Text, out valorA) &&
                double.TryParse(textBox2.Text, out valorB) &&
                double.TryParse(textBox3.Text, out valorC))
            {
                double semiperimetro = (valorA + valorB + valorC) / 2;
                textBox4.Text = semiperimetro.ToString("0.00");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ladoUno, ladoDos, ladoTres;

            if (double.TryParse(textBox1.Text, out ladoUno) &&
                double.TryParse(textBox2.Text, out ladoDos) &&
                double.TryParse(textBox3.Text, out ladoTres))
            {
                double semi = (ladoUno + ladoDos + ladoTres) / 2;

                if (ladoUno + ladoDos > ladoTres && ladoUno + ladoTres > ladoDos && ladoDos + ladoTres > ladoUno)
                {
                    double resultadoArea = Math.Sqrt(semi * (semi - ladoUno) * (semi - ladoDos) * (semi - ladoTres));
                    textBox5.Text = resultadoArea.ToString("0.00");
                }
                else
                {
                    MessageBox.Show("Los datos introducidos no corresponden a un triángulo válido.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
