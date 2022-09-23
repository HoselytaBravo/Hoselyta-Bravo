using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO1
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

        private void btnmatrices_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[,] valores = new string[9, 2];
            //almacenar  valores
            //{a:1, b:2, c:3}
            valores[0, 0] = "a";
            valores[0, 1] = "b";
            valores[1, 0] = "c";
            valores[1, 1] = "1";
            valores[2, 0] = "2";
            valores[2, 1] = "3";
            //{ a: "Apple", b: "Microsoft", c: "Google" }
            valores[3, 0] = "a";
            valores[3, 1] = "b";
            valores[4, 0] = "c";
            valores[4, 1] = "Apple";
            valores[5, 0] = "Google";
            valores[5, 1] = "Microsoft";
            //{ key1: true, key2: false, key3, undefined }
            valores[6, 0] = "key1";
            valores[6, 1] = "key2";
            valores[7, 0] = "key3";
            valores[7, 1] = "false";
            valores[8, 0] = "true";
            valores[8, 1] = "undefined";

            //devolver valores en listbox
            listBox1.Items.Add(valores[0, 0]);
            listBox1.Items.Add(valores[0, 1]);
            listBox1.Items.Add(valores[1, 0]);

            listBox2.Items.Add(valores[1, 1]);
            listBox2.Items.Add(valores[2, 0]);
            listBox2.Items.Add(valores[2, 1]);

            listBox3.Items.Add(valores[3, 0]);
            listBox3.Items.Add(valores[3, 1]);
            listBox3.Items.Add(valores[4, 0]);

            listBox4.Items.Add(valores[4, 1]);
            listBox4.Items.Add(valores[5, 0]);
            listBox4.Items.Add(valores[5, 1]);

            listBox5.Items.Add(valores[6, 0]);
            listBox5.Items.Add(valores[6, 1]);
            listBox5.Items.Add(valores[7, 0]);

            listBox6.Items.Add(valores[7, 1]);
            listBox6.Items.Add(valores[8, 0]);
            listBox6.Items.Add(valores[8, 1]);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
