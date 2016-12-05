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
        List<int>[] table;


        public Form1()
		{
			InitializeComponent();
		}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxForNumberElements.Text.Equals(""))
                buttonForHashTable.Enabled = true;
            else
                buttonForHashTable.Enabled = false;
            buttonForDelete.Enabled = false;
            buttonForInsert.Enabled = false;
            buttonForSearch.Enabled = false;
            buttonForOut.Enabled = false;

            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;

            DeleteFailed.Visible = false;
            DeleteOK.Visible = false;
            InsertOK.Visible = false;
            FindFailed.Visible = false;
            FindOK.Visible = false;
            OutOk.Visible = false;

            textBoxForDelitingElement.Enabled = false;
            textBoxForDelitingElement.Text = "";
            textBoxForInsertingElement.Enabled = false;
            textBoxForInsertingElement.Text = "";
            textBoxForSearchingElement.Enabled = false;
            textBoxForSearchingElement.Text = "";
        }
        
        private void textBoxForDelitingElement_TextChanged(object sender, EventArgs e)
        {
            DeleteFailed.Visible = false;
            DeleteOK.Visible = false;
        }
        private void textBoxForInsertingElement_TextChanged(object sender, EventArgs e)
        {
            InsertOK.Visible = false;
        }
        private void textBoxForSearchingElement_TextChanged(object sender, EventArgs e)
        {
            FindFailed.Visible = false;
            FindOK.Visible = false;
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
            OutOk.Visible = false;
            textBoxForDelitingElement.Enabled = true;
            textBoxForInsertingElement.Enabled = true;
            textBoxForSearchingElement.Enabled = true;

            CreateHashTable(Int32.Parse(textBoxForNumberElements.Text));
		}

        /// <summary>
        /// Создание хэш-таблицы
        /// </summary>
        /// <param name="num"></param>
		private void CreateHashTable(int num)
		{
		    sizeOfTable = num / 3;  //задаём размер таблицы: примерно треть от исходного числа элементов
            table = new List<int>[sizeOfTable];

            for(int j = 0; j < sizeOfTable; j++)
            {
                table[j] = new List<int>();
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

        /// <summary>
        /// Вставка элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonForInsert_Click(object sender, EventArgs e)
        {
            int newElement = Int32.Parse(textBoxForInsertingElement.Text);
            int rest = newElement % sizeOfTable;

            table[rest].Add(newElement);
            InsertOK.Visible = true;
        }

        /// <summary>
        /// Удаление элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonForDelete_Click(object sender, EventArgs e)
        {
            int delElem = Int32.Parse(textBoxForDelitingElement.Text);
            int rest = delElem % sizeOfTable;
            if (findElement(table[rest], delElem) != -1)
            {
                table[rest].Remove(delElem);
                DeleteOK.Visible = true;
            }
            else
                DeleteFailed.Visible = true;
        }

        /// <summary>
        /// Вывод хэш-таблицы в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            OutOk.Visible = true;
        }

        /// <summary>
        /// Поиск элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonForSearch_Click(object sender, EventArgs e)
        {
            int elem = Int32.Parse(textBoxForInsertingElement.Text);
            int rest = elem % sizeOfTable;
            int result = findElement(table[rest], elem);
            if (result != -1)
            {
                FindOK.Visible = true;
                FindFailed.Visible = false;
            }

            else
            {
                FindFailed.Visible = true;
                FindOK.Visible = false;
            }
        }


        private int findElement(List<int> list, int el)
        {
            return list.IndexOf(el);
        }
    }
}
