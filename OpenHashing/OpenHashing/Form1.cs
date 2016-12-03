using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenHashing
{
	public partial class Form1 : Form
	{
        int sizeOfTable = 0;
        List<List<int>> table;


        public Form1()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (!textBox1.Text.Equals(""))
			{
				buttonForHashTable.Enabled = true;
            }
			else
			{
				buttonForHashTable.Enabled = false;
				buttonForDelete.Enabled = false;
				buttonForInsert.Enabled = false;
				buttonForSearch.Enabled = false;
				buttonForOut.Enabled = false;
				label2.Enabled = false;
				label3.Enabled = false;
				label4.Enabled = false;
            }
		}

		private void buttonForHashTable_Click(object sender, EventArgs e)
		{
			buttonForDelete.Enabled = true;
			buttonForInsert.Enabled = true;
			buttonForSearch.Enabled = true;
			buttonForOut.Enabled = true;
			label2.Enabled = true;
			label3.Enabled = true;
			label4.Enabled = true;
            labelOk.Visible = false;

            CreateHashTable(Int32.Parse(textBox1.Text));
		}

		private void CreateHashTable(int num)
		{
		    sizeOfTable = num / 3;  //задаём размер таблицы: примерно треть от исходного числа элементов
            table = new List<List<int>>();

            for(int j = 0; j < sizeOfTable; j++)
            {
                table.Add(new List<int>());
            }


            Random elements = new Random();
            int elem, rest;
            for (int i = 0; i < num; i++)
			{
                elem = elements.Next(0, 1000);
                rest = elem % sizeOfTable;
                table[rest].Add(elem);
			}
		}

        private void buttonForOut_Click(object sender, EventArgs e)
        {
            using (StreamWriter hashTable = new StreamWriter("hashTable.txt", false))
            {
                if (sizeOfTable == 0)
                    hashTable.Write("Элемента не заданы - таблица пустая");
                else
                    for (int i = 0; i < sizeOfTable; i++)
                    {
                        hashTable.Write(i + "\t");
                        foreach(int a in table[i])
                        {
                            hashTable.Write(" -> " + a);
                        }
                        hashTable.WriteLine();
                    }
            }
            labelOk.Visible = true;
        }
    }
}
