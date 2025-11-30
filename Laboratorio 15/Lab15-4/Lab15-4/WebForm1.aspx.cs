using System;

namespace Lab15_4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // se convierte  los TextBox a números

            double num1 = double.Parse(TextBox1.Text);
            double num2 = double.Parse(TextBox2.Text);

            // se realiza la suma
            double suma = num1 + num2;

            // se muestra el resultado en el TextBox3
            TextBox3.Text = suma.ToString();
        }
    }
}
