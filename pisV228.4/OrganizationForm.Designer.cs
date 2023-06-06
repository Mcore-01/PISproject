namespace pisV228._4
{
    partial class OrganizationForm
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
            this.buttonOFgroupbox = new System.Windows.Forms.GroupBox();
            this.AddOFButton = new System.Windows.Forms.Button();
            this.CloseOFButton = new System.Windows.Forms.Button();
            this.buttonOFgroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOFgroupbox
            // 
            this.buttonOFgroupbox.Controls.Add(this.AddOFButton);
            this.buttonOFgroupbox.Controls.Add(this.CloseOFButton);
            this.buttonOFgroupbox.Location = new System.Drawing.Point(449, 266);
            this.buttonOFgroupbox.Name = "buttonOFgroupbox";
            this.buttonOFgroupbox.Size = new System.Drawing.Size(142, 129);
            this.buttonOFgroupbox.TabIndex = 7;
            this.buttonOFgroupbox.TabStop = false;
            // 
            // AddOFButton
            // 
            this.AddOFButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddOFButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.AddOFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOFButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddOFButton.Location = new System.Drawing.Point(20, 19);
            this.AddOFButton.Name = "AddOFButton";
            this.AddOFButton.Size = new System.Drawing.Size(103, 34);
            this.AddOFButton.TabIndex = 1;
            this.AddOFButton.Text = "Добавить";
            this.AddOFButton.UseVisualStyleBackColor = false;
            this.AddOFButton.Click += new System.EventHandler(this.AddOFButton_Click);
            // 
            // CloseOFButton
            // 
            this.CloseOFButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseOFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseOFButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseOFButton.Location = new System.Drawing.Point(20, 73);
            this.CloseOFButton.Name = "CloseOFButton";
            this.CloseOFButton.Size = new System.Drawing.Size(103, 34);
            this.CloseOFButton.TabIndex = 3;
            this.CloseOFButton.Text = "Отмена";
            this.CloseOFButton.UseVisualStyleBackColor = false;
            // 
            // OrganizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 409);
            this.Controls.Add(this.buttonOFgroupbox);
            this.Name = "OrganizationForm";
            this.Text = "Карточки организации";
            this.Load += new System.EventHandler(this.OrganizationForm_Load);
            this.buttonOFgroupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox buttonOFgroupbox;
        private System.Windows.Forms.Button AddOFButton;
        private System.Windows.Forms.Button CloseOFButton;
    }
}