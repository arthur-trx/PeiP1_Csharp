using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP8
{
    public partial class itinéraire : Form
    {
        private List<POI> listPOI = new List<POI>();

        public itinéraire()
        {
            InitializeComponent();
        }

        private void pointsDintéretToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            coordonnees form;
            form = new coordonnees();
            if (form.ShowDialog() == DialogResult.OK)
            {
                POI temp_ = new POI(form.GetCoordo()) ;
                listPOI.Add(temp_);

                var list_temp = new ListViewItem(temp_.All());
                listViewCoordonnees.Items.Add(list_temp);
            }
        }

        private void Itinéraire_Load(object sender, EventArgs e)
        {

        }

        private void nombreDélémentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("il y a " + listPOI.Count + "  coordonée(s)", "nombre élément", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }
    }
}
