using System;
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
    public partial class Form_add_repas : Form
    {
        public Form_add_repas()
        {
            InitializeComponent();
            /*foreach ( CPlat plat in ((Form1)this.Owner).List)
            {
                comboBox_entree.Items.Add(plat);
                comboBox_plat.Items.Add(plat);
                comboBox_dessert.Items.Add(plat);
            }*/
        }

        public void Add(string plat)

        {
               comboBox_entree.Items.Add(plat);
               comboBox_plat.Items.Add(plat);
               comboBox_dessert.Items.Add(plat);
        }

        private void button_main_Click(object sender, EventArgs e)
        {
            ((Form1)this.Owner).Ajouter_Repas_int(comboBox_entree.Text, comboBox_plat.Text, comboBox_dessert.Text);

            this.Close();
        }
    }
}
