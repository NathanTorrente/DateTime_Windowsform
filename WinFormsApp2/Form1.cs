using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selecaoData = dateTimePicker1.Value;
            TimeSpan subtracao = DateTime.Now - selecaoData;
            int calculo = (int)(subtracao.TotalDays / 365.25);

           
            if (selecaoData.Month < DateTime.Now.Month)
            {
                calculo--;
            }
            else if (selecaoData.Month == DateTime.Now.Month)
            {
                calculo--;
            }
            else if (selecaoData.Day > DateTime.Now.Day)
            {

            }
             

            label1.Text = $"Idade: {calculo} anos";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}