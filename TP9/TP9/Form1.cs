using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP9
{
    public partial class FormTextEditor : Form
    {
        Form_Recherche F_Rechercher = new Form_Recherche();
       
        public FormTextEditor()
        {
            InitializeComponent();
            F_Rechercher.Owner = this; 
        }
        public void Surligne(int debut, int longueur)
        {
            richTextBox_main.Select(debut, longueur);

        }


        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Rechercher.Show();
            F_Rechercher.Rechercher = richTextBox_main.Text;
        }
        
    }
}
