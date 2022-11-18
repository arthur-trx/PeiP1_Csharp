namespace DS_2022
{
    partial class Recette
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
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.label_nom = new System.Windows.Forms.Label();
            this.label_Instruction = new System.Windows.Forms.Label();
            this.label_Ingredient = new System.Windows.Forms.Label();
            this.label_Quantité = new System.Windows.Forms.Label();
            this.textBox_Instruction = new System.Windows.Forms.TextBox();
            this.textBox_ingredient = new System.Windows.Forms.TextBox();
            this.textBox_quantite = new System.Windows.Forms.TextBox();
            this.button_recette = new System.Windows.Forms.Button();
            this.label_Unite = new System.Windows.Forms.Label();
            this.comboBox_Unite = new System.Windows.Forms.ComboBox();
            this.button_Ingredient = new System.Windows.Forms.Button();
            this.listView_ingredients = new System.Windows.Forms.ListView();
            this.Ingredient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(188, 22);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(376, 20);
            this.textBox_nom.TabIndex = 0;
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Location = new System.Drawing.Point(36, 22);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(100, 13);
            this.label_nom.TabIndex = 1;
            this.label_nom.Text = "Nom de la recette : ";
            // 
            // label_Instruction
            // 
            this.label_Instruction.AutoSize = true;
            this.label_Instruction.Location = new System.Drawing.Point(36, 68);
            this.label_Instruction.Name = "label_Instruction";
            this.label_Instruction.Size = new System.Drawing.Size(70, 13);
            this.label_Instruction.TabIndex = 2;
            this.label_Instruction.Text = "Instructions : ";
            // 
            // label_Ingredient
            // 
            this.label_Ingredient.AutoSize = true;
            this.label_Ingredient.Location = new System.Drawing.Point(36, 234);
            this.label_Ingredient.Name = "label_Ingredient";
            this.label_Ingredient.Size = new System.Drawing.Size(60, 13);
            this.label_Ingredient.TabIndex = 3;
            this.label_Ingredient.Text = "Ingrédient :";
            // 
            // label_Quantité
            // 
            this.label_Quantité.AutoSize = true;
            this.label_Quantité.Location = new System.Drawing.Point(36, 266);
            this.label_Quantité.Name = "label_Quantité";
            this.label_Quantité.Size = new System.Drawing.Size(47, 13);
            this.label_Quantité.TabIndex = 4;
            this.label_Quantité.Text = "Quantité";
            // 
            // textBox_Instruction
            // 
            this.textBox_Instruction.Location = new System.Drawing.Point(188, 68);
            this.textBox_Instruction.Multiline = true;
            this.textBox_Instruction.Name = "textBox_Instruction";
            this.textBox_Instruction.Size = new System.Drawing.Size(376, 88);
            this.textBox_Instruction.TabIndex = 5;
            // 
            // textBox_ingredient
            // 
            this.textBox_ingredient.Location = new System.Drawing.Point(114, 231);
            this.textBox_ingredient.Name = "textBox_ingredient";
            this.textBox_ingredient.Size = new System.Drawing.Size(100, 20);
            this.textBox_ingredient.TabIndex = 6;
            // 
            // textBox_quantite
            // 
            this.textBox_quantite.Location = new System.Drawing.Point(114, 266);
            this.textBox_quantite.Name = "textBox_quantite";
            this.textBox_quantite.Size = new System.Drawing.Size(100, 20);
            this.textBox_quantite.TabIndex = 7;
            // 
            // button_recette
            // 
            this.button_recette.Location = new System.Drawing.Point(274, 162);
            this.button_recette.Name = "button_recette";
            this.button_recette.Size = new System.Drawing.Size(181, 23);
            this.button_recette.TabIndex = 8;
            this.button_recette.Text = "Créer la recette";
            this.button_recette.UseVisualStyleBackColor = true;
            this.button_recette.Click += new System.EventHandler(this.button_recette_Click);
            // 
            // label_Unite
            // 
            this.label_Unite.AutoSize = true;
            this.label_Unite.Location = new System.Drawing.Point(36, 302);
            this.label_Unite.Name = "label_Unite";
            this.label_Unite.Size = new System.Drawing.Size(36, 13);
            this.label_Unite.TabIndex = 9;
            this.label_Unite.Text = "unité :";
            // 
            // comboBox_Unite
            // 
            this.comboBox_Unite.FormattingEnabled = true;
            this.comboBox_Unite.Items.AddRange(new object[] {
            "lites(s)",
            "centilitres(s)",
            "millilitre(s)",
            "filograme(s)",
            "gramme(s)",
            "pincée(s)",
            "unité(s)"});
            this.comboBox_Unite.Location = new System.Drawing.Point(114, 299);
            this.comboBox_Unite.Name = "comboBox_Unite";
            this.comboBox_Unite.Size = new System.Drawing.Size(100, 21);
            this.comboBox_Unite.TabIndex = 10;
            // 
            // button_Ingredient
            // 
            this.button_Ingredient.Location = new System.Drawing.Point(56, 343);
            this.button_Ingredient.Name = "button_Ingredient";
            this.button_Ingredient.Size = new System.Drawing.Size(136, 23);
            this.button_Ingredient.TabIndex = 11;
            this.button_Ingredient.Text = "Ajouter un ingrédient";
            this.button_Ingredient.UseVisualStyleBackColor = true;
            this.button_Ingredient.Click += new System.EventHandler(this.button_Ingredient_Click);
            // 
            // listView_ingredients
            // 
            this.listView_ingredients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ingredient,
            this.Quantite});
            this.listView_ingredients.HideSelection = false;
            this.listView_ingredients.Location = new System.Drawing.Point(259, 231);
            this.listView_ingredients.Name = "listView_ingredients";
            this.listView_ingredients.Size = new System.Drawing.Size(305, 177);
            this.listView_ingredients.TabIndex = 12;
            this.listView_ingredients.UseCompatibleStateImageBehavior = false;
            this.listView_ingredients.View = System.Windows.Forms.View.Details;
            // 
            // Ingredient
            // 
            this.Ingredient.Text = "Ingrédient";
            this.Ingredient.Width = 150;
            // 
            // Quantite
            // 
            this.Quantite.Text = "Quantité";
            this.Quantite.Width = 150;
            // 
            // Recette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView_ingredients);
            this.Controls.Add(this.button_Ingredient);
            this.Controls.Add(this.comboBox_Unite);
            this.Controls.Add(this.label_Unite);
            this.Controls.Add(this.button_recette);
            this.Controls.Add(this.textBox_quantite);
            this.Controls.Add(this.textBox_ingredient);
            this.Controls.Add(this.textBox_Instruction);
            this.Controls.Add(this.label_Quantité);
            this.Controls.Add(this.label_Ingredient);
            this.Controls.Add(this.label_Instruction);
            this.Controls.Add(this.label_nom);
            this.Controls.Add(this.textBox_nom);
            this.Name = "Recette";
            this.Text = "Recette de cuisine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.Label label_Instruction;
        private System.Windows.Forms.Label label_Ingredient;
        private System.Windows.Forms.Label label_Quantité;
        private System.Windows.Forms.TextBox textBox_Instruction;
        private System.Windows.Forms.TextBox textBox_ingredient;
        private System.Windows.Forms.TextBox textBox_quantite;
        private System.Windows.Forms.Button button_recette;
        private System.Windows.Forms.Label label_Unite;
        private System.Windows.Forms.ComboBox comboBox_Unite;
        private System.Windows.Forms.Button button_Ingredient;
        private System.Windows.Forms.ListView listView_ingredients;
        private System.Windows.Forms.ColumnHeader Ingredient;
        private System.Windows.Forms.ColumnHeader Quantite;
    }
}

