using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bible2021
{
    public partial class Form1 : Form
    {
        double theta1;
        double theta2;
        double phi1;
        double phi2;
        double rayon;
        double pas;
        double incrément; //same as pas ????
        CSphere sphere;
        public Form1()
        {
            InitializeComponent();
        }

        public void Get_data()
        {
            theta1 = double.Parse(textBox_TX.Text.Replace(".", ","));
            theta2 = double.Parse(textBox_TY.Text.Replace(".", ","));
            phi1 = double.Parse(textBox_PX.Text.Replace(".", ","));
            phi2 = double.Parse(textBox_PY.Text.Replace(".", ","));
            rayon = double.Parse(textBox_Rayon.Text.Replace(".", ","));
            pas = double.Parse(comboBox1.Text.Replace(".", ","));
            sphere = new CSphere(rayon);
        }

        private void coordonnéesCartésiennesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Get_data();
            for (double i = theta1; i < theta2; i+=pas)
            {
                for (double j = phi1; j < phi2; j+= pas)
                {

                    double[] tab = sphere.coordonée(i, j);
                    string[] temp = { i.ToString(), j.ToString(), tab[0].ToString(), tab[1].ToString(), tab[2].ToString() };
                    var tempV = new ListViewItem(temp);
                    listView1.Items.Add(tempV);
                }
            }

        }

        private void surfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Get_data();
            double temp = sphere.Surface(theta1, theta2, phi1, phi2);
            label_Surface.Visible = true;
            label_Surface.Text = "la surface de la zone de sphere vaut : " + temp;
        }
    }

}
