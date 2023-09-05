using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.rno;
            label2.Text = Form1.name;
            label3.Text = Form1.course;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text=="generate") {
                Button b1=new Button();
                Button b2=new Button();
                b1.SetBounds(20, 30, 100, 30);
                b1.Text = "b1";
                b1.Enabled = true;
                this.Controls.Add(b1);
                b2.SetBounds(40,30,100,30);
                b2.Text = "b2";
                b2.Enabled = true;
                this.Controls.Add(b2);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n=Convert.ToInt32(comboBox1.Text);
            if(comboBox1.BackColor ==Color.Cyan) {
                //richTextBox1.Text = "hai";
               richTextBox1.BackColor = Color.Cyan;
                //richTextBox1.Size = new System.Drawing.Size(50, 50);
            }
            else
            {
                richTextBox1.BackColor = Color.Black;
            }
        }

       
    }
}
