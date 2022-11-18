using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DS_2022
{
    public partial class Recette : Form
    {
        CRecette ORecette;
        public Recette()
        {
            InitializeComponent();
        }

        private void button_recette_Click(object sender, EventArgs e)
        {
            if (textBox_nom.Text =="")
            {
                MessageBox.Show("vous n'avez pas mis de nom, veuillez réessayer ", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; }
            if (textBox_Instruction.Text == "")
            {
                MessageBox.Show("vous n'avez pas mis de instruction, veuillez réessayer ", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ORecette = new CRecette(textBox_nom.Text, textBox_Instruction.Text, null);

            listView_ingredients.Items.Clear();
        }

        private void button_Ingredient_Click(object sender, EventArgs e)
        {
            if (ORecette == null)
                {
                    MessageBox.Show("vous n'avez pas crée de recette, veuillez réessayer ", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            if (textBox_ingredient.Text == "")
            {
                MessageBox.Show("vous n'avez pas mis d'ingrédient, veuillez réessayer ", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBox_quantite.Text == "")
            {
                MessageBox.Show("vous n'avez pas mis de quantité, veuillez réessayer ", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (comboBox_Unite.Text == "")
            {
                MessageBox.Show("vous n'avez pas mis d'unité, veuillez réessayer ", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            CIngredient temp = new CIngredient(textBox_ingredient.Text, int.Parse(textBox_quantite.Text), comboBox_Unite.Text);
            
            var temmp_var = new ListViewItem(temp.All());
            
            listView_ingredients.Items.Add(temmp_var);
            ORecette.Add(temp);

        }
    }
}
