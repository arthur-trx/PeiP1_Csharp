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
    public partial class coordonnees : Form
    {
        public coordonnees()
        {
            InitializeComponent();
        }

        public string[] GetCoordo()
        {
            string[] temp = new string [2];
            temp[0] = textBoxLatitudeX.Text + textBoxLatitudeY.Text + textBoxLatitudeZ.Text;
            temp[1] = textBoxLongitudeX.Text + textBoxLongitudeY.Text + textBoxLongitudeZ.Text;
            return temp;
        }


    }
}
