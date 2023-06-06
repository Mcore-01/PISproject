namespace pisV228._4
{
    partial class MunicipalContractForm
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
            this.buttonMCFgroupbox = new System.Windows.Forms.GroupBox();
            this.AddMCFButton = new System.Windows.Forms.Button();
            this.CloseMCFButton = new System.Windows.Forms.Button();
            this.buttonMCFgroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMCFgroupbox
            // 
            this.buttonMCFgroupbox.Controls.Add(this.AddMCFButton);
            this.buttonMCFgroupbox.Controls.Add(this.CloseMCFButton);
            this.buttonMCFgroupbox.Location = new System.Drawing.Point(587, 296);
            this.buttonMCFgroupbox.Name = "buttonMCFgroupbox";
            this.buttonMCFgroupbox.Size = new System.Drawing.Size(142, 129);
            this.buttonMCFgroupbox.TabIndex = 8;
            this.buttonMCFgroupbox.TabStop = false;
            // 
            // AddMCFButton
            // 
            this.AddMCFButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddMCFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddMCFButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddMCFButton.Location = new System.Drawing.Point(20, 19);
            this.AddMCFButton.Name = "AddMCFButton";
            this.AddMCFButton.Size = new System.Drawing.Size(103, 34);
            this.AddMCFButton.TabIndex = 1;
            this.AddMCFButton.Text = "Добавить";
            this.AddMCFButton.UseVisualStyleBackColor = false;
            // 
            // CloseMCFButton
            // 
            this.CloseMCFButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseMCFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseMCFButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseMCFButton.Location = new System.Drawing.Point(20, 73);
            this.CloseMCFButton.Name = "CloseMCFButton";
            this.CloseMCFButton.Size = new System.Drawing.Size(103, 34);
            this.CloseMCFButton.TabIndex = 3;
            this.CloseMCFButton.Text = "Отмена";
            this.CloseMCFButton.UseVisualStyleBackColor = false;
            // 
            // MunicipalContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMCFgroupbox);
            this.Name = "MunicipalContractForm";
            this.Text = "MunicipalContractForm";
            this.Load += new System.EventHandler(this.MunicipalContractForm_Load);
            this.buttonMCFgroupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox buttonMCFgroupbox;
        private System.Windows.Forms.Button AddMCFButton;
        private System.Windows.Forms.Button CloseMCFButton;
    }
}