
namespace InterfataUtilizator
{
    partial class FormServicii
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
            this.btnInapoi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCauta = new System.Windows.Forms.Button();
            this.textCauta = new System.Windows.Forms.TextBox();
            this.tbxCauta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInapoi
            // 
            this.btnInapoi.Location = new System.Drawing.Point(428, 257);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(139, 23);
            this.btnInapoi.TabIndex = 0;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = true;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(399, 444);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(428, 124);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(139, 23);
            this.btnCauta.TabIndex = 2;
            this.btnCauta.Text = "Cauta ";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // textCauta
            // 
            this.textCauta.Location = new System.Drawing.Point(444, 83);
            this.textCauta.Name = "textCauta";
            this.textCauta.Size = new System.Drawing.Size(100, 22);
            this.textCauta.TabIndex = 3;
            // 
            // tbxCauta
            // 
            this.tbxCauta.Enabled = false;
            this.tbxCauta.Location = new System.Drawing.Point(428, 30);
            this.tbxCauta.Name = "tbxCauta";
            this.tbxCauta.Size = new System.Drawing.Size(139, 22);
            this.tbxCauta.TabIndex = 4;
            this.tbxCauta.Text = "Cauta serviciu";
            this.tbxCauta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormServicii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(996, 450);
            this.Controls.Add(this.tbxCauta);
            this.Controls.Add(this.textCauta);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnInapoi);
            this.Name = "FormServicii";
            this.Text = "FormServicii";
            this.Load += new System.EventHandler(this.FormServicii_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.TextBox textCauta;
        private System.Windows.Forms.TextBox tbxCauta;
    }
}