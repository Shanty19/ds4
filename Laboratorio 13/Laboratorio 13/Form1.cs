using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Laboratorio_13
{
    public partial class Form1 : Form
    {
        string connectionString =
@"Server=localhost\sqlexpress;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;TrustServerCertificate=true;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            conexion.Open();
            MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");

            SqlCommand cmd = new SqlCommand("SELECT ProductName FROM Products", conexion);
            SqlDataReader dr = cmd.ExecuteReader();

            listBox1.Items.Clear();

            for (; dr.Read();)
                listBox1.Items.Add(dr[0]);

            dr.Close();
            conexion.Close();
            MessageBox.Show("Se cerró la conexión.");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

