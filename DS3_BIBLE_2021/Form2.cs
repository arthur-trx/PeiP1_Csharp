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
    public partial class Form_add_plas : Form
    {
        public Form_add_plas()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            //add error messge if empty
            ((Form1)this.Owner).Ajouter_Plat(textBox_name.Text, float.Parse(textBox_price.Text));
            this.Close();
        }
    }
}
