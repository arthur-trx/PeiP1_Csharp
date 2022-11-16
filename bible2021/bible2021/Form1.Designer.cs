namespace bible2021
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.label_Rayon = new System.Windows.Forms.Label();
            this.label_theta = new System.Windows.Forms.Label();
            this.label_phi = new System.Windows.Forms.Label();
            this.label_angle = new System.Windows.Forms.Label();
            this.textBox_TX = new System.Windows.Forms.TextBox();
            this.textBox_Rayon = new System.Windows.Forms.TextBox();
            this.textBox_TY = new System.Windows.Forms.TextBox();
            this.textBox_PX = new System.Windows.Forms.TextBox();
            this.textBox_PY = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sphereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coordonnéesCartésiennesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.surfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Surface = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.theta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.X = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Z = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Rayon
            // 
            this.label_Rayon.AutoSize = true;
            this.label_Rayon.Location = new System.Drawing.Point(24, 91);
            this.label_Rayon.Name = "label_Rayon";
            this.label_Rayon.Size = new System.Drawing.Size(38, 13);
            this.label_Rayon.TabIndex = 0;
            this.label_Rayon.Text = "Rayon";
            // 
            // label_theta
            // 
            this.label_theta.AutoSize = true;
            this.label_theta.Location = new System.Drawing.Point(24, 165);
            this.label_theta.Name = "label_theta";
            this.label_theta.Size = new System.Drawing.Size(105, 13);
            this.label_theta.TabIndex = 1;
            this.label_theta.Text = "intervalle angle theta";
            // 
            // label_phi
            // 
            this.label_phi.AutoSize = true;
            this.label_phi.Location = new System.Drawing.Point(24, 195);
            this.label_phi.Name = "label_phi";
            this.label_phi.Size = new System.Drawing.Size(95, 13);
            this.label_phi.TabIndex = 2;
            this.label_phi.Text = "intervalle angle phi";
            // 
            // label_angle
            // 
            this.label_angle.AutoSize = true;
            this.label_angle.Location = new System.Drawing.Point(24, 233);
            this.label_angle.Name = "label_angle";
            this.label_angle.Size = new System.Drawing.Size(107, 13);
            this.label_angle.TabIndex = 3;
            this.label_angle.Text = "incrément des angles";
            // 
            // textBox_TX
            // 
            this.textBox_TX.Location = new System.Drawing.Point(156, 162);
            this.textBox_TX.Name = "textBox_TX";
            this.textBox_TX.Size = new System.Drawing.Size(57, 20);
            this.textBox_TX.TabIndex = 7;
            // 
            // textBox_Rayon
            // 
            this.textBox_Rayon.Location = new System.Drawing.Point(97, 88);
            this.textBox_Rayon.Name = "textBox_Rayon";
            this.textBox_Rayon.Size = new System.Drawing.Size(100, 20);
            this.textBox_Rayon.TabIndex = 8;
            // 
            // textBox_TY
            // 
            this.textBox_TY.Location = new System.Drawing.Point(246, 162);
            this.textBox_TY.Name = "textBox_TY";
            this.textBox_TY.Size = new System.Drawing.Size(57, 20);
            this.textBox_TY.TabIndex = 9;
            // 
            // textBox_PX
            // 
            this.textBox_PX.Location = new System.Drawing.Point(156, 188);
            this.textBox_PX.Name = "textBox_PX";
            this.textBox_PX.Size = new System.Drawing.Size(57, 20);
            this.textBox_PX.TabIndex = 10;
            // 
            // textBox_PY
            // 
            this.textBox_PY.Location = new System.Drawing.Point(246, 188);
            this.textBox_PY.Name = "textBox_PY";
            this.textBox_PY.Size = new System.Drawing.Size(57, 20);
            this.textBox_PY.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0.1",
            "0.01",
            "0.001"});
            this.comboBox1.Location = new System.Drawing.Point(137, 233);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sphereToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sphereToolStripMenuItem
            // 
            this.sphereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coordonnéesCartésiennesToolStripMenuItem,
            this.surfaceToolStripMenuItem});
            this.sphereToolStripMenuItem.Name = "sphereToolStripMenuItem";
            this.sphereToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.sphereToolStripMenuItem.Text = "Sphere";
            // 
            // coordonnéesCartésiennesToolStripMenuItem
            // 
            this.coordonnéesCartésiennesToolStripMenuItem.Name = "coordonnéesCartésiennesToolStripMenuItem";
            this.coordonnéesCartésiennesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.coordonnéesCartésiennesToolStripMenuItem.Text = "Coordonnées cartésiennes";
            this.coordonnéesCartésiennesToolStripMenuItem.Click += new System.EventHandler(this.coordonnéesCartésiennesToolStripMenuItem_Click);
            // 
            // surfaceToolStripMenuItem
            // 
            this.surfaceToolStripMenuItem.Name = "surfaceToolStripMenuItem";
            this.surfaceToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.surfaceToolStripMenuItem.Text = "Surface";
            this.surfaceToolStripMenuItem.Click += new System.EventHandler(this.surfaceToolStripMenuItem_Click);
            // 
            // label_Surface
            // 
            this.label_Surface.AutoSize = true;
            this.label_Surface.Location = new System.Drawing.Point(27, 425);
            this.label_Surface.Name = "label_Surface";
            this.label_Surface.Size = new System.Drawing.Size(72, 13);
            this.label_Surface.TabIndex = 14;
            this.label_Surface.Text = "label_Surface";
            this.label_Surface.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.theta,
            this.phi,
            this.X,
            this.Y,
            this.Z});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(27, 280);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(485, 97);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // theta
            // 
            this.theta.Text = "theta";
            this.theta.Width = 100;
            // 
            // phi
            // 
            this.phi.Width = 100;
            // 
            // X
            // 
            this.X.Text = "X";
            this.X.Width = 100;
            // 
            // Y
            // 
            this.Y.Text = "Y";
            this.Y.Width = 100;
            // 
            // Z
            // 
            this.Z.Text = "Z";
            this.Z.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label_Surface);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox_PY);
            this.Controls.Add(this.textBox_PX);
            this.Controls.Add(this.textBox_TY);
            this.Controls.Add(this.textBox_Rayon);
            this.Controls.Add(this.textBox_TX);
            this.Controls.Add(this.label_angle);
            this.Controls.Add(this.label_phi);
            this.Controls.Add(this.label_theta);
            this.Controls.Add(this.label_Rayon);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sphere";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Rayon;
        private System.Windows.Forms.Label label_theta;
        private System.Windows.Forms.Label label_phi;
        private System.Windows.Forms.Label label_angle;
        private System.Windows.Forms.TextBox textBox_TX;
        private System.Windows.Forms.TextBox textBox_Rayon;
        private System.Windows.Forms.TextBox textBox_TY;
        private System.Windows.Forms.TextBox textBox_PX;
        private System.Windows.Forms.TextBox textBox_PY;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sphereToolStripMenuItem;
        private System.Windows.Forms.Label label_Surface;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader theta;
        private System.Windows.Forms.ColumnHeader phi;
        private System.Windows.Forms.ColumnHeader X;
        private System.Windows.Forms.ColumnHeader Y;
        private System.Windows.Forms.ColumnHeader Z;
        private System.Windows.Forms.ToolStripMenuItem coordonnéesCartésiennesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem surfaceToolStripMenuItem;
    }
}

