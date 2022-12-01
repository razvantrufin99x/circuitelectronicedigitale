using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace circuitelectronicedigitale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public notgate notgate1 = new notgate();
        public andgate andgate1 = new andgate();
        public orgate orgate1 = new orgate();
        public xorgate xorgate1 = new xorgate();

        private void button1_Click(object sender, EventArgs e)
        {
            notgate1.pinIn.valoare = Int16.Parse(textBox1.Text) ;
            notgate1.negatie();
            textBox2.Text  = notgate1.pinOut.valoare.ToString();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            andgate1.pinIn1.valoare = Int16.Parse(textBox3.Text);
            andgate1.pinIn2.valoare = Int16.Parse(textBox4.Text);
            andgate1.conjunctie();
            textBox5.Text = andgate1.pinOut.valoare.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            orgate1.pinIn1.valoare = Int16.Parse(textBox6.Text);
            orgate1.pinIn2.valoare = Int16.Parse(textBox7.Text);
            orgate1.disjunctie();
            textBox8.Text = orgate1.pinOut.valoare.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            xorgate1.pinIn1.valoare = Int16.Parse(textBox9.Text);
            xorgate1.pinIn2.valoare = Int16.Parse(textBox10.Text);
            xorgate1.xordisjunctie();
            textBox11.Text = xorgate1.pinOut.valoare.ToString();
        }
    }
}
