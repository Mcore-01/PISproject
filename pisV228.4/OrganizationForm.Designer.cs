﻿namespace pisV228._4
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
            this.ChangeGroupBox = new System.Windows.Forms.GroupBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelChangeButton = new System.Windows.Forms.Button();
            this.buttonOFgroupbox.SuspendLayout();
            this.ChangeGroupBox.SuspendLayout();
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
            // ChangeGroupBox
            // 
            this.ChangeGroupBox.Controls.Add(this.CancelChangeButton);
            this.ChangeGroupBox.Controls.Add(this.ChangeButton);
            this.ChangeGroupBox.Controls.Add(this.SaveButton);
            this.ChangeGroupBox.Location = new System.Drawing.Point(295, 266);
            this.ChangeGroupBox.Name = "ChangeGroupBox";
            this.ChangeGroupBox.Size = new System.Drawing.Size(118, 128);
            this.ChangeGroupBox.TabIndex = 8;
            this.ChangeGroupBox.TabStop = false;
            // 
            // ChangeButton
            // 
            this.ChangeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ChangeButton.Location = new System.Drawing.Point(6, 48);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(103, 34);
            this.ChangeButton.TabIndex = 4;
            this.ChangeButton.Text = " Изменить";
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveButton.Location = new System.Drawing.Point(6, 19);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(103, 34);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelChangeButton
            // 
            this.CancelChangeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelChangeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelChangeButton.Location = new System.Drawing.Point(6, 73);
            this.CancelChangeButton.Name = "CancelChangeButton";
            this.CancelChangeButton.Size = new System.Drawing.Size(103, 34);
            this.CancelChangeButton.TabIndex = 10;
            this.CancelChangeButton.Text = "Отмена";
            this.CancelChangeButton.UseVisualStyleBackColor = false;
            this.CancelChangeButton.Visible = false;
            this.CancelChangeButton.Click += new System.EventHandler(this.CancelChangeButton_Click);
            // 
            // OrganizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 409);
            this.Controls.Add(this.ChangeGroupBox);
            this.Controls.Add(this.buttonOFgroupbox);
            this.Name = "OrganizationForm";
            this.Text = "Карточки организации";
            this.Load += new System.EventHandler(this.OrganizationForm_Load);
            this.buttonOFgroupbox.ResumeLayout(false);
            this.ChangeGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox buttonOFgroupbox;
        private System.Windows.Forms.Button AddOFButton;
        private System.Windows.Forms.Button CloseOFButton;
        private System.Windows.Forms.GroupBox ChangeGroupBox;
        private System.Windows.Forms.Button CancelChangeButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Button SaveButton;
    }
}