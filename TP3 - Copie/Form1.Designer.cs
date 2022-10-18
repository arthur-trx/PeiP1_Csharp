namespace TP3
{
    partial class label_taux
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_taux = new System.Windows.Forms.TextBox();
            this.label_devise_1 = new System.Windows.Forms.Label();
            this.label_devise_2 = new System.Windows.Forms.Label();
            this.radioButton_Dollars = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.label_resultat_devise2 = new System.Windows.Forms.Label();
            this.radioButtonEuros_dollars = new System.Windows.Forms.RadioButton();
            this.radioButtonDollars_euros = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "taux de conversion : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_taux
            // 
            this.textBox_taux.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_taux.Location = new System.Drawing.Point(313, 42);
            this.textBox_taux.Name = "textBox_taux";
            this.textBox_taux.Size = new System.Drawing.Size(125, 29);
            this.textBox_taux.TabIndex = 1;
            this.textBox_taux.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_devise_1
            // 
            this.label_devise_1.AutoSize = true;
            this.label_devise_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_devise_1.Location = new System.Drawing.Point(76, 129);
            this.label_devise_1.Name = "label_devise_1";
            this.label_devise_1.Size = new System.Drawing.Size(41, 16);
            this.label_devise_1.TabIndex = 2;
            this.label_devise_1.Text = "euros";
            this.label_devise_1.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_devise_2
            // 
            this.label_devise_2.AutoSize = true;
            this.label_devise_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_devise_2.Location = new System.Drawing.Point(411, 129);
            this.label_devise_2.Name = "label_devise_2";
            this.label_devise_2.Size = new System.Drawing.Size(48, 16);
            this.label_devise_2.TabIndex = 3;
            this.label_devise_2.Text = "dollars";
            // 
            // radioButton_Dollars
            // 
            this.radioButton_Dollars.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Dollars.Location = new System.Drawing.Point(79, 160);
            this.radioButton_Dollars.Name = "radioButton_Dollars";
            this.radioButton_Dollars.Size = new System.Drawing.Size(125, 29);
            this.radioButton_Dollars.TabIndex = 4;
            this.radioButton_Dollars.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button.Location = new System.Drawing.Point(254, 160);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(82, 29);
            this.button.TabIndex = 5;
            this.button.Text = "->";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // label_resultat_devise2
            // 
            this.label_resultat_devise2.AutoSize = true;
            this.label_resultat_devise2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_resultat_devise2.Location = new System.Drawing.Point(390, 160);
            this.label_resultat_devise2.Name = "label_resultat_devise2";
            this.label_resultat_devise2.Size = new System.Drawing.Size(65, 24);
            this.label_resultat_devise2.TabIndex = 6;
            this.label_resultat_devise2.Text = "dollars";
            // 
            // radioButtonEuros_dollars
            // 
            this.radioButtonEuros_dollars.AutoSize = true;
            this.radioButtonEuros_dollars.Checked = true;
            this.radioButtonEuros_dollars.Location = new System.Drawing.Point(79, 266);
            this.radioButtonEuros_dollars.Name = "radioButtonEuros_dollars";
            this.radioButtonEuros_dollars.Size = new System.Drawing.Size(99, 17);
            this.radioButtonEuros_dollars.TabIndex = 7;
            this.radioButtonEuros_dollars.TabStop = true;
            this.radioButtonEuros_dollars.Text = "Euros -> Dollars";
            this.radioButtonEuros_dollars.UseVisualStyleBackColor = true;
            this.radioButtonEuros_dollars.UseWaitCursor = true;
            this.radioButtonEuros_dollars.CheckedChanged += new System.EventHandler(this.radioButtonEuros_dollars_CheckedChanged);
            // 
            // radioButtonDollars_euros
            // 
            this.radioButtonDollars_euros.AutoSize = true;
            this.radioButtonDollars_euros.Location = new System.Drawing.Point(79, 308);
            this.radioButtonDollars_euros.Name = "radioButtonDollars_euros";
            this.radioButtonDollars_euros.Size = new System.Drawing.Size(99, 17);
            this.radioButtonDollars_euros.TabIndex = 8;
            this.radioButtonDollars_euros.Text = "Dollars -> Euros";
            this.radioButtonDollars_euros.UseVisualStyleBackColor = true;
            this.radioButtonDollars_euros.CheckedChanged += new System.EventHandler(this.radioButtonDollars_euros_CheckedChanged);
            // 
            // label_taux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonDollars_euros);
            this.Controls.Add(this.radioButtonEuros_dollars);
            this.Controls.Add(this.label_resultat_devise2);
            this.Controls.Add(this.button);
            this.Controls.Add(this.radioButton_Dollars);
            this.Controls.Add(this.label_devise_2);
            this.Controls.Add(this.label_devise_1);
            this.Controls.Add(this.textBox_taux);
            this.Controls.Add(this.label1);
            this.Name = "label_taux";
            this.Text = "Devise";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_taux;
        private System.Windows.Forms.Label label_devise_1;
        private System.Windows.Forms.Label label_devise_2;
        private System.Windows.Forms.TextBox radioButton_Dollars;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label_resultat_devise2;
        private System.Windows.Forms.RadioButton radioButtonEuros_dollars;
        private System.Windows.Forms.RadioButton radioButtonDollars_euros;
    }
}

