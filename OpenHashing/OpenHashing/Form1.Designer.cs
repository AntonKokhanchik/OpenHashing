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
            this.textBoxForNumberElements = new System.Windows.Forms.TextBox();
            this.textBoxForDelitingElement = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonForDelete = new System.Windows.Forms.Button();
            this.textBoxForInsertingElement = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonForInsert = new System.Windows.Forms.Button();
            this.textBoxForSearchingElement = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonForSearch = new System.Windows.Forms.Button();
            this.buttonForOut = new System.Windows.Forms.Button();
            this.OutOk = new System.Windows.Forms.Label();
            this.InsertOK = new System.Windows.Forms.Label();
            this.DeleteOK = new System.Windows.Forms.Label();
            this.FindOK = new System.Windows.Forms.Label();
            this.DeleteFailed = new System.Windows.Forms.Label();
            this.FindFailed = new System.Windows.Forms.Label();
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
            // textBoxForNumberElements
            // 
            this.textBoxForNumberElements.Location = new System.Drawing.Point(310, 21);
            this.textBoxForNumberElements.Name = "textBoxForNumberElements";
            this.textBoxForNumberElements.Size = new System.Drawing.Size(67, 20);
            this.textBoxForNumberElements.TabIndex = 8;
            this.textBoxForNumberElements.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxForDelitingElement
            // 
            this.textBoxForDelitingElement.Enabled = false;
            this.textBoxForDelitingElement.Location = new System.Drawing.Point(310, 275);
            this.textBoxForDelitingElement.Name = "textBoxForDelitingElement";
            this.textBoxForDelitingElement.Size = new System.Drawing.Size(67, 20);
            this.textBoxForDelitingElement.TabIndex = 11;
            this.textBoxForDelitingElement.TextChanged += new System.EventHandler(this.textBoxForDelitingElement_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(34, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Какой элемент хотите удалить?";
            // 
            // buttonForDelete
            // 
            this.buttonForDelete.Enabled = false;
            this.buttonForDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonForDelete.Location = new System.Drawing.Point(29, 301);
            this.buttonForDelete.Name = "buttonForDelete";
            this.buttonForDelete.Size = new System.Drawing.Size(347, 44);
            this.buttonForDelete.TabIndex = 9;
            this.buttonForDelete.Text = "Удалить элемент";
            this.buttonForDelete.UseVisualStyleBackColor = true;
            this.buttonForDelete.Click += new System.EventHandler(this.buttonForDelete_Click);
            // 
            // textBoxForInsertingElement
            // 
            this.textBoxForInsertingElement.Enabled = false;
            this.textBoxForInsertingElement.Location = new System.Drawing.Point(310, 136);
            this.textBoxForInsertingElement.Name = "textBoxForInsertingElement";
            this.textBoxForInsertingElement.Size = new System.Drawing.Size(67, 20);
            this.textBoxForInsertingElement.TabIndex = 14;
            this.textBoxForInsertingElement.TextChanged += new System.EventHandler(this.textBoxForInsertingElement_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(26, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Какой элемент хотите добавить?";
            // 
            // buttonForInsert
            // 
            this.buttonForInsert.Enabled = false;
            this.buttonForInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonForInsert.Location = new System.Drawing.Point(29, 162);
            this.buttonForInsert.Name = "buttonForInsert";
            this.buttonForInsert.Size = new System.Drawing.Size(347, 44);
            this.buttonForInsert.TabIndex = 12;
            this.buttonForInsert.Text = "Добавить элемент";
            this.buttonForInsert.UseVisualStyleBackColor = true;
            this.buttonForInsert.Click += new System.EventHandler(this.buttonForInsert_Click);
            // 
            // textBoxForSearchingElement
            // 
            this.textBoxForSearchingElement.Enabled = false;
            this.textBoxForSearchingElement.Location = new System.Drawing.Point(310, 413);
            this.textBoxForSearchingElement.Name = "textBoxForSearchingElement";
            this.textBoxForSearchingElement.Size = new System.Drawing.Size(67, 20);
            this.textBoxForSearchingElement.TabIndex = 17;
            this.textBoxForSearchingElement.TextChanged += new System.EventHandler(this.textBoxForSearchingElement_TextChanged);
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
            this.buttonForSearch.Click += new System.EventHandler(this.buttonForSearch_Click);
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
            // OutOk
            // 
            this.OutOk.AutoSize = true;
            this.OutOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.OutOk.Location = new System.Drawing.Point(115, 609);
            this.OutOk.Name = "OutOk";
            this.OutOk.Size = new System.Drawing.Size(180, 24);
            this.OutOk.TabIndex = 19;
            this.OutOk.Text = "Таблица выведена";
            this.OutOk.Visible = false;
            // 
            // InsertOK
            // 
            this.InsertOK.AutoSize = true;
            this.InsertOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.InsertOK.Location = new System.Drawing.Point(110, 209);
            this.InsertOK.Name = "InsertOK";
            this.InsertOK.Size = new System.Drawing.Size(181, 24);
            this.InsertOK.TabIndex = 20;
            this.InsertOK.Text = "Элемент добавлен";
            this.InsertOK.Visible = false;
            // 
            // DeleteOK
            // 
            this.DeleteOK.AutoSize = true;
            this.DeleteOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DeleteOK.Location = new System.Drawing.Point(125, 348);
            this.DeleteOK.Name = "DeleteOK";
            this.DeleteOK.Size = new System.Drawing.Size(157, 24);
            this.DeleteOK.TabIndex = 21;
            this.DeleteOK.Text = "Элемент удален";
            this.DeleteOK.Visible = false;
            // 
            // FindOK
            // 
            this.FindOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FindOK.Location = new System.Drawing.Point(34, 486);
            this.FindOK.Name = "FindOK";
            this.FindOK.Size = new System.Drawing.Size(350, 24);
            this.FindOK.TabIndex = 22;
            this.FindOK.Text = "Элемент найден";
            this.FindOK.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FindOK.Visible = false;
            // 
            // DeleteFailed
            // 
            this.DeleteFailed.AutoSize = true;
            this.DeleteFailed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.DeleteFailed.Location = new System.Drawing.Point(94, 348);
            this.DeleteFailed.Name = "DeleteFailed";
            this.DeleteFailed.Size = new System.Drawing.Size(235, 24);
            this.DeleteFailed.TabIndex = 23;
            this.DeleteFailed.Text = "Элемента не существует";
            this.DeleteFailed.Visible = false;
            // 
            // FindFailed
            // 
            this.FindFailed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FindFailed.Location = new System.Drawing.Point(25, 486);
            this.FindFailed.Name = "FindFailed";
            this.FindFailed.Size = new System.Drawing.Size(350, 24);
            this.FindFailed.TabIndex = 24;
            this.FindFailed.Text = "Элемента не существует";
            this.FindFailed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FindFailed.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 659);
            this.Controls.Add(this.FindFailed);
            this.Controls.Add(this.DeleteFailed);
            this.Controls.Add(this.FindOK);
            this.Controls.Add(this.DeleteOK);
            this.Controls.Add(this.InsertOK);
            this.Controls.Add(this.OutOk);
            this.Controls.Add(this.buttonForOut);
            this.Controls.Add(this.textBoxForSearchingElement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonForSearch);
            this.Controls.Add(this.textBoxForInsertingElement);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonForInsert);
            this.Controls.Add(this.textBoxForDelitingElement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonForDelete);
            this.Controls.Add(this.textBoxForNumberElements);
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
		private System.Windows.Forms.TextBox textBoxForNumberElements;
		private System.Windows.Forms.TextBox textBoxForDelitingElement;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonForDelete;
		private System.Windows.Forms.TextBox textBoxForInsertingElement;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonForInsert;
		private System.Windows.Forms.TextBox textBoxForSearchingElement;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonForSearch;
		private System.Windows.Forms.Button buttonForOut;
        private System.Windows.Forms.Label OutOk;
        private System.Windows.Forms.Label InsertOK;
        private System.Windows.Forms.Label DeleteOK;
        private System.Windows.Forms.Label FindOK;
        private System.Windows.Forms.Label DeleteFailed;
        private System.Windows.Forms.Label FindFailed;
    }
}

