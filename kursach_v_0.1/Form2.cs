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
    public partial class Form2 : Form
    {
        string txtBox1 = "";
        string txtBox2 = "";
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string txtBox1, string txtBox2)
        {
            InitializeComponent();
            this.txtBox1 = txtBox1;
            this.txtBox2 = txtBox2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((txtBox1 == "doc") && (txtBox2 == "pass3"))
            {
                Form3 f3 = new Form3();
                f3.ShowDialog();
            }
            else
                MessageBox.Show("У данного пользователя нет прав доступа!!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            if ((txtBox1 == "doc") && (txtBox2 == "pass3"))
            {
                f4.ShowDialog();
            }
            else
              if ((txtBox1 == "admis") && (txtBox2 == "pass2"))
            {
                f4.ShowDialog();
            }
            else
                MessageBox.Show("У данного пользователя нет прав доступа!!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((txtBox1 == "admin") && (txtBox2 == "pass1"))
            {
                Form5 f5 = new Form5();
                f5.ShowDialog();
            }
            else
                MessageBox.Show("У данного пользователя нет прав доступа!!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            if ((txtBox1 == "admin") && (txtBox2 == "pass1"))
            {
                f6.ShowDialog();
            }
            else
              if ((txtBox1 == "admis") && (txtBox2 == "pass2"))
            {
                f6.ShowDialog();
            }
            else
                MessageBox.Show("У данного пользователя нет прав доступа!!!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((txtBox1 == "admin") && (txtBox2 == "pass1"))
            {
                Form7 f7 = new Form7();
                f7.ShowDialog();
            }
            else
                MessageBox.Show("У данного пользователя нет прав доступа!!!");
        }
    }
}
