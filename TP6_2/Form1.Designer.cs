namespace TP5
{
    partial class Etat_civil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_name = new System.Windows.Forms.Label();
            this.label_firstName = new System.Windows.Forms.Label();
            this.label_birthdate = new System.Windows.Forms.Label();
            this.label_birthPlace = new System.Windows.Forms.Label();
            this.label_sexe = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.textBox_birthPlace = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Sexe = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView_Population = new System.Windows.Forms.ListView();
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sexe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date_de_naissance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lieux_de_naissance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(32, 56);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(38, 13);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Nom : ";
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.Location = new System.Drawing.Point(32, 112);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(52, 13);
            this.label_firstName.TabIndex = 1;
            this.label_firstName.Text = "Prenom : ";
            // 
            // label_birthdate
            // 
            this.label_birthdate.AutoSize = true;
            this.label_birthdate.Location = new System.Drawing.Point(320, 80);
            this.label_birthdate.Name = "label_birthdate";
            this.label_birthdate.Size = new System.Drawing.Size(102, 13);
            this.label_birthdate.TabIndex = 2;
            this.label_birthdate.Text = "Date de naissance :";
            // 
            // label_birthPlace
            // 
            this.label_birthPlace.AutoSize = true;
            this.label_birthPlace.Location = new System.Drawing.Point(320, 144);
            this.label_birthPlace.Name = "label_birthPlace";
            this.label_birthPlace.Size = new System.Drawing.Size(104, 13);
            this.label_birthPlace.TabIndex = 3;
            this.label_birthPlace.Text = "Lieux de naissance :";
            // 
            // label_sexe
            // 
            this.label_sexe.AutoSize = true;
            this.label_sexe.Location = new System.Drawing.Point(32, 168);
            this.label_sexe.Name = "label_sexe";
            this.label_sexe.Size = new System.Drawing.Size(40, 13);
            this.label_sexe.TabIndex = 4;
            this.label_sexe.Text = "Sexe : ";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(144, 56);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_name.TabIndex = 5;
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Location = new System.Drawing.Point(144, 112);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(100, 20);
            this.textBox_firstName.TabIndex = 6;
            // 
            // textBox_birthPlace
            // 
            this.textBox_birthPlace.Location = new System.Drawing.Point(440, 144);
            this.textBox_birthPlace.Name = "textBox_birthPlace";
            this.textBox_birthPlace.Size = new System.Drawing.Size(100, 20);
            this.textBox_birthPlace.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(440, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // comboBox_Sexe
            // 
            this.comboBox_Sexe.FormattingEnabled = true;
            this.comboBox_Sexe.Items.AddRange(new object[] {
            "H",
            "F",
            "N"});
            this.comboBox_Sexe.Location = new System.Drawing.Point(144, 160);
            this.comboBox_Sexe.Name = "comboBox_Sexe";
            this.comboBox_Sexe.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Sexe.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personneToolStripMenuItem
            // 
            this.personneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.personneToolStripMenuItem.Name = "personneToolStripMenuItem";
            this.personneToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.personneToolStripMenuItem.Text = "Personne";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajouterToolStripMenuItem.Text = "ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.supprimerToolStripMenuItem.Text = "supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // listView_Population
            // 
            this.listView_Population.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom,
            this.Prenom,
            this.Sexe,
            this.Date_de_naissance,
            this.lieux_de_naissance});
            this.listView_Population.HideSelection = false;
            this.listView_Population.Location = new System.Drawing.Point(48, 256);
            this.listView_Population.Name = "listView_Population";
            this.listView_Population.Size = new System.Drawing.Size(592, 161);
            this.listView_Population.TabIndex = 12;
            this.listView_Population.UseCompatibleStateImageBehavior = false;
            this.listView_Population.View = System.Windows.Forms.View.Details;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 150;
            // 
            // Prenom
            // 
            this.Prenom.Text = "Prenom";
            this.Prenom.Width = 150;
            // 
            // Sexe
            // 
            this.Sexe.Text = "Sexe";
            // 
            // Date_de_naissance
            // 
            this.Date_de_naissance.Text = "Date de naissance";
            this.Date_de_naissance.Width = 110;
            // 
            // lieux_de_naissance
            // 
            this.lieux_de_naissance.Text = "lieux de naissance";
            this.lieux_de_naissance.Width = 200;
            // 
            // Etat_civil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView_Population);
            this.Controls.Add(this.comboBox_Sexe);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_birthPlace);
            this.Controls.Add(this.textBox_firstName);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_sexe);
            this.Controls.Add(this.label_birthPlace);
            this.Controls.Add(this.label_birthdate);
            this.Controls.Add(this.label_firstName);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Etat_civil";
            this.Text = "Etat Civil";
            this.Load += new System.EventHandler(this.Etat_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.Label label_birthdate;
        private System.Windows.Forms.Label label_birthPlace;
        private System.Windows.Forms.Label label_sexe;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.TextBox textBox_birthPlace;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox_Sexe;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ListView listView_Population;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Prenom;
        private System.Windows.Forms.ColumnHeader Sexe;
        private System.Windows.Forms.ColumnHeader Date_de_naissance;
        private System.Windows.Forms.ColumnHeader lieux_de_naissance;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}

