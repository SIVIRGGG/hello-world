using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace kursach_v_0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(textBox1.Text, textBox2.Text);
            if ((textBox1.Text == "admin") && (textBox2.Text == "pass1"))
            {
                f.Show();
                this.Hide();
            }
            else
                if ((textBox1.Text == "admis") && (textBox2.Text == "pass2"))
            {
                f.Show();
                this.Hide();
            }
            else
                if ((textBox1.Text == "doc") && (textBox2.Text == "pass3"))
            {
                f.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Неверный логин или пароль");
        }
    }
}
