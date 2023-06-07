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
            this.RemoveMCRButton = new System.Windows.Forms.Button();
            this.OpenMCRButton = new System.Windows.Forms.Button();
            this.AddMCRButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MCRDataGridView)).BeginInit();
            this.MContractRegisterGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MCRDataGridView
            // 
            this.MCRDataGridView.AllowUserToAddRows = false;
            this.MCRDataGridView.AllowUserToDeleteRows = false;
            this.MCRDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MCRDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.MCRDataGridView.Location = new System.Drawing.Point(0, 0);
            this.MCRDataGridView.Name = "MCRDataGridView";
            this.MCRDataGridView.ReadOnly = true;
            this.MCRDataGridView.RowHeadersVisible = false;
            this.MCRDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MCRDataGridView.Size = new System.Drawing.Size(431, 550);
            this.MCRDataGridView.TabIndex = 3;
            // 
            // MContractRegisterGBox
            // 
            this.MContractRegisterGBox.Controls.Add(this.RemoveMCRButton);
            this.MContractRegisterGBox.Controls.Add(this.OpenMCRButton);
            this.MContractRegisterGBox.Controls.Add(this.AddMCRButton);
            this.MContractRegisterGBox.Location = new System.Drawing.Point(517, 53);
            this.MContractRegisterGBox.Name = "MContractRegisterGBox";
            this.MContractRegisterGBox.Size = new System.Drawing.Size(228, 218);
            this.MContractRegisterGBox.TabIndex = 4;
            this.MContractRegisterGBox.TabStop = false;
            // 
            // RemoveMCRButton
            // 
            this.RemoveMCRButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RemoveMCRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveMCRButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveMCRButton.Location = new System.Drawing.Point(60, 156);
            this.RemoveMCRButton.Name = "RemoveMCRButton";
            this.RemoveMCRButton.Size = new System.Drawing.Size(103, 34);
            this.RemoveMCRButton.TabIndex = 2;
            this.RemoveMCRButton.Text = "Удалить";
            this.RemoveMCRButton.UseVisualStyleBackColor = false;
            this.RemoveMCRButton.Click += new System.EventHandler(this.RemoveMCRButton_Click);
            // 
            // OpenMCRButton
            // 
            this.OpenMCRButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OpenMCRButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenMCRButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OpenMCRButton.Location = new System.Drawing.Point(60, 93);
            this.OpenMCRButton.Name = "OpenMCRButton";
            this.OpenMCRButton.Size = new System.Drawing.Size(103, 34);
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
            this.AddMCRButton.Location = new System.Drawing.Point(60, 30);
            this.AddMCRButton.Name = "AddMCRButton";
            this.AddMCRButton.Size = new System.Drawing.Size(103, 34);
            this.AddMCRButton.TabIndex = 0;
            this.AddMCRButton.Text = "Добавить";
            this.AddMCRButton.UseVisualStyleBackColor = false;
            this.AddMCRButton.Click += new System.EventHandler(this.AddMCRButton_Click);
            // 
            // MunicipalContractRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(827, 550);
            this.Controls.Add(this.MContractRegisterGBox);
            this.Controls.Add(this.MCRDataGridView);
            this.Name = "MunicipalContractRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты поиска контрактов";
            this.Load += new System.EventHandler(this.MunicipalContractRegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MCRDataGridView)).EndInit();
            this.MContractRegisterGBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MCRDataGridView;
        private System.Windows.Forms.GroupBox MContractRegisterGBox;
        private System.Windows.Forms.Button OpenMCRButton;
        private System.Windows.Forms.Button AddMCRButton;
        private System.Windows.Forms.Button RemoveMCRButton;
    }
}