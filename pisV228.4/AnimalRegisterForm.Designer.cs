namespace pisV228._4
{
    partial class AnimalRegisterForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AnimalRegiterGBox = new System.Windows.Forms.GroupBox();
            this.RemoveARButton = new System.Windows.Forms.Button();
            this.OpenARButton = new System.Windows.Forms.Button();
            this.AddARButton = new System.Windows.Forms.Button();
            this.ARDataGridView = new System.Windows.Forms.DataGridView();
            this.ExportButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CheckBoxDesc = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ComboBoxSort = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AnimalRegiterGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ARDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnimalRegiterGBox
            // 
            this.AnimalRegiterGBox.Controls.Add(this.RemoveARButton);
            this.AnimalRegiterGBox.Controls.Add(this.OpenARButton);
            this.AnimalRegiterGBox.Controls.Add(this.AddARButton);
            this.AnimalRegiterGBox.Location = new System.Drawing.Point(617, 53);
            this.AnimalRegiterGBox.Margin = new System.Windows.Forms.Padding(4);
            this.AnimalRegiterGBox.Name = "AnimalRegiterGBox";
            this.AnimalRegiterGBox.Padding = new System.Windows.Forms.Padding(4);
            this.AnimalRegiterGBox.Size = new System.Drawing.Size(304, 262);
            this.AnimalRegiterGBox.TabIndex = 0;
            this.AnimalRegiterGBox.TabStop = false;
            // 
            // RemoveARButton
            // 
            this.RemoveARButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RemoveARButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveARButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveARButton.Location = new System.Drawing.Point(80, 192);
            this.RemoveARButton.Margin = new System.Windows.Forms.Padding(4);
            this.RemoveARButton.Name = "RemoveARButton";
            this.RemoveARButton.Size = new System.Drawing.Size(137, 42);
            this.RemoveARButton.TabIndex = 2;
            this.RemoveARButton.Text = "Удалить";
            this.RemoveARButton.UseVisualStyleBackColor = false;
            this.RemoveARButton.Click += new System.EventHandler(this.RemoveARButton_Click);
            // 
            // OpenARButton
            // 
            this.OpenARButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OpenARButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenARButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OpenARButton.Location = new System.Drawing.Point(80, 114);
            this.OpenARButton.Margin = new System.Windows.Forms.Padding(4);
            this.OpenARButton.Name = "OpenARButton";
            this.OpenARButton.Size = new System.Drawing.Size(137, 42);
            this.OpenARButton.TabIndex = 1;
            this.OpenARButton.Text = "Открыть";
            this.OpenARButton.UseVisualStyleBackColor = false;
            this.OpenARButton.Click += new System.EventHandler(this.OpenARButton_Click);
            // 
            // AddARButton
            // 
            this.AddARButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddARButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddARButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddARButton.Location = new System.Drawing.Point(80, 37);
            this.AddARButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddARButton.Name = "AddARButton";
            this.AddARButton.Size = new System.Drawing.Size(137, 42);
            this.AddARButton.TabIndex = 0;
            this.AddARButton.Text = "Добавить";
            this.AddARButton.UseVisualStyleBackColor = false;
            this.AddARButton.Click += new System.EventHandler(this.AddARButton_Click);
            // 
            // ARDataGridView
            // 
            this.ARDataGridView.AllowUserToAddRows = false;
            this.ARDataGridView.AllowUserToDeleteRows = false;
            this.ARDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ARDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.ARDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ARDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ARDataGridView.Name = "ARDataGridView";
            this.ARDataGridView.ReadOnly = true;
            this.ARDataGridView.RowHeadersVisible = false;
            this.ARDataGridView.RowHeadersWidth = 51;
            this.ARDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ARDataGridView.Size = new System.Drawing.Size(509, 652);
            this.ARDataGridView.TabIndex = 1;
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExportButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExportButton.Location = new System.Drawing.Point(676, 334);
            this.ExportButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(179, 64);
            this.ExportButton.TabIndex = 2;
            this.ExportButton.Text = "Экспортировать в Excel";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.CheckBoxDesc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ComboBoxSort);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Location = new System.Drawing.Point(579, 409);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(500, 214);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(303, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 22);
            this.textBox1.TabIndex = 9;
            // 
            // CheckBoxDesc
            // 
            this.CheckBoxDesc.AutoSize = true;
            this.CheckBoxDesc.Location = new System.Drawing.Point(35, 160);
            this.CheckBoxDesc.Name = "CheckBoxDesc";
            this.CheckBoxDesc.Size = new System.Drawing.Size(118, 21);
            this.CheckBoxDesc.TabIndex = 8;
            this.CheckBoxDesc.Text = "По убыванию";
            this.CheckBoxDesc.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Сортировка:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Фильтр:";
            // 
            // ComboBoxSort
            // 
            this.ComboBoxSort.FormattingEnabled = true;
            this.ComboBoxSort.Location = new System.Drawing.Point(35, 60);
            this.ComboBoxSort.Name = "ComboBoxSort";
            this.ComboBoxSort.Size = new System.Drawing.Size(231, 24);
            this.ComboBoxSort.TabIndex = 4;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchButton.Location = new System.Drawing.Point(331, 147);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(137, 42);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AnimalRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1120, 652);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.ARDataGridView);
            this.Controls.Add(this.AnimalRegiterGBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnimalRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты поиска животного";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnimalRegisterForm_FormClosed);
            this.Load += new System.EventHandler(this.AnimalRegisterForm_Load);
            this.AnimalRegiterGBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ARDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AnimalRegiterGBox;
        private System.Windows.Forms.Button OpenARButton;
        private System.Windows.Forms.Button AddARButton;
        private System.Windows.Forms.DataGridView ARDataGridView;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button RemoveARButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CheckBoxDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxSort;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

