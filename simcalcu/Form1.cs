using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simcalcu
{
    public partial class Form1 : Form
    {
        int num1, num2;
        GetAnswer delegatedAdd, delegatedDif, delegatedMul, delegatedDiv;

        private void button4_Click(object sender, EventArgs e)
        {
            delegatedDiv = new GetAnswer(Class1.getDiv);
            num1 = Int32.Parse(textBox1.Text);
            num2 = Int32.Parse(textBox2.Text);
            MessageBox.Show(delegatedDiv(num1, num2).ToString(), "Answer");
        }
        private void button2_Click(object sender, EventArgs e)
        {
                delegatedDif = new GetAnswer(Class1.getDiff);
                num1 = Int32.Parse(textBox1.Text);
                num2 = Int32.Parse(textBox2.Text);
                MessageBox.Show(delegatedDif(num1, num2).ToString(), "Answer");
            }
        private void button3_Click(object sender, EventArgs e)
        {
            {
                delegatedMul = new GetAnswer(Class1.getMul);
                num1 = Int32.Parse(textBox1.Text);
                num2 = Int32.Parse(textBox2.Text);
                MessageBox.Show(delegatedMul(num1, num2).ToString(), "Answer");
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            delegatedAdd = new GetAnswer(Class1.getAdd);
            num1 = Int32.Parse(textBox1.Text);
            num2 = Int32.Parse(textBox2.Text);
            MessageBox.Show(delegatedAdd(num1, num2).ToString(), "Answer");
        }


    }
}

