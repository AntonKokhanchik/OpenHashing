using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenHashing
{
	public partial class Form1 : Form
	{
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

			CreateHashTable(Int32.Parse(textBox1.Text));
		}

		private void CreateHashTable(int num)
		{
			int sizeOfTable = num / 3;  //задаём размер таблицы: примерно треть от исходного числа элементов

			int i = 0;
			Random elements = new Random();
			while (i < num)
			{
				int elem = elements.Next(0, 1000);

			}
		}
		
	}
}
