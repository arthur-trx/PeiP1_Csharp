namespace TP9
{
    partial class Form_Recherche
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
            this.label_main = new System.Windows.Forms.Label();
            this.textBox_main = new System.Windows.Forms.TextBox();
            this.button_main = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_main
            // 
            this.label_main.AutoSize = true;
            this.label_main.Location = new System.Drawing.Point(81, 67);
            this.label_main.Name = "label_main";
            this.label_main.Size = new System.Drawing.Size(69, 13);
            this.label_main.TabIndex = 0;
            this.label_main.Text = "Rechercher :";
            this.label_main.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_main
            // 
            this.textBox_main.Location = new System.Drawing.Point(168, 64);
            this.textBox_main.Name = "textBox_main";
            this.textBox_main.Size = new System.Drawing.Size(166, 20);
            this.textBox_main.TabIndex = 1;
            // 
            // button_main
            // 
            this.button_main.Location = new System.Drawing.Point(151, 110);
            this.button_main.Name = "button_main";
            this.button_main.Size = new System.Drawing.Size(75, 23);
            this.button_main.TabIndex = 2;
            this.button_main.Text = "Suivant";
            this.button_main.UseVisualStyleBackColor = true;
            this.button_main.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Recherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 145);
            this.Controls.Add(this.button_main);
            this.Controls.Add(this.textBox_main);
            this.Controls.Add(this.label_main);
            this.Name = "Form_Recherche";
            this.Text = "Rechercher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Recherche_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_main;
        private System.Windows.Forms.TextBox textBox_main;
        private System.Windows.Forms.Button button_main;
    }
}