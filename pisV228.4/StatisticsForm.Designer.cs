
namespace pisV228._4
{
    partial class Statistic
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
            this.start = new System.Windows.Forms.DateTimePicker();
            this.end = new System.Windows.Forms.DateTimePicker();
            this.location = new System.Windows.Forms.TextBox();
            this.OkBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ExBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(103, 53);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(160, 22);
            this.start.TabIndex = 0;
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(323, 53);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(151, 22);
            this.end.TabIndex = 1;
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(103, 115);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(160, 22);
            this.location.TabIndex = 2;
            // 
            // OkBut
            // 
            this.OkBut.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkBut.Location = new System.Drawing.Point(323, 115);
            this.OkBut.Name = "OkBut";
            this.OkBut.Size = new System.Drawing.Size(68, 35);
            this.OkBut.TabIndex = 3;
            this.OkBut.Text = "ОК";
            this.OkBut.UseVisualStyleBackColor = true;
            this.OkBut.Click += new System.EventHandler(this.OkBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Город:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(66, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "С:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(276, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "По:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(700, 325);
            this.dataGridView1.TabIndex = 7;
            // 
            // ExBut
            // 
            this.ExBut.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ExBut.Location = new System.Drawing.Point(424, 115);
            this.ExBut.Name = "ExBut";
            this.ExBut.Size = new System.Drawing.Size(68, 35);
            this.ExBut.TabIndex = 8;
            this.ExBut.Text = "Excel";
            this.ExBut.UseVisualStyleBackColor = true;
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 572);
            this.Controls.Add(this.ExBut);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OkBut);
            this.Controls.Add(this.location);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Name = "Statistic";
            this.Text = "Статистика";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker start;
        private System.Windows.Forms.DateTimePicker end;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.Button OkBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ExBut;
    }
}