namespace TK_dnevnik
{
    partial class FormTournaments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTournaments));
            this.dataGridViewTournaments = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTournaments)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTournaments
            // 
            this.dataGridViewTournaments.AllowUserToAddRows = false;
            this.dataGridViewTournaments.AllowUserToDeleteRows = false;
            this.dataGridViewTournaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTournaments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridViewTournaments.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTournaments.Name = "dataGridViewTournaments";
            this.dataGridViewTournaments.ShowEditingIcon = false;
            this.dataGridViewTournaments.Size = new System.Drawing.Size(744, 482);
            this.dataGridViewTournaments.TabIndex = 11;
            this.dataGridViewTournaments.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTournaments_RowHeaderMouseClick);
            this.dataGridViewTournaments.SelectionChanged += new System.EventHandler(this.dataGridViewTournaments_SelectionChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(762, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Redni broj odabranog:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(873, 13);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(13, 13);
            this.labelID.TabIndex = 37;
            this.labelID.Text = "0";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(927, 36);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 56);
            this.buttonDelete.TabIndex = 29;
            this.buttonDelete.Text = "Obriši odabran";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(846, 37);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 55);
            this.buttonUpdate.TabIndex = 28;
            this.buttonUpdate.Text = "Izmjeni odabran";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(765, 37);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 55);
            this.buttonInsert.TabIndex = 27;
            this.buttonInsert.Text = "Dodaj novi";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // FormTournaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 507);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.dataGridViewTournaments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormTournaments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turniri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTournaments_FormClosed);
            this.Load += new System.EventHandler(this.FormTournaments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTournaments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTournaments;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonInsert;
    }
}