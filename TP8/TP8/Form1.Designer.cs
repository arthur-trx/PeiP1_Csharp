namespace TP8
{
    partial class itinéraire
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pointsDintéretToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewCoordonnees = new System.Windows.Forms.ListView();
            this.Latitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Longitude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreDélémentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointsDintéretToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pointsDintéretToolStripMenuItem
            // 
            this.pointsDintéretToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.nombreDélémentToolStripMenuItem});
            this.pointsDintéretToolStripMenuItem.Name = "pointsDintéretToolStripMenuItem";
            this.pointsDintéretToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.pointsDintéretToolStripMenuItem.Text = "Points d\'intéret";
            this.pointsDintéretToolStripMenuItem.Click += new System.EventHandler(this.pointsDintéretToolStripMenuItem_Click);
            // 
            // listViewCoordonnees
            // 
            this.listViewCoordonnees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Latitude,
            this.Longitude});
            this.listViewCoordonnees.HideSelection = false;
            this.listViewCoordonnees.Location = new System.Drawing.Point(37, 262);
            this.listViewCoordonnees.Name = "listViewCoordonnees";
            this.listViewCoordonnees.Size = new System.Drawing.Size(377, 97);
            this.listViewCoordonnees.TabIndex = 1;
            this.listViewCoordonnees.UseCompatibleStateImageBehavior = false;
            this.listViewCoordonnees.View = System.Windows.Forms.View.Details;
            // 
            // Latitude
            // 
            this.Latitude.Text = "Latitude";
            this.Latitude.Width = 188;
            // 
            // Longitude
            // 
            this.Longitude.Text = "Longitude";
            this.Longitude.Width = 183;
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajouterToolStripMenuItem.Text = "ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // nombreDélémentToolStripMenuItem
            // 
            this.nombreDélémentToolStripMenuItem.Name = "nombreDélémentToolStripMenuItem";
            this.nombreDélémentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nombreDélémentToolStripMenuItem.Text = "nombre d\'élément";
            this.nombreDélémentToolStripMenuItem.Click += new System.EventHandler(this.nombreDélémentToolStripMenuItem_Click);
            // 
            // itinéraire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewCoordonnees);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "itinéraire";
            this.Text = "itinéraire";
            this.Load += new System.EventHandler(this.Itinéraire_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pointsDintéretToolStripMenuItem;
        private System.Windows.Forms.ListView listViewCoordonnees;
        private System.Windows.Forms.ColumnHeader Latitude;
        private System.Windows.Forms.ColumnHeader Longitude;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreDélémentToolStripMenuItem;
    }
}

