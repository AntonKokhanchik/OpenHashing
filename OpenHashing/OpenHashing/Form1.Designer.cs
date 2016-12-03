namespace OpenHashing
{
	partial class Form1
	{
		/// <summary>
		/// Требуется переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.buttonForHashTable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonForDelete = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonForInsert = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonForSearch = new System.Windows.Forms.Button();
            this.buttonForOut = new System.Windows.Forms.Button();
            this.labelOk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonForHashTable
            // 
            this.buttonForHashTable.Enabled = false;
            this.buttonForHashTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonForHashTable.Location = new System.Drawing.Point(29, 47);
            this.buttonForHashTable.Name = "buttonForHashTable";
            this.buttonForHashTable.Size = new System.Drawing.Size(347, 44);
            this.buttonForHashTable.TabIndex = 3;
            this.buttonForHashTable.Text = "Составить хэш-таблицу";
            this.buttonForHashTable.UseVisualStyleBackColor = true;
            this.buttonForHashTable.Click += new System.EventHandler(this.buttonForHashTable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Введите количество элементов";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(310, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(311, 151);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(35, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Какой элемент хотите удалить?";
            // 
            // buttonForDelete
            // 
            this.buttonForDelete.Enabled = false;
            this.buttonForDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonForDelete.Location = new System.Drawing.Point(30, 177);
            this.buttonForDelete.Name = "buttonForDelete";
            this.buttonForDelete.Size = new System.Drawing.Size(347, 44);
            this.buttonForDelete.TabIndex = 9;
            this.buttonForDelete.Text = "Удалить элемент";
            this.buttonForDelete.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(312, 278);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(67, 20);
            this.textBox3.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(28, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Какой элемент хотите добавить?";
            // 
            // buttonForInsert
            // 
            this.buttonForInsert.Enabled = false;
            this.buttonForInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonForInsert.Location = new System.Drawing.Point(31, 304);
            this.buttonForInsert.Name = "buttonForInsert";
            this.buttonForInsert.Size = new System.Drawing.Size(347, 44);
            this.buttonForInsert.TabIndex = 12;
            this.buttonForInsert.Text = "Добавить элемент";
            this.buttonForInsert.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(310, 413);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(67, 20);
            this.textBox4.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(35, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Какой элемент хотите найти?";
            // 
            // buttonForSearch
            // 
            this.buttonForSearch.Enabled = false;
            this.buttonForSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonForSearch.Location = new System.Drawing.Point(29, 439);
            this.buttonForSearch.Name = "buttonForSearch";
            this.buttonForSearch.Size = new System.Drawing.Size(347, 44);
            this.buttonForSearch.TabIndex = 15;
            this.buttonForSearch.Text = "Найти элемент";
            this.buttonForSearch.UseVisualStyleBackColor = true;
            // 
            // buttonForOut
            // 
            this.buttonForOut.Enabled = false;
            this.buttonForOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonForOut.Location = new System.Drawing.Point(30, 553);
            this.buttonForOut.Name = "buttonForOut";
            this.buttonForOut.Size = new System.Drawing.Size(347, 44);
            this.buttonForOut.TabIndex = 18;
            this.buttonForOut.Text = "Вывести хэш-таблицу в файл";
            this.buttonForOut.UseVisualStyleBackColor = true;
            this.buttonForOut.Click += new System.EventHandler(this.buttonForOut_Click);
            // 
            // labelOk
            // 
            this.labelOk.AutoSize = true;
            this.labelOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelOk.Location = new System.Drawing.Point(115, 609);
            this.labelOk.Name = "labelOk";
            this.labelOk.Size = new System.Drawing.Size(180, 24);
            this.labelOk.TabIndex = 19;
            this.labelOk.Text = "Таблица выведена";
            this.labelOk.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 659);
            this.Controls.Add(this.labelOk);
            this.Controls.Add(this.buttonForOut);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonForSearch);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonForInsert);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonForDelete);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonForHashTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonForHashTable;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonForDelete;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonForInsert;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonForSearch;
		private System.Windows.Forms.Button buttonForOut;
        private System.Windows.Forms.Label labelOk;
    }
}

