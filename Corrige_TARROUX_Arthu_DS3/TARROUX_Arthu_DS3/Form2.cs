using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TARROUX_Arthu_DS3
{
    public partial class Form_add_event : Form
    {
        public Form_add_event()
        {
            InitializeComponent();
            for (int i = 0; i<12; i++)
            {
                comboBox_SM.Items.Add(i*5);
                comboBox_EM.Items.Add(i*5);
            }
            for (int i = 0; i <= 23; i++)
            {
                comboBox_SH.Items.Add(i);
                comboBox_EH.Items.Add(i);
            }

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Text == "") { MessageBox.Show("vous n'avez pas remplie toute les cases ", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (comboBox_SH.Text == "") { MessageBox.Show("vous n'avez pas remplie toute les cases ", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (comboBox_SM.Text == "") { MessageBox.Show("vous n'avez pas remplie toute les cases ", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (comboBox_EH.Text == "") { MessageBox.Show("vous n'avez pas remplie toute les cases ", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (comboBox_EM.Text == "") { MessageBox.Show("vous n'avez pas remplie toute les cases ", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (textBox_place.Text == "") { MessageBox.Show("vous n'avez pas remplie toute les cases ", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (textBox_description.Text == "") { MessageBox.Show("vous n'avez pas remplie toute les cases ", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            //string dateFormats = "dd/MM/yyyy/HH/mm";
            //CultureInfo provider = newCultureInfo("fr-FR");
           


            string temp_1 = (dateTimePicker1.Value.ToString("dd/MM/yyyy") +" "+ comboBox_SH.Text +":"+ comboBox_SM.Text);
            string temp_2 = (dateTimePicker1.Value.ToString("dd/MM/yyyy") +" "+ comboBox_EH.Text +":"+ comboBox_EM.Text);
            label1.Text = dateTimePicker1.Value.ToString();
            label2.Text = temp_1;
            DateTime temp_start = DateTime.Parse(temp_1);

            DateTime temp_end = DateTime.Parse(temp_2);

            ((Form_Agenda)this.Owner).Add_event(temp_start, temp_end, textBox_place.Text, textBox_description.Text) ;

            this.Close();
        }

        private void button_annule_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
