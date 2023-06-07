namespace pisV228._4
{
    partial class MaintenanceShelterForm
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
            this.AddMSFButton = new System.Windows.Forms.Button();
            this.CloseMSFButton = new System.Windows.Forms.Button();
            this.PrevButtonMS = new System.Windows.Forms.Button();
            this.NextButtonMS = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AddMSFButton
            // 
            this.AddMSFButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddMSFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddMSFButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddMSFButton.Location = new System.Drawing.Point(421, 364);
            this.AddMSFButton.Name = "AddMSFButton";
            this.AddMSFButton.Size = new System.Drawing.Size(103, 34);
            this.AddMSFButton.TabIndex = 1;
            this.AddMSFButton.Text = "Добавить";
            this.AddMSFButton.UseVisualStyleBackColor = false;
            this.AddMSFButton.Click += new System.EventHandler(this.AddMSFButton_Click);
            // 
            // CloseMSFButton
            // 
            this.CloseMSFButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseMSFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseMSFButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseMSFButton.Location = new System.Drawing.Point(547, 364);
            this.CloseMSFButton.Name = "CloseMSFButton";
            this.CloseMSFButton.Size = new System.Drawing.Size(103, 34);
            this.CloseMSFButton.TabIndex = 4;
            this.CloseMSFButton.Text = "Отмена";
            this.CloseMSFButton.UseVisualStyleBackColor = false;
            this.CloseMSFButton.Click += new System.EventHandler(this.CloseMSFButton_Click);
            // 
            // PrevButtonMS
            // 
            this.PrevButtonMS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PrevButtonMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrevButtonMS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PrevButtonMS.Location = new System.Drawing.Point(25, 281);
            this.PrevButtonMS.Name = "PrevButtonMS";
            this.PrevButtonMS.Size = new System.Drawing.Size(103, 34);
            this.PrevButtonMS.TabIndex = 5;
            this.PrevButtonMS.Text = "Предыдущая";
            this.PrevButtonMS.UseVisualStyleBackColor = false;
            this.PrevButtonMS.Click += new System.EventHandler(this.PrevButtonMS_Click);
            // 
            // NextButtonMS
            // 
            this.NextButtonMS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NextButtonMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextButtonMS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NextButtonMS.Location = new System.Drawing.Point(603, 281);
            this.NextButtonMS.Name = "NextButtonMS";
            this.NextButtonMS.Size = new System.Drawing.Size(103, 34);
            this.NextButtonMS.TabIndex = 6;
            this.NextButtonMS.Text = "Следующая";
            this.NextButtonMS.UseVisualStyleBackColor = false;
            this.NextButtonMS.Click += new System.EventHandler(this.NetxButtonMS_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(360, 164);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(361, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // MaintenanceShelterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.NextButtonMS);
            this.Controls.Add(this.PrevButtonMS);
            this.Controls.Add(this.CloseMSFButton);
            this.Controls.Add(this.AddMSFButton);
            this.Name = "MaintenanceShelterForm";
            this.Text = "MaintenanceShelter";
            this.Load += new System.EventHandler(this.MaintenanceShelter_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddMSFButton;
        private System.Windows.Forms.Button CloseMSFButton;
        private System.Windows.Forms.Button PrevButtonMS;
        private System.Windows.Forms.Button NextButtonMS;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}