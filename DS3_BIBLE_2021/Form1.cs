using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS3_BIBLE_2021
{
    public partial class Form1 : Form
    {
        public List<CPlat> _cPlats = new List<CPlat>();
        List<CRepas> _CRepas = new List<CRepas>();
        public int count_plat = 1;
        public int count_repas = 1;

        Form_add_repas form_Add_repas;
        public Form1()
        {
            InitializeComponent();

            form_Add_repas = new Form_add_repas();
            form_Add_repas.Owner = this;
        }

        void Remplissage_ListView()
        {
            listView1.Items.Clear();
            double somme = 0;
            foreach (CRepas rep in _CRepas)
            {
                var temp = new ListViewItem(rep.All());
                listView1.Items.Add(temp);
                somme += rep.Prix_Repas();
            }
            textBox_recette.Text = somme.ToString();
        }

        public int indice_dans_la_liste_plat(string nom)
        {
            foreach (CPlat Plat in _cPlats)
            {
                if (nom == Plat.Name) return _cPlats.IndexOf(Plat);
            }
            return -1;
        }

        public void Ajouter_Plat(string name, float price)
        {
            CPlat temp = new CPlat(count_plat, name, price);
            count_plat++;
            _cPlats.Add(temp);
        }
        public void Ajouter_Repas_int(string a, string b, string c)
        {
            int id1; int id2; int id3;
            id1 = indice_dans_la_liste_plat(a);
            id2 = indice_dans_la_liste_plat(b);
            id3 = indice_dans_la_liste_plat(c);
            Ajouter_Repas(id1, id2, id3);
        }
        public void Ajouter_Repas(int id1, int id2, int id3)
        {
            CPlat[] temp = new CPlat[3]; 
            foreach (CPlat plat in _cPlats)
            {
                if (plat.Id == id1) temp[0] = plat;
                if (plat.Id == id2) temp[1] = plat;
                if (plat.Id == id3) temp[2] = plat;
            }

            CRepas temp_ = new CRepas(count_repas, temp);
            count_repas++;
            _CRepas.Add(temp_);
            Remplissage_ListView();
        }
        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_add_plas form_Add_Plat = new Form_add_plas();
            form_Add_Plat.Owner= this;

            form_Add_Plat.Show();



        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (List.Count == 0) MessageBox.Show("vous avez aucu plats", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                foreach (CPlat plat in _cPlats)
                {
                    form_Add_repas.Add(plat.Name);
                }

                form_Add_repas.Show();
            }

        }

        public List<CPlat> List
        {

            get { return _cPlats; }
        }


    }
}
