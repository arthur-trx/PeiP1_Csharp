using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TP5
{
    public partial class Etat_civil : Form
    {
        private List<EtatCivil> liste_personne = new List<EtatCivil>();

        public Etat_civil()
        {
            InitializeComponent();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text != "")
            {
                EtatCivil temp = new EtatCivil(textBox_name.Text, textBox_firstName.Text, char.Parse(comboBox_Sexe.Text), (dateTimePicker1.Value), textBox_birthPlace.Text);
                liste_personne.Add(temp);

                var list_temp = new ListViewItem(temp.all());
                listView_Population.Items.Add(list_temp);
            }
            else MessageBox.Show("L'ajout est impossible, vous avez oublié de reseigner le nom de la personne", "Erreur Ajout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            

        }
private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem I in listView_Population.SelectedItems)
            {
                liste_personne.RemoveAt(I.Index);
                listView_Population.Items.RemoveAt(I.Index);


            }
        }



        private void ageMoyenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int moyenne = 0;
            foreach (EtatCivil I in liste_personne)
            {
                moyenne += I.Age();
            }
            moyenne /= liste_personne.Count;
            //= moyenne.ToString();
            MessageBox.Show("L'age moyen des personne présentes dans la liste est de :" + moyenne + "ans", "moyenne age", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }


    }
}
