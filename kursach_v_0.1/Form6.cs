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
    public partial class Form6 : Form
    {
        DbData3 data = new DbData3();
        public Form6()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Загружено из файла D:\\DepartmentDB.dat");
            data.LoadFromFile();
            BindingSource bs = new BindingSource(data.getData(), null);
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сохранено в файл D:\\DepartmentDB.dat");
            data.SaveToFile();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource(data.getData(), null);
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Название")
                data.Sort();
            else
             if (comboBox2.Text == "Количество мест")
                data.Sort1();
            else
             if (comboBox2.Text == "Количество свободных мест")
                data.Sort2();
            else
                MessageBox.Show("Выберите критерий сортировки!");
            BindingSource bs = new BindingSource(data.getData(), null);
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int t = 0;
            if (comboBox1.Text == "Название")
                t = 1;
            else
                if (comboBox1.Text == "Количество мест")
                t = 4;
            else
                if (comboBox1.Text == "Количество свободных мест")
                t = 5;
            else
                MessageBox.Show("Выберите критерий поиска!");
            if (textBox1.Text == "")
                MessageBox.Show("Введите текст для поика!");
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    CurrencyManager cm = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                    cm.SuspendBinding();
                    bool isVisible = false;
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1[t, i].FormattedValue.ToString().Contains(textBox1.Text.Trim()))
                        {
                            isVisible = true;
                        }
                        dataGridView1.Rows[i].Visible = isVisible;
                        cm.ResumeBinding();
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].Visible = true;
            }
            textBox1.Text = "";
            comboBox1.Text = "";
        }
    }
}
