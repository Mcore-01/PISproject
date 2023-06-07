namespace pisV228._4
{
    partial class MainFormApplication
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
            this.ContractButton = new System.Windows.Forms.Button();
            this.OrganizationButton = new System.Windows.Forms.Button();
            this.AnimalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContractButton
            // 
            this.ContractButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ContractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContractButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ContractButton.Location = new System.Drawing.Point(33, 242);
            this.ContractButton.Name = "ContractButton";
            this.ContractButton.Size = new System.Drawing.Size(212, 34);
            this.ContractButton.TabIndex = 2;
            this.ContractButton.Text = "Реестр контрактов";
            this.ContractButton.UseVisualStyleBackColor = false;
            this.ContractButton.Click += new System.EventHandler(this.ContractButton_Click);
            // 
            // OrganizationButton
            // 
            this.OrganizationButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrganizationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrganizationButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OrganizationButton.Location = new System.Drawing.Point(33, 179);
            this.OrganizationButton.Name = "OrganizationButton";
            this.OrganizationButton.Size = new System.Drawing.Size(212, 34);
            this.OrganizationButton.TabIndex = 1;
            this.OrganizationButton.Text = "Реестр организаций";
            this.OrganizationButton.UseVisualStyleBackColor = false;
            this.OrganizationButton.Click += new System.EventHandler(this.OrganizationButton_Click);
            // 
            // AnimalButton
            // 
            this.AnimalButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AnimalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnimalButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AnimalButton.Location = new System.Drawing.Point(33, 116);
            this.AnimalButton.Name = "AnimalButton";
            this.AnimalButton.Size = new System.Drawing.Size(212, 34);
            this.AnimalButton.TabIndex = 0;
            this.AnimalButton.Text = "Реестр животных";
            this.AnimalButton.UseVisualStyleBackColor = false;
            this.AnimalButton.Click += new System.EventHandler(this.AnimalButton_Click);
            // 
            // MainFormApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 430);
            this.Controls.Add(this.ContractButton);
            this.Controls.Add(this.OrganizationButton);
            this.Controls.Add(this.AnimalButton);
            this.Name = "MainFormApplication";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Главная форма";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ContractButton;
        private System.Windows.Forms.Button OrganizationButton;
        private System.Windows.Forms.Button AnimalButton;
    }
}