using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadaniForToday
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = listBox1.Items[index].ToString();

            int len = str.Length;
            int count = 0;
            int i = 0;
            while(i<len)
            {
                if (str[i] == ' ')
                    count++;
                i++;
            }
            label1.Text = $"Количество пробелов = {count}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = listBox2.SelectedIndex;
            string str = listBox2.Items[index].ToString();

            int countZeros = 0;
            int countOnes = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == '0') countZeros++;
                if (str[i] == '1') countOnes++;
            }

            label2.Text = $"Количество '0' = {countZeros}\t Количество '1' = {countOnes}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = listBox3.SelectedIndex;
            string str = listBox3.Items[index].ToString();

            int len = str.Length;
            int count = 1;
            int i = 0;
            while (i < len)
            {
                if (str[i] == ' ')
                    count++;
                i++;
            }
            label3.Text = $"Количество Слов = {count}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = listBox4.SelectedIndex;
            string str = listBox4.Items[index].ToString();

            int len = str.Length;
            int count = 0;
            int i = 0;
            while (i < len)
            {
                if (str[i] == '.')
                    count++;
                else if (str[i] == ',')
                    count++;
                else if (str[i] == ';')
                    count++;
                else if (str[i] == ':')
                    count++;
                else if (str[i] == '!')
                    count++;
                else if (str[i] == '?')
                    count++;

                i++;
            }
            label4.Text = $"Количество знаков препинания = {count}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int index = listBox5.SelectedIndex;
            string str = listBox5.Items[index].ToString();
            string text = "Цифры = {";
            int len = str.Length;
            
            char[] numbers = new char[10];
            bool wasThere = false;
            int indexchar = 0;
            int i = 0;
            while (i < len)
            {
                if(char.IsDigit(str[i]))
                {
                    for(int j = 0; j < numbers.Length; j++)
                    {
                        if (numbers[j] == str[i])
                        {
                            wasThere = true;
                            break;
                        }
                    }

                    if(!wasThere)
                    {
                        numbers[indexchar] = str[i];
                        wasThere = false;
                        indexchar++;
                    }
                }
                i++;
            }


            for (int j = 0; j < indexchar + 1; j++)
                text += $"{numbers[j]}, ";
            text += "}";
            label5.Text = text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[,] array = new int[3, 4];
            
            dataGridView1.RowCount = 4;
            dataGridView1.ColumnCount = 3;

            dataGridView2.RowCount = 4;
            dataGridView2.ColumnCount = 1;

            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(100);
                    dataGridView1.Rows[j].Cells[i].Value = array[i, j].ToString();
                }
            
           for(int i = 0; i < dataGridView1.Rows.Count; i++)
           {
                int min = array[0, i];
                for(int j = 1; j < array.GetLength(0); j++)
                    if (min > array[j, i]) min = array[j, i];

                dataGridView2.Rows[i].Cells[0].Value = min.ToString();
           }

            
        }
    }
}
