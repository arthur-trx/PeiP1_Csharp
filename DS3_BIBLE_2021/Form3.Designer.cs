namespace DS3_BIBLE_2021
{
    partial class Form_add_repas
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
            this.label_entré = new System.Windows.Forms.Label();
            this.label_plat = new System.Windows.Forms.Label();
            this.label_dessert = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.comboBox_entree = new System.Windows.Forms.ComboBox();
            this.comboBox_plat = new System.Windows.Forms.ComboBox();
            this.comboBox_dessert = new System.Windows.Forms.ComboBox();
            this.button_main = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_entré
            // 
            this.label_entré.AutoSize = true;
            this.label_entré.Location = new System.Drawing.Point(53, 89);
            this.label_entré.Name = "label_entré";
            this.label_entré.Size = new System.Drawing.Size(43, 13);
            this.label_entré.TabIndex = 0;
            this.label_entré.Text = "entrée :";
            // 
            // label_plat
            // 
            this.label_plat.AutoSize = true;
            this.label_plat.Location = new System.Drawing.Point(53, 144);
            this.label_plat.Name = "label_plat";
            this.label_plat.Size = new System.Drawing.Size(97, 13);
            this.label_plat.TabIndex = 1;
            this.label_plat.Text = "Plat de résistance :";
            // 
            // label_dessert
            // 
            this.label_dessert.AutoSize = true;
            this.label_dessert.Location = new System.Drawing.Point(53, 207);
            this.label_dessert.Name = "label_dessert";
            this.label_dessert.Size = new System.Drawing.Size(49, 13);
            this.label_dessert.TabIndex = 2;
            this.label_dessert.Text = "Dessert :";
            // 
            // comboBox_entree
            // 
            this.comboBox_entree.FormattingEnabled = true;
            this.comboBox_entree.Location = new System.Drawing.Point(220, 86);
            this.comboBox_entree.Name = "comboBox_entree";
            this.comboBox_entree.Size = new System.Drawing.Size(222, 21);
            this.comboBox_entree.TabIndex = 3;
            // 
            // comboBox_plat
            // 
            this.comboBox_plat.FormattingEnabled = true;
            this.comboBox_plat.Location = new System.Drawing.Point(220, 144);
            this.comboBox_plat.Name = "comboBox_plat";
            this.comboBox_plat.Size = new System.Drawing.Size(222, 21);
            this.comboBox_plat.TabIndex = 4;
            // 
            // comboBox_dessert
            // 
            this.comboBox_dessert.FormattingEnabled = true;
            this.comboBox_dessert.Location = new System.Drawing.Point(220, 199);
            this.comboBox_dessert.Name = "comboBox_dessert";
            this.comboBox_dessert.Size = new System.Drawing.Size(222, 21);
            this.comboBox_dessert.TabIndex = 5;
            // 
            // button_main
            // 
            this.button_main.Location = new System.Drawing.Point(301, 317);
            this.button_main.Name = "button_main";
            this.button_main.Size = new System.Drawing.Size(75, 23);
            this.button_main.TabIndex = 6;
            this.button_main.Text = "Valider";
            this.button_main.UseVisualStyleBackColor = true;
            this.button_main.Click += new System.EventHandler(this.button_main_Click);
            // 
            // Form_add_repas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_main);
            this.Controls.Add(this.comboBox_dessert);
            this.Controls.Add(this.comboBox_plat);
            this.Controls.Add(this.comboBox_entree);
            this.Controls.Add(this.label_dessert);
            this.Controls.Add(this.label_plat);
            this.Controls.Add(this.label_entré);
            this.Name = "Form_add_repas";
            this.Text = "Ajouter un repas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_entré;
        private System.Windows.Forms.Label label_plat;
        private System.Windows.Forms.Label label_dessert;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ComboBox comboBox_entree;
        private System.Windows.Forms.ComboBox comboBox_plat;
        private System.Windows.Forms.ComboBox comboBox_dessert;
        private System.Windows.Forms.Button button_main;
    }
}