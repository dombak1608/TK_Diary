namespace TK_dnevnik
{
    partial class FormZdrijebDodavanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZdrijebDodavanje));
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.tbBrBodova = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbParovi = new System.Windows.Forms.RadioButton();
            this.rbSingl = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbGrupeNe = new System.Windows.Forms.RadioButton();
            this.rbGrupeDa = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBrIgraca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(78, 6);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(135, 20);
            this.tbNaziv.TabIndex = 0;
            // 
            // tbBrBodova
            // 
            this.tbBrBodova.Location = new System.Drawing.Point(78, 32);
            this.tbBrBodova.Name = "tbBrBodova";
            this.tbBrBodova.Size = new System.Drawing.Size(135, 20);
            this.tbBrBodova.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbParovi);
            this.groupBox1.Controls.Add(this.rbSingl);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(15, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(81, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Singl/parovi";
            // 
            // rbParovi
            // 
            this.rbParovi.AutoSize = true;
            this.rbParovi.Location = new System.Drawing.Point(6, 42);
            this.rbParovi.Name = "rbParovi";
            this.rbParovi.Size = new System.Drawing.Size(55, 17);
            this.rbParovi.TabIndex = 1;
            this.rbParovi.TabStop = true;
            this.rbParovi.Text = "Parovi";
            this.rbParovi.UseVisualStyleBackColor = true;
            this.rbParovi.CheckedChanged += new System.EventHandler(this.rbParovi_CheckedChanged);
            // 
            // rbSingl
            // 
            this.rbSingl.AutoSize = true;
            this.rbSingl.Location = new System.Drawing.Point(6, 19);
            this.rbSingl.Name = "rbSingl";
            this.rbSingl.Size = new System.Drawing.Size(48, 17);
            this.rbSingl.TabIndex = 0;
            this.rbSingl.TabStop = true;
            this.rbSingl.Text = "Singl";
            this.rbSingl.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbGrupeNe);
            this.groupBox2.Controls.Add(this.rbGrupeDa);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(112, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(101, 72);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grupe";
            // 
            // rbGrupeNe
            // 
            this.rbGrupeNe.AutoSize = true;
            this.rbGrupeNe.Location = new System.Drawing.Point(6, 19);
            this.rbGrupeNe.Name = "rbGrupeNe";
            this.rbGrupeNe.Size = new System.Drawing.Size(73, 17);
            this.rbGrupeNe.TabIndex = 3;
            this.rbGrupeNe.TabStop = true;
            this.rbGrupeNe.Text = "Bez grupa";
            this.rbGrupeNe.UseVisualStyleBackColor = true;
            // 
            // rbGrupeDa
            // 
            this.rbGrupeDa.AutoSize = true;
            this.rbGrupeDa.Location = new System.Drawing.Point(6, 42);
            this.rbGrupeDa.Name = "rbGrupeDa";
            this.rbGrupeDa.Size = new System.Drawing.Size(82, 17);
            this.rbGrupeDa.TabIndex = 2;
            this.rbGrupeDa.TabStop = true;
            this.rbGrupeDa.Text = "Sa grupama";
            this.rbGrupeDa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Broj bodova:";
            // 
            // tbBrIgraca
            // 
            this.tbBrIgraca.Location = new System.Drawing.Point(78, 58);
            this.tbBrIgraca.Name = "tbBrIgraca";
            this.tbBrIgraca.Size = new System.Drawing.Size(135, 20);
            this.tbBrIgraca.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Broj igrača:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(219, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 152);
            this.button1.TabIndex = 6;
            this.button1.Text = "Dodaj turnir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Datum:";
            // 
            // FormZdrijebDodavanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 191);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbBrIgraca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbBrBodova);
            this.Controls.Add(this.tbNaziv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormZdrijebDodavanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turnir";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormZdrijebDodavanje_FormClosed);
            this.Load += new System.EventHandler(this.FormZdrijebDodavanje_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.TextBox tbBrBodova;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbParovi;
        private System.Windows.Forms.RadioButton rbSingl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbGrupeNe;
        private System.Windows.Forms.RadioButton rbGrupeDa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBrIgraca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
    }
}