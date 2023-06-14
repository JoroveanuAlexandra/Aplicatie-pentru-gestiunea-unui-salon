
namespace InterfataUtilizator
{
    partial class FormProgramare
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
            this.tbxProgramare = new System.Windows.Forms.TextBox();
            this.tbxServiciu = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listBoxAngajati = new System.Windows.Forms.ListBox();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.listBoxServicii = new System.Windows.Forms.ListBox();
            this.textBoxNumeClient = new System.Windows.Forms.TextBox();
            this.tbxNume = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbxProgramare
            // 
            this.tbxProgramare.Enabled = false;
            this.tbxProgramare.Location = new System.Drawing.Point(293, 12);
            this.tbxProgramare.Name = "tbxProgramare";
            this.tbxProgramare.Size = new System.Drawing.Size(165, 22);
            this.tbxProgramare.TabIndex = 2;
            this.tbxProgramare.Text = "Fa-ti o programare";
            this.tbxProgramare.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbxServiciu
            // 
            this.tbxServiciu.Enabled = false;
            this.tbxServiciu.Location = new System.Drawing.Point(36, 97);
            this.tbxServiciu.Name = "tbxServiciu";
            this.tbxServiciu.Size = new System.Drawing.Size(165, 22);
            this.tbxServiciu.TabIndex = 3;
            this.tbxServiciu.Text = "Serviciu";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(36, 217);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Angajat";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(36, 322);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 22);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "Data programarii";
            // 
            // btnInapoi
            // 
            this.btnInapoi.Location = new System.Drawing.Point(36, 421);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(165, 23);
            this.btnInapoi.TabIndex = 13;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = true;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(237, 322);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(221, 22);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // listBoxAngajati
            // 
            this.listBoxAngajati.FormattingEnabled = true;
            this.listBoxAngajati.ItemHeight = 16;
            this.listBoxAngajati.Location = new System.Drawing.Point(237, 216);
            this.listBoxAngajati.Name = "listBoxAngajati";
            this.listBoxAngajati.Size = new System.Drawing.Size(221, 84);
            this.listBoxAngajati.TabIndex = 16;
            this.listBoxAngajati.SelectedIndexChanged += new System.EventHandler(this.listBoxAngajati_SelectedIndexChanged_1);
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.Location = new System.Drawing.Point(36, 380);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(165, 23);
            this.buttonAdauga.TabIndex = 17;
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.UseVisualStyleBackColor = true;
            this.buttonAdauga.Click += new System.EventHandler(this.buttonAdauga_Click);
            // 
            // listBoxServicii
            // 
            this.listBoxServicii.FormattingEnabled = true;
            this.listBoxServicii.ItemHeight = 16;
            this.listBoxServicii.Location = new System.Drawing.Point(237, 97);
            this.listBoxServicii.Name = "listBoxServicii";
            this.listBoxServicii.Size = new System.Drawing.Size(117, 84);
            this.listBoxServicii.TabIndex = 18;
            this.listBoxServicii.SelectedIndexChanged += new System.EventHandler(this.listBoxServicii_SelectedIndexChanged);
            // 
            // textBoxNumeClient
            // 
            this.textBoxNumeClient.Enabled = false;
            this.textBoxNumeClient.Location = new System.Drawing.Point(36, 55);
            this.textBoxNumeClient.Name = "textBoxNumeClient";
            this.textBoxNumeClient.Size = new System.Drawing.Size(165, 22);
            this.textBoxNumeClient.TabIndex = 19;
            this.textBoxNumeClient.Text = "Nume client";
            // 
            // tbxNume
            // 
            this.tbxNume.Location = new System.Drawing.Point(237, 55);
            this.tbxNume.Name = "tbxNume";
            this.tbxNume.Size = new System.Drawing.Size(221, 22);
            this.tbxNume.TabIndex = 20;
            this.tbxNume.TextChanged += new System.EventHandler(this.tbxNume_TextChanged);
            // 
            // FormProgramare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(758, 469);
            this.Controls.Add(this.tbxNume);
            this.Controls.Add(this.textBoxNumeClient);
            this.Controls.Add(this.listBoxServicii);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.listBoxAngajati);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbxServiciu);
            this.Controls.Add(this.tbxProgramare);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormProgramare";
            this.Text = "FormProgramare";
            this.Load += new System.EventHandler(this.FormProgramare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxProgramare;
        private System.Windows.Forms.TextBox tbxServiciu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnInapoi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBoxAngajati;
        private System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.ListBox listBoxServicii;
        private System.Windows.Forms.TextBox textBoxNumeClient;
        private System.Windows.Forms.TextBox tbxNume;
    }
}