using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuncoesMatematicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)


        {

     
                //retorna um valor absoluto
                MessageBox.Show("Abs = " + Math.Abs(-77));

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //proximo numero inteoiro
            MessageBox.Show("Celing =" + Math.Ceiling(67.7));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //numero anterior inteoiro
            MessageBox.Show("Floor =" + Math.Floor(67.7));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //retorno o menor valor
            MessageBox.Show("Min =" + Math.Min(6,7));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //retorna o maior valor
            MessageBox.Show("Max =" + Math.Max(6,10));
        }

        private void button6_Click(object sender, EventArgs e)
        {

            //numero ao expoente
            MessageBox.Show("pow =" + Math.Pow(2, 3));
        }
    }
}
