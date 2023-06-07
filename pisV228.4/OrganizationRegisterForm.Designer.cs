namespace pisV228._4
{
    partial class OrganizationRegisterForm
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
            this.ORDataGridView = new System.Windows.Forms.DataGridView();
            this.OrganizationRegisterGBox = new System.Windows.Forms.GroupBox();
            this.RemoveORButton = new System.Windows.Forms.Button();
            this.OpenORButton = new System.Windows.Forms.Button();
            this.AddORButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ORDataGridView)).BeginInit();
            this.OrganizationRegisterGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ORDataGridView
            // 
            this.ORDataGridView.AllowUserToAddRows = false;
            this.ORDataGridView.AllowUserToDeleteRows = false;
            this.ORDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ORDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.ORDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ORDataGridView.Name = "ORDataGridView";
            this.ORDataGridView.ReadOnly = true;
            this.ORDataGridView.RowHeadersVisible = false;
            this.ORDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ORDataGridView.Size = new System.Drawing.Size(431, 530);
            this.ORDataGridView.TabIndex = 2;
            // 
            // OrganizationRegisterGBox
            // 
            this.OrganizationRegisterGBox.Controls.Add(this.RemoveORButton);
            this.OrganizationRegisterGBox.Controls.Add(this.OpenORButton);
            this.OrganizationRegisterGBox.Controls.Add(this.AddORButton);
            this.OrganizationRegisterGBox.Location = new System.Drawing.Point(533, 49);
            this.OrganizationRegisterGBox.Name = "OrganizationRegisterGBox";
            this.OrganizationRegisterGBox.Size = new System.Drawing.Size(228, 212);
            this.OrganizationRegisterGBox.TabIndex = 3;
            this.OrganizationRegisterGBox.TabStop = false;
            // 
            // RemoveORButton
            // 
            this.RemoveORButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RemoveORButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveORButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveORButton.Location = new System.Drawing.Point(60, 155);
            this.RemoveORButton.Name = "RemoveORButton";
            this.RemoveORButton.Size = new System.Drawing.Size(103, 34);
            this.RemoveORButton.TabIndex = 2;
            this.RemoveORButton.Text = "Удалить";
            this.RemoveORButton.UseVisualStyleBackColor = false;
            this.RemoveORButton.Click += new System.EventHandler(this.RemoveORButton_Click);
            // 
            // OpenORButton
            // 
            this.OpenORButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OpenORButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenORButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OpenORButton.Location = new System.Drawing.Point(60, 93);
            this.OpenORButton.Name = "OpenORButton";
            this.OpenORButton.Size = new System.Drawing.Size(103, 34);
            this.OpenORButton.TabIndex = 1;
            this.OpenORButton.Text = "Открыть";
            this.OpenORButton.UseVisualStyleBackColor = false;
            this.OpenORButton.Click += new System.EventHandler(this.OpenORButton_Click);
            // 
            // AddORButton
            // 
            this.AddORButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddORButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddORButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddORButton.Location = new System.Drawing.Point(60, 30);
            this.AddORButton.Name = "AddORButton";
            this.AddORButton.Size = new System.Drawing.Size(103, 34);
            this.AddORButton.TabIndex = 0;
            this.AddORButton.Text = "Добавить";
            this.AddORButton.UseVisualStyleBackColor = false;
            this.AddORButton.Click += new System.EventHandler(this.AddORButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExportButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExportButton.Location = new System.Drawing.Point(575, 266);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(135, 45);
            this.ExportButton.TabIndex = 4;
            this.ExportButton.Text = "Экспортировать в Excel";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // OrganizationRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(844, 530);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.OrganizationRegisterGBox);
            this.Controls.Add(this.ORDataGridView);
            this.Name = "OrganizationRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты поиска организации";
            this.Load += new System.EventHandler(this.OrganizationRegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ORDataGridView)).EndInit();
            this.OrganizationRegisterGBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ORDataGridView;
        private System.Windows.Forms.GroupBox OrganizationRegisterGBox;
        private System.Windows.Forms.Button OpenORButton;
        private System.Windows.Forms.Button AddORButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button RemoveORButton;
    }
}