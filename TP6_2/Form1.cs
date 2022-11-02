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
        private void Etat_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EtatCivil temp = new EtatCivil(textBox_name.Text, textBox_firstName.Text, char.Parse(comboBox_Sexe.Text), (dateTimePicker1.Value), textBox_birthPlace.Text);
           liste_personne.Add(temp);
            
            var list_temp = new ListViewItem(temp.all());
            listView_Population.Items.Add(list_temp);
            

        }
private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem I in listView_Population.SelectedItems)
            {
                liste_personne.RemoveAt(I.Index);
                listView_Population.Items.RemoveAt(I.Index);


            }
        }
    }
}
