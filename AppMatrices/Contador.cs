using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMatrices
{
    public partial class lblmarge : Form
    {
        public lblmarge()
        {
            InitializeComponent();
        }


        int Contador = 0;
        int valor = 0;

        private void buttonIncrementar_Click(object sender, EventArgs e)
        {
           valor = Convert.ToInt32(labelContador.Text);
           Contador = valor;
           Contador =Contador + 1;
            labelContador.Text = Contador.ToString();

            if (Contador > 0)
            {
                labelContador.ForeColor = Color.Green;
            }
            else if (Contador == 0)
            {
                labelContador.ForeColor = Color.Blue;
            }

            else
            {
                labelContador.ForeColor = Color.Red;
            }
        }

        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
          labelContador.Text = "0";
            labelContador.ForeColor = Color.Blue;
        }

        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            valor = Convert.ToInt32(labelContador.Text);
            Contador = valor;
            Contador = Contador -1;
            labelContador.Text = Contador.ToString();

            if (Contador > 0)
            {
                labelContador.ForeColor = Color.Green;
            }
            else if (Contador == 0)
            {
                labelContador.ForeColor = Color.Blue;
            }

            else
            {
                labelContador.ForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
        }
    }
}
