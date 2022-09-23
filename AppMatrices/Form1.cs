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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnmatrices_Click(object sender, EventArgs e)
        {
            int[,] valores = new int[2, 2];
            // almacenamos los valores en la matriz

            valores[0, 0] = 100;
            valores[0, 1] = 50;
            valores[1, 0] = 60;
            valores[1, 1] = 25;

            // insertar los valores de la matriz en el listbox 
            listBox1.Items.Add(valores[0, 0]);
            listBox1.Items.Add(valores[0, 1]);
            listBox1.Items.Add(valores[1, 0]);
            listBox1.Items.Add(valores[1, 1]);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[,] valores = new string[3, 3];
            valores[0, 0] = "a";
            valores[0, 1] = "1";
            valores[1, 0] = "b";
            valores[1, 1] = "2";
            valores[2, 0] = "c";
            valores[2, 1] = "3";

            listBox2.Items.Add(valores[0, 0]);
            listBox2.Items.Add(valores[0, 1]);
            listBox2.Items.Add(valores[1, 0]);
            listBox2.Items.Add(valores[1, 1]);
            listBox2.Items.Add(valores[2, 0]);
            listBox2.Items.Add(valores[2, 1]);

        }
    }
}
