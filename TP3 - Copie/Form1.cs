using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3
{
    public partial class label_taux : Form
    {
        public label_taux()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1 (object sender, EventArgs e)
        {

        }
        

        /*private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
     {
         if  (e.KeyChar == (char) 13) button_Click(sender, e);
     }
     */

        private void button_Click(object sender, EventArgs e)
        {
            int calcul;
            radioButton_Dollars.Text.Replace(".", ",");
            textBox_taux.Text.Replace(".", ",");
            calcul = int.Parse(radioButton_Dollars.Text) * int.Parse(textBox_taux.Text);
            label_resultat_devise2.Text = (calcul).ToString();

        }

        private void radioButtonEuros_dollars_CheckedChanged(object sender, EventArgs e)
        {
            textBox_taux.Text = " ";
            radioButton_Dollars.Text = " ";
            label_devise_1.Text = "dollars";
            label_devise_2.Text = "euros";
            label_resultat_devise2.Text = " ";
        }

        private void radioButtonDollars_euros_CheckedChanged(object sender, EventArgs e)
        {
            textBox_taux.Text = " ";
            radioButton_Dollars.Text = " ";
            label_devise_1.Text = "euros";
            label_devise_2.Text = "dollars";
            label_resultat_devise2.Text = " ";

        }
    }
}
