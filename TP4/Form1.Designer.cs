namespace TP4
{
    partial class Vecteur_v1
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
            this.opérationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitScalaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitVectorielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_v1 = new System.Windows.Forms.Label();
            this.label_v1_x = new System.Windows.Forms.Label();
            this.label_v1_y = new System.Windows.Forms.Label();
            this.label_v1_z = new System.Windows.Forms.Label();
            this.label_v2 = new System.Windows.Forms.Label();
            this.label_v3 = new System.Windows.Forms.Label();
            this.textBox_v1_x = new System.Windows.Forms.TextBox();
            this.textBox_v1_y = new System.Windows.Forms.TextBox();
            this.textBox_v1_z = new System.Windows.Forms.TextBox();
            this.textBox_v2_z = new System.Windows.Forms.TextBox();
            this.textBox_v2_y = new System.Windows.Forms.TextBox();
            this.textBox_v2_x = new System.Windows.Forms.TextBox();
            this.textBox_v3_z = new System.Windows.Forms.TextBox();
            this.textBox_v3_y = new System.Windows.Forms.TextBox();
            this.textBox_v3_x = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opérationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opérationsToolStripMenuItem
            // 
            this.opérationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produitScalaireToolStripMenuItem,
            this.produitVectorielToolStripMenuItem});
            this.opérationsToolStripMenuItem.Name = "opérationsToolStripMenuItem";
            this.opérationsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.opérationsToolStripMenuItem.Text = "Opérations";
            // 
            // produitScalaireToolStripMenuItem
            // 
            this.produitScalaireToolStripMenuItem.Name = "produitScalaireToolStripMenuItem";
            this.produitScalaireToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.produitScalaireToolStripMenuItem.Text = "produit scalaire";
            this.produitScalaireToolStripMenuItem.Click += new System.EventHandler(this.produitScalaireToolStripMenuItem_Click);
            // 
            // produitVectorielToolStripMenuItem
            // 
            this.produitVectorielToolStripMenuItem.Name = "produitVectorielToolStripMenuItem";
            this.produitVectorielToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.produitVectorielToolStripMenuItem.Text = "produit vectoriel";
            this.produitVectorielToolStripMenuItem.Click += new System.EventHandler(this.produitVectorielToolStripMenuItem_Click);
            // 
            // label_v1
            // 
            this.label_v1.AutoSize = true;
            this.label_v1.Location = new System.Drawing.Point(122, 60);
            this.label_v1.Name = "label_v1";
            this.label_v1.Size = new System.Drawing.Size(53, 13);
            this.label_v1.TabIndex = 1;
            this.label_v1.Text = "Vecteur 1";
            // 
            // label_v1_x
            // 
            this.label_v1_x.AutoSize = true;
            this.label_v1_x.Location = new System.Drawing.Point(93, 89);
            this.label_v1_x.Name = "label_v1_x";
            this.label_v1_x.Size = new System.Drawing.Size(23, 13);
            this.label_v1_x.TabIndex = 2;
            this.label_v1_x.Text = "X : ";
            // 
            // label_v1_y
            // 
            this.label_v1_y.AutoSize = true;
            this.label_v1_y.Location = new System.Drawing.Point(93, 120);
            this.label_v1_y.Name = "label_v1_y";
            this.label_v1_y.Size = new System.Drawing.Size(23, 13);
            this.label_v1_y.TabIndex = 3;
            this.label_v1_y.Text = "Y : ";
            // 
            // label_v1_z
            // 
            this.label_v1_z.AutoSize = true;
            this.label_v1_z.Location = new System.Drawing.Point(93, 150);
            this.label_v1_z.Name = "label_v1_z";
            this.label_v1_z.Size = new System.Drawing.Size(23, 13);
            this.label_v1_z.TabIndex = 4;
            this.label_v1_z.Text = "Z : ";
            // 
            // label_v2
            // 
            this.label_v2.AutoSize = true;
            this.label_v2.Location = new System.Drawing.Point(212, 60);
            this.label_v2.Name = "label_v2";
            this.label_v2.Size = new System.Drawing.Size(53, 13);
            this.label_v2.TabIndex = 5;
            this.label_v2.Text = "Vecteur 2";
            // 
            // label_v3
            // 
            this.label_v3.AutoSize = true;
            this.label_v3.Location = new System.Drawing.Point(308, 60);
            this.label_v3.Name = "label_v3";
            this.label_v3.Size = new System.Drawing.Size(41, 13);
            this.label_v3.TabIndex = 6;
            this.label_v3.Text = "resultat";
            // 
            // textBox_v1_x
            // 
            this.textBox_v1_x.Location = new System.Drawing.Point(125, 89);
            this.textBox_v1_x.Name = "textBox_v1_x";
            this.textBox_v1_x.Size = new System.Drawing.Size(60, 20);
            this.textBox_v1_x.TabIndex = 7;
            // 
            // textBox_v1_y
            // 
            this.textBox_v1_y.Location = new System.Drawing.Point(125, 120);
            this.textBox_v1_y.Name = "textBox_v1_y";
            this.textBox_v1_y.Size = new System.Drawing.Size(60, 20);
            this.textBox_v1_y.TabIndex = 8;
            // 
            // textBox_v1_z
            // 
            this.textBox_v1_z.Location = new System.Drawing.Point(125, 150);
            this.textBox_v1_z.Name = "textBox_v1_z";
            this.textBox_v1_z.Size = new System.Drawing.Size(60, 20);
            this.textBox_v1_z.TabIndex = 9;
            // 
            // textBox_v2_z
            // 
            this.textBox_v2_z.Location = new System.Drawing.Point(215, 150);
            this.textBox_v2_z.Name = "textBox_v2_z";
            this.textBox_v2_z.Size = new System.Drawing.Size(60, 20);
            this.textBox_v2_z.TabIndex = 12;
            // 
            // textBox_v2_y
            // 
            this.textBox_v2_y.Location = new System.Drawing.Point(215, 120);
            this.textBox_v2_y.Name = "textBox_v2_y";
            this.textBox_v2_y.Size = new System.Drawing.Size(60, 20);
            this.textBox_v2_y.TabIndex = 11;
            // 
            // textBox_v2_x
            // 
            this.textBox_v2_x.Location = new System.Drawing.Point(215, 89);
            this.textBox_v2_x.Name = "textBox_v2_x";
            this.textBox_v2_x.Size = new System.Drawing.Size(60, 20);
            this.textBox_v2_x.TabIndex = 10;
            // 
            // textBox_v3_z
            // 
            this.textBox_v3_z.Location = new System.Drawing.Point(311, 150);
            this.textBox_v3_z.Name = "textBox_v3_z";
            this.textBox_v3_z.Size = new System.Drawing.Size(60, 20);
            this.textBox_v3_z.TabIndex = 15;
            // 
            // textBox_v3_y
            // 
            this.textBox_v3_y.Location = new System.Drawing.Point(311, 120);
            this.textBox_v3_y.Name = "textBox_v3_y";
            this.textBox_v3_y.Size = new System.Drawing.Size(60, 20);
            this.textBox_v3_y.TabIndex = 14;
            // 
            // textBox_v3_x
            // 
            this.textBox_v3_x.Location = new System.Drawing.Point(311, 89);
            this.textBox_v3_x.Name = "textBox_v3_x";
            this.textBox_v3_x.Size = new System.Drawing.Size(60, 20);
            this.textBox_v3_x.TabIndex = 13;
            // 
            // Vecteur_v1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_v3_z);
            this.Controls.Add(this.textBox_v3_y);
            this.Controls.Add(this.textBox_v3_x);
            this.Controls.Add(this.textBox_v2_z);
            this.Controls.Add(this.textBox_v2_y);
            this.Controls.Add(this.textBox_v2_x);
            this.Controls.Add(this.textBox_v1_z);
            this.Controls.Add(this.textBox_v1_y);
            this.Controls.Add(this.textBox_v1_x);
            this.Controls.Add(this.label_v2);
            this.Controls.Add(this.label_v1);
            this.Controls.Add(this.label_v3);
            this.Controls.Add(this.label_v1_z);
            this.Controls.Add(this.label_v1_y);
            this.Controls.Add(this.label_v1_x);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Vecteur_v1";
            this.Text = "Vecteur";
            this.Load += new System.EventHandler(this.Vecteur_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opérationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitScalaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitVectorielToolStripMenuItem;
        private System.Windows.Forms.Label label_v1;
        private System.Windows.Forms.Label label_v1_x;
        private System.Windows.Forms.Label label_v1_y;
        private System.Windows.Forms.Label label_v1_z;
        private System.Windows.Forms.Label label_v2;
        private System.Windows.Forms.Label label_v3;
        private System.Windows.Forms.TextBox textBox_v1_x;
        private System.Windows.Forms.TextBox textBox_v1_y;
        private System.Windows.Forms.TextBox textBox_v1_z;
        private System.Windows.Forms.TextBox textBox_v2_z;
        private System.Windows.Forms.TextBox textBox_v2_y;
        private System.Windows.Forms.TextBox textBox_v2_x;
        private System.Windows.Forms.TextBox textBox_v3_z;
        private System.Windows.Forms.TextBox textBox_v3_y;
        private System.Windows.Forms.TextBox textBox_v3_x;
    }
}

