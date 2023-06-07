namespace pisV228._4
{
    partial class MunicipalContractRegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MCRDataGridView = new System.Windows.Forms.DataGridView();
            this.MContractRegisterGBox = new System.Windows.Forms.GroupBox();
            this.OpenMCRButton = new System.Windows.Forms.Button();
            this.AddMCRButton = new System.Windows.Forms.Button();
            this.RemoveMCRButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBoxSort = new System.Windows.Forms.ComboBox();
            this.ExportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MCRDataGridView)).BeginInit();
            this.MContractRegisterGBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MCRDataGridView
            // 
            this.MCRDataGridView.AllowUserToAddRows = false;
            this.MCRDataGridView.AllowUserToDeleteRows = false;
            this.MCRDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MCRDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.MCRDataGridView.Location = new System.Drawing.Point(0, 0);
            this.MCRDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.MCRDataGridView.Name = "MCRDataGridView";
            this.MCRDataGridView.ReadOnly = true;
            this.MCRDataGridView.RowHeadersVisible = false;
            this.MCRDataGridView.RowHeadersWidth = 51;
            this.MCRDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MCRDataGridView.Size = new System.Drawing.Size(575, 677);
            this.MCRDataGridView.TabIndex = 3;
            // 
            // MContractRegisterGBox
            // 
            this.MContractRegisterGBox.Controls.Add(this.OpenMCRButton);
            this.MContractRegisterGBox.Controls.Add(this.AddMCRButton);
            this.MContractRegisterGBox.Location = new System.Drawing.Point(689, 65);
            this.MContractRegisterGBox.Margin = new System.Windows.Forms.Padding(4);
            this.MContractRegisterGBox.Name = "MContractRegisterGBox";
            this.MContractRegisterGBox.Padding = new System.Windows.Forms.Padding(4);
            this.MContractRegisterGBox.Size = new System.Drawing.Size(304, 250);
            this.MContractRegisterGBox.TabIndex = 4;
            this.MContractRegisterGBox.TabStop = false;
            // 
            // OpenMCRButton
            // 
            this.OpenMCRButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OpenMCRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenMCRButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OpenMCRButton.Location = new System.Drawing.Point(80, 105);
            this.OpenMCRButton.Margin = new System.Windows.Forms.Padding(4);
            this.OpenMCRButton.Name = "OpenMCRButton";
            this.OpenMCRButton.Size = new System.Drawing.Size(137, 42);
            this.OpenMCRButton.TabIndex = 1;
            this.OpenMCRButton.Text = "Открыть";
            this.OpenMCRButton.UseVisualStyleBackColor = false;
            this.OpenMCRButton.Click += new System.EventHandler(this.OpenMCRButton_Click);
            // 
            // AddMCRButton
            // 
            this.AddMCRButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddMCRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddMCRButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddMCRButton.Location = new System.Drawing.Point(80, 37);
            this.AddMCRButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddMCRButton.Name = "AddMCRButton";
            this.AddMCRButton.Size = new System.Drawing.Size(137, 42);
            this.AddMCRButton.TabIndex = 0;
            this.AddMCRButton.Text = "Добавить";
            this.AddMCRButton.UseVisualStyleBackColor = false;
            this.AddMCRButton.Click += new System.EventHandler(this.AddMCRButton_Click);
            // 
            // RemoveMCRButton
            // 
            this.RemoveMCRButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RemoveMCRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveMCRButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveMCRButton.Location = new System.Drawing.Point(769, 245);
            this.RemoveMCRButton.Name = "RemoveMCRButton";
            this.RemoveMCRButton.Size = new System.Drawing.Size(137, 46);
            this.RemoveMCRButton.TabIndex = 2;
            this.RemoveMCRButton.Text = "Удалить";
            this.RemoveMCRButton.UseVisualStyleBackColor = false;
            this.RemoveMCRButton.Click += new System.EventHandler(this.RemoveMCRButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchButton.Location = new System.Drawing.Point(226, 146);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(137, 42);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ComboBoxSort);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Location = new System.Drawing.Point(622, 403);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(448, 214);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
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
            // ComboBoxSort
            // 
            this.ComboBoxSort.FormattingEnabled = true;
            this.ComboBoxSort.Location = new System.Drawing.Point(35, 60);
            this.ComboBoxSort.Name = "ComboBoxSort";
            this.ComboBoxSort.Size = new System.Drawing.Size(231, 24);
            this.ComboBoxSort.TabIndex = 4;
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExportButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExportButton.Location = new System.Drawing.Point(748, 335);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(178, 51);
            this.ExportButton.TabIndex = 2;
            this.ExportButton.Text = "Экспортировать в Excel";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Фильтр:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(296, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 22);
            this.textBox1.TabIndex = 9;
            // 
            // MunicipalContractRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1103, 677);
            this.Controls.Add(this.RemoveMCRButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.MContractRegisterGBox);
            this.Controls.Add(this.MCRDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MunicipalContractRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты поиска контрактов";
            this.Load += new System.EventHandler(this.MunicipalContractRegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MCRDataGridView)).EndInit();
            this.MContractRegisterGBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MCRDataGridView;
        private System.Windows.Forms.GroupBox MContractRegisterGBox;
        private System.Windows.Forms.Button OpenMCRButton;
        private System.Windows.Forms.Button AddMCRButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBoxSort;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button RemoveMCRButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}