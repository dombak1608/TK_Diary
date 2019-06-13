namespace TK_dnevnik
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.općenitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osvježiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zatvoriAplikacijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaPodatakaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spremiPromjeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preuzmiPromjeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlayers = new System.Windows.Forms.Button();
            this.btnTournaments = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnStandings = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.općenitoToolStripMenuItem,
            this.bazaPodatakaToolStripMenuItem,
            this.pomocToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // općenitoToolStripMenuItem
            // 
            this.općenitoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osvježiToolStripMenuItem,
            this.zatvoriAplikacijuToolStripMenuItem});
            this.općenitoToolStripMenuItem.Name = "općenitoToolStripMenuItem";
            resources.ApplyResources(this.općenitoToolStripMenuItem, "općenitoToolStripMenuItem");
            // 
            // osvježiToolStripMenuItem
            // 
            this.osvježiToolStripMenuItem.Name = "osvježiToolStripMenuItem";
            resources.ApplyResources(this.osvježiToolStripMenuItem, "osvježiToolStripMenuItem");
            // 
            // zatvoriAplikacijuToolStripMenuItem
            // 
            this.zatvoriAplikacijuToolStripMenuItem.Name = "zatvoriAplikacijuToolStripMenuItem";
            resources.ApplyResources(this.zatvoriAplikacijuToolStripMenuItem, "zatvoriAplikacijuToolStripMenuItem");
            this.zatvoriAplikacijuToolStripMenuItem.Click += new System.EventHandler(this.zatvoriAplikacijuToolStripMenuItem_Click);
            // 
            // bazaPodatakaToolStripMenuItem
            // 
            this.bazaPodatakaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spremiPromjeneToolStripMenuItem,
            this.preuzmiPromjeneToolStripMenuItem});
            this.bazaPodatakaToolStripMenuItem.Name = "bazaPodatakaToolStripMenuItem";
            resources.ApplyResources(this.bazaPodatakaToolStripMenuItem, "bazaPodatakaToolStripMenuItem");
            // 
            // spremiPromjeneToolStripMenuItem
            // 
            this.spremiPromjeneToolStripMenuItem.Name = "spremiPromjeneToolStripMenuItem";
            resources.ApplyResources(this.spremiPromjeneToolStripMenuItem, "spremiPromjeneToolStripMenuItem");
            // 
            // preuzmiPromjeneToolStripMenuItem
            // 
            this.preuzmiPromjeneToolStripMenuItem.Name = "preuzmiPromjeneToolStripMenuItem";
            resources.ApplyResources(this.preuzmiPromjeneToolStripMenuItem, "preuzmiPromjeneToolStripMenuItem");
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            resources.ApplyResources(this.pomocToolStripMenuItem, "pomocToolStripMenuItem");
            // 
            // btnPlayers
            // 
            resources.ApplyResources(this.btnPlayers, "btnPlayers");
            this.btnPlayers.Name = "btnPlayers";
            this.btnPlayers.UseVisualStyleBackColor = true;
            this.btnPlayers.Click += new System.EventHandler(this.btnPlayers_Click);
            // 
            // btnTournaments
            // 
            resources.ApplyResources(this.btnTournaments, "btnTournaments");
            this.btnTournaments.Name = "btnTournaments";
            this.btnTournaments.UseVisualStyleBackColor = true;
            this.btnTournaments.Click += new System.EventHandler(this.btnTournaments_Click);
            // 
            // btnStatistics
            // 
            resources.ApplyResources(this.btnStatistics, "btnStatistics");
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            // 
            // btnStandings
            // 
            resources.ApplyResources(this.btnStandings, "btnStandings");
            this.btnStandings.Name = "btnStandings";
            this.btnStandings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.btnTournaments, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnStandings, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPlayers, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStatistics, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem općenitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osvježiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zatvoriAplikacijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bazaPodatakaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spremiPromjeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preuzmiPromjeneToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnPlayers;
        private System.Windows.Forms.Button btnTournaments;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnStandings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

