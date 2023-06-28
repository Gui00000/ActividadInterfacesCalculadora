using System.Runtime.CompilerServices;

namespace ActividadInterfaces
{
    public partial class Form1 : Form
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        public Form1()
        {
            InitializeComponent();

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);

            lblResultado.Text = "Suma: " + (num1 + num2);

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);

            lblResultado.Text = "Resta: " + (num1 - num2);
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);

            lblResultado.Text = "Multi: " + (num1 * num2);
        }

        private void btnDivision_Click(Object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);

            lblResultado.Text = "Division: " + (num1 / num2);
        }

    }
}