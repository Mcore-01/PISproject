namespace pisV228._4
{
    partial class AnimalForm
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
            this.AFPictureBox = new System.Windows.Forms.PictureBox();
            this.AddAFButton = new System.Windows.Forms.Button();
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.CloseAFButton = new System.Windows.Forms.Button();
            this.AddMainShelterButton = new System.Windows.Forms.Button();
            this.MainShelterGroupBox = new System.Windows.Forms.GroupBox();
            this.OpenMainShelterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AFPictureBox)).BeginInit();
            this.MainShelterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AFPictureBox
            // 
            this.AFPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AFPictureBox.Location = new System.Drawing.Point(36, 317);
            this.AFPictureBox.Name = "AFPictureBox";
            this.AFPictureBox.Size = new System.Drawing.Size(171, 139);
            this.AFPictureBox.TabIndex = 0;
            this.AFPictureBox.TabStop = false;
            this.AFPictureBox.Click += new System.EventHandler(this.AFPictureBox_Click);
            // 
            // AddAFButton
            // 
            this.AddAFButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddAFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAFButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddAFButton.Location = new System.Drawing.Point(235, 317);
            this.AddAFButton.Name = "AddAFButton";
            this.AddAFButton.Size = new System.Drawing.Size(103, 34);
            this.AddAFButton.TabIndex = 1;
            this.AddAFButton.Text = "Сохранить";
            this.AddAFButton.UseVisualStyleBackColor = false;
            this.AddAFButton.Click += new System.EventHandler(this.AddAFButton_Click);
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoadImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadImageButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoadImageButton.Location = new System.Drawing.Point(71, 361);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Size = new System.Drawing.Size(103, 54);
            this.LoadImageButton.TabIndex = 2;
            this.LoadImageButton.Text = "Загрузить фото";
            this.LoadImageButton.UseVisualStyleBackColor = false;
            this.LoadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // CloseAFButton
            // 
            this.CloseAFButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseAFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseAFButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseAFButton.Location = new System.Drawing.Point(235, 371);
            this.CloseAFButton.Name = "CloseAFButton";
            this.CloseAFButton.Size = new System.Drawing.Size(103, 34);
            this.CloseAFButton.TabIndex = 3;
            this.CloseAFButton.Text = "Отмена";
            this.CloseAFButton.UseVisualStyleBackColor = false;
            this.CloseAFButton.Click += new System.EventHandler(this.CloseAFButton_Click);
            // 
            // AddMainShelterButton
            // 
            this.AddMainShelterButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddMainShelterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddMainShelterButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddMainShelterButton.Location = new System.Drawing.Point(20, 28);
            this.AddMainShelterButton.Name = "AddMainShelterButton";
            this.AddMainShelterButton.Size = new System.Drawing.Size(103, 34);
            this.AddMainShelterButton.TabIndex = 4;
            this.AddMainShelterButton.Text = "Добавить";
            this.AddMainShelterButton.UseVisualStyleBackColor = false;
            this.AddMainShelterButton.Click += new System.EventHandler(this.AddMainShelterButton_Click);
            // 
            // MainShelterGroupBox
            // 
            this.MainShelterGroupBox.Controls.Add(this.OpenMainShelterButton);
            this.MainShelterGroupBox.Controls.Add(this.AddMainShelterButton);
            this.MainShelterGroupBox.Location = new System.Drawing.Point(372, 317);
            this.MainShelterGroupBox.Name = "MainShelterGroupBox";
            this.MainShelterGroupBox.Size = new System.Drawing.Size(155, 123);
            this.MainShelterGroupBox.TabIndex = 5;
            this.MainShelterGroupBox.TabStop = false;
            this.MainShelterGroupBox.Text = "Содержание в приюте";
            // 
            // OpenMainShelterButton
            // 
            this.OpenMainShelterButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OpenMainShelterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenMainShelterButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OpenMainShelterButton.Location = new System.Drawing.Point(20, 68);
            this.OpenMainShelterButton.Name = "OpenMainShelterButton";
            this.OpenMainShelterButton.Size = new System.Drawing.Size(103, 34);
            this.OpenMainShelterButton.TabIndex = 5;
            this.OpenMainShelterButton.Text = "Открыть";
            this.OpenMainShelterButton.UseVisualStyleBackColor = false;
            this.OpenMainShelterButton.Click += new System.EventHandler(this.OpenMainShelterButton_Click);
            // 
            // AnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 512);
            this.Controls.Add(this.MainShelterGroupBox);
            this.Controls.Add(this.CloseAFButton);
            this.Controls.Add(this.LoadImageButton);
            this.Controls.Add(this.AddAFButton);
            this.Controls.Add(this.AFPictureBox);
            this.Name = "AnimalForm";
            this.Text = "AnimalForm";
            this.Load += new System.EventHandler(this.AnimalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AFPictureBox)).EndInit();
            this.MainShelterGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AFPictureBox;
        private System.Windows.Forms.Button AddAFButton;
        private System.Windows.Forms.Button LoadImageButton;
        private System.Windows.Forms.Button CloseAFButton;
        private System.Windows.Forms.Button AddMainShelterButton;
        private System.Windows.Forms.GroupBox MainShelterGroupBox;
        private System.Windows.Forms.Button OpenMainShelterButton;
    }
}