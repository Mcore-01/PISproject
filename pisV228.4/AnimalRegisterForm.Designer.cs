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
            this.OpenARButton = new System.Windows.Forms.Button();
            this.AddARButton = new System.Windows.Forms.Button();
            this.ARDataGridView = new System.Windows.Forms.DataGridView();
            this.AnimalRegiterGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ARDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AnimalRegiterGBox
            // 
            this.AnimalRegiterGBox.Controls.Add(this.OpenARButton);
            this.AnimalRegiterGBox.Controls.Add(this.AddARButton);
            this.AnimalRegiterGBox.Location = new System.Drawing.Point(559, 36);
            this.AnimalRegiterGBox.Name = "AnimalRegiterGBox";
            this.AnimalRegiterGBox.Size = new System.Drawing.Size(262, 258);
            this.AnimalRegiterGBox.TabIndex = 0;
            this.AnimalRegiterGBox.TabStop = false;
            // 
            // OpenARButton
            // 
            this.OpenARButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OpenARButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenARButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OpenARButton.Location = new System.Drawing.Point(60, 93);
            this.OpenARButton.Name = "OpenARButton";
            this.OpenARButton.Size = new System.Drawing.Size(103, 34);
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
            this.AddARButton.Location = new System.Drawing.Point(60, 30);
            this.AddARButton.Name = "AddARButton";
            this.AddARButton.Size = new System.Drawing.Size(103, 34);
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
            this.ARDataGridView.Name = "ARDataGridView";
            this.ARDataGridView.ReadOnly = true;
            this.ARDataGridView.RowHeadersVisible = false;
            this.ARDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ARDataGridView.Size = new System.Drawing.Size(431, 530);
            this.ARDataGridView.TabIndex = 1;
            // 
            // AnimalRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 530);
            this.Controls.Add(this.ARDataGridView);
            this.Controls.Add(this.AnimalRegiterGBox);
            this.Name = "AnimalRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnimalRegisterForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AnimalRegisterForm_FormClosed);
            this.Load += new System.EventHandler(this.AnimalRegisterForm_Load);
            this.AnimalRegiterGBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ARDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AnimalRegiterGBox;
        private System.Windows.Forms.Button OpenARButton;
        private System.Windows.Forms.Button AddARButton;
        private System.Windows.Forms.DataGridView ARDataGridView;
    }
}

