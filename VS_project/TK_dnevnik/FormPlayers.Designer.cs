namespace TK_dnevnik
{
    partial class FormPlayers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlayers));
            this.dataGridViewPlayers = new System.Windows.Forms.DataGridView();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbVisina = new System.Windows.Forms.TextBox();
            this.tbGlavnoOruzje = new System.Windows.Forms.TextBox();
            this.cbDesnjakLjevak = new System.Windows.Forms.ComboBox();
            this.cbDvorucniJednorucni = new System.Windows.Forms.ComboBox();
            this.tbClanOd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.database1DataSet = new TK_dnevnik.database1DataSet();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPlayers
            // 
            this.dataGridViewPlayers.AllowUserToAddRows = false;
            this.dataGridViewPlayers.AllowUserToDeleteRows = false;
            this.dataGridViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridViewPlayers.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPlayers.Name = "dataGridViewPlayers";
            this.dataGridViewPlayers.ShowEditingIcon = false;
            this.dataGridViewPlayers.Size = new System.Drawing.Size(843, 553);
            this.dataGridViewPlayers.TabIndex = 10;
            this.dataGridViewPlayers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPlayers_RowHeaderMouseClick);
            this.dataGridViewPlayers.SelectionChanged += new System.EventHandler(this.dataGridViewPlayers_SelectionChanged);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(1075, 27);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 55);
            this.buttonInsert.TabIndex = 7;
            this.buttonInsert.Text = "Upiši novog";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(1075, 87);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 55);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Izmjeni odabranog";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1075, 149);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 56);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Obriši odabranog";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(969, 27);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(100, 20);
            this.tbIme.TabIndex = 0;
            this.tbIme.Text = "Ivan";
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(969, 53);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(100, 20);
            this.tbPrezime.TabIndex = 1;
            this.tbPrezime.Text = "Horvat";
            // 
            // tbVisina
            // 
            this.tbVisina.Location = new System.Drawing.Point(969, 79);
            this.tbVisina.Name = "tbVisina";
            this.tbVisina.Size = new System.Drawing.Size(100, 20);
            this.tbVisina.TabIndex = 2;
            this.tbVisina.Text = "180";
            // 
            // tbGlavnoOruzje
            // 
            this.tbGlavnoOruzje.Location = new System.Drawing.Point(969, 159);
            this.tbGlavnoOruzje.Name = "tbGlavnoOruzje";
            this.tbGlavnoOruzje.Size = new System.Drawing.Size(100, 20);
            this.tbGlavnoOruzje.TabIndex = 5;
            this.tbGlavnoOruzje.Text = "Forhend";
            // 
            // cbDesnjakLjevak
            // 
            this.cbDesnjakLjevak.FormattingEnabled = true;
            this.cbDesnjakLjevak.Items.AddRange(new object[] {
            "Dešnjak",
            "Ljevak"});
            this.cbDesnjakLjevak.Location = new System.Drawing.Point(969, 105);
            this.cbDesnjakLjevak.Name = "cbDesnjakLjevak";
            this.cbDesnjakLjevak.Size = new System.Drawing.Size(100, 21);
            this.cbDesnjakLjevak.TabIndex = 3;
            this.cbDesnjakLjevak.Text = "Dešnjak";
            // 
            // cbDvorucniJednorucni
            // 
            this.cbDvorucniJednorucni.FormattingEnabled = true;
            this.cbDvorucniJednorucni.Items.AddRange(new object[] {
            "Dvoručni",
            "Jednoručni"});
            this.cbDvorucniJednorucni.Location = new System.Drawing.Point(969, 132);
            this.cbDvorucniJednorucni.Name = "cbDvorucniJednorucni";
            this.cbDvorucniJednorucni.Size = new System.Drawing.Size(100, 21);
            this.cbDvorucniJednorucni.TabIndex = 4;
            this.cbDvorucniJednorucni.Text = "Dvoručni";
            // 
            // tbClanOd
            // 
            this.tbClanOd.Location = new System.Drawing.Point(969, 185);
            this.tbClanOd.Name = "tbClanOd";
            this.tbClanOd.Size = new System.Drawing.Size(100, 20);
            this.tbClanOd.TabIndex = 6;
            this.tbClanOd.Text = "2010";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(936, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(916, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(925, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Visina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(880, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Dešnjak/Ljevak";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(916, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Bekend:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(888, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Glavno oružje:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(888, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Član kluba od:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(994, 11);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(13, 13);
            this.labelID.TabIndex = 18;
            this.labelID.Text = "0";
            this.labelID.TextChanged += new System.EventHandler(this.labelID_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(880, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Redni broj odabranog:";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // FormPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 580);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbClanOd);
            this.Controls.Add(this.cbDvorucniJednorucni);
            this.Controls.Add(this.cbDesnjakLjevak);
            this.Controls.Add(this.tbGlavnoOruzje);
            this.Controls.Add(this.tbVisina);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.dataGridViewPlayers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPlayers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Igrači";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPlayers_FormClosed);
            this.Load += new System.EventHandler(this.FormPlayers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbVisina;
        private System.Windows.Forms.TextBox tbGlavnoOruzje;
        private System.Windows.Forms.ComboBox cbDesnjakLjevak;
        private System.Windows.Forms.ComboBox cbDvorucniJednorucni;
        private System.Windows.Forms.TextBox tbClanOd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewPlayers;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private database1DataSet database1DataSet;
    }
}