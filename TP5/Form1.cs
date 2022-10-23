using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5
{
    public partial class Etat_civil : Form
    {
        EtatCivil[] tableaux = new EtatCivil [50];
        int Population = 0;
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
            tableaux[Population] = temp;
            
            var list_temp = new ListViewItem(tableaux[Population].all());
            listView_Population.Items.Add(list_temp);
            Population++;

        }


    }
}
