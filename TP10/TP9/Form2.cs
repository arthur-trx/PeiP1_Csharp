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
    public partial class Form_Recherche : Form
    {
        private string sRechercher;
        private int position = 0; //what 
        public string Rechercher
        {
            get { return sRechercher; }
            set { sRechercher = value; }
        }

        public int Position
        {
            get { return position; }
            set { position = value; }
        }

        public Form_Recherche()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label_main.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (Rechercher.Contains(textBox_main.Text)) // == true
            {
                position = Rechercher.IndexOf(textBox_main.Text);

                ((FormTextEditor)this.Owner).Surligne(position, textBox_main.Text.Length);  //utiliser la fonction du form 1 ????

            }
            else
            {
                MessageBox.Show("il y a aucune recurrence", "pas de résulat", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Form_Recherche_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((FormTextEditor)this.Owner).Surligne(0, 0);
            return;

        }
    }
}
