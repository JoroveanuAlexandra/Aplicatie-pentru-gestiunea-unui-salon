
namespace InterfataUtilizator
{
    partial class FormStart
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnProgramare = new System.Windows.Forms.Button();
            this.btnAngajati = new System.Windows.Forms.Button();
            this.btnServicii = new System.Windows.Forms.Button();
            this.tbxNumeS = new System.Windows.Forms.TextBox();
            this.buttonAdaugaSerivicu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnProgramare
            // 
            this.btnProgramare.Location = new System.Drawing.Point(201, 111);
            this.btnProgramare.Name = "btnProgramare";
            this.btnProgramare.Size = new System.Drawing.Size(261, 53);
            this.btnProgramare.TabIndex = 2;
            this.btnProgramare.Text = "Fa-ti o programare";
            this.btnProgramare.UseVisualStyleBackColor = true;
            this.btnProgramare.Click += new System.EventHandler(this.btnProgramare_Click);
            // 
            // btnAngajati
            // 
            this.btnAngajati.Location = new System.Drawing.Point(201, 196);
            this.btnAngajati.Name = "btnAngajati";
            this.btnAngajati.Size = new System.Drawing.Size(261, 52);
            this.btnAngajati.TabIndex = 3;
            this.btnAngajati.Text = "Vezi angajatii";
            this.btnAngajati.UseVisualStyleBackColor = true;
            this.btnAngajati.Click += new System.EventHandler(this.btnAngajati_Click);
            // 
            // btnServicii
            // 
            this.btnServicii.Location = new System.Drawing.Point(201, 273);
            this.btnServicii.Name = "btnServicii";
            this.btnServicii.Size = new System.Drawing.Size(261, 53);
            this.btnServicii.TabIndex = 4;
            this.btnServicii.Text = "Servicii disponibile";
            this.btnServicii.UseVisualStyleBackColor = true;
            this.btnServicii.Click += new System.EventHandler(this.btnServicii_Click);
            // 
            // tbxNumeS
            // 
            this.tbxNumeS.Enabled = false;
            this.tbxNumeS.Location = new System.Drawing.Point(179, 29);
            this.tbxNumeS.Name = "tbxNumeS";
            this.tbxNumeS.Size = new System.Drawing.Size(310, 22);
            this.tbxNumeS.TabIndex = 5;
            this.tbxNumeS.Text = "Salon Pixie";
            this.tbxNumeS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxNumeS.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonAdaugaSerivicu
            // 
            this.buttonAdaugaSerivicu.Location = new System.Drawing.Point(201, 352);
            this.buttonAdaugaSerivicu.Name = "buttonAdaugaSerivicu";
            this.buttonAdaugaSerivicu.Size = new System.Drawing.Size(261, 54);
            this.buttonAdaugaSerivicu.TabIndex = 6;
            this.buttonAdaugaSerivicu.Text = "Adauga Serviciu";
            this.buttonAdaugaSerivicu.UseVisualStyleBackColor = true;
            this.buttonAdaugaSerivicu.Click += new System.EventHandler(this.buttonAdaugaSerivicu_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdaugaSerivicu);
            this.Controls.Add(this.tbxNumeS);
            this.Controls.Add(this.btnServicii);
            this.Controls.Add(this.btnAngajati);
            this.Controls.Add(this.btnProgramare);
            this.Name = "FormStart";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnProgramare;
        private System.Windows.Forms.Button btnAngajati;
        private System.Windows.Forms.Button btnServicii;
        private System.Windows.Forms.TextBox tbxNumeS;
        private System.Windows.Forms.Button buttonAdaugaSerivicu;
    }
}