using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4
{
    public partial class Vecteur_v1 : Form
    {
        private int[] m_vecteur = new int [3];
        public Vecteur_v1()
        {
            m_vecteur[0] = 0;
            m_vecteur[1] = 0;
            m_vecteur[2] = 0;
            InitializeComponent();

        }
        public Vecteur_v1(int a, int b, int c)
        {
            m_vecteur[0] = a;
            m_vecteur[1] = b;
            m_vecteur[2] = c;
            InitializeComponent();

        }
        public Vecteur_v1 GetV1()
        {
            int a = int.Parse(textBox_v1_x.Text);
            int b = int.Parse(textBox_v1_y.Text); 
            int c = int.Parse(textBox_v1_z.Text);
            Vecteur_v1 V1 = new Vecteur_v1(a,b,c);

            return V1;
        }

        public Vecteur_v1 GetV2()
        {
            int a = int.Parse(textBox_v2_x.Text);
            int b = int.Parse(textBox_v2_y.Text);
            int c = int.Parse(textBox_v2_z.Text);
            Vecteur_v1 V2 = new Vecteur_v1(a, b, c);

            return V2;
        }

        public Vecteur_v1 Vectoriel (Vecteur_v1 a, Vecteur_v1 b)
        {
   
            int A = a.vecteur_b * b.vecteur_c - a.vecteur_c * b.vecteur_b;
            int B= a.vecteur_c * b.vecteur_a - a.vecteur_a * b.vecteur_c;
            int C = a.vecteur_a * b.vecteur_b - a.vecteur_b * b.vecteur_a;
            Vecteur_v1 vs = new Vecteur_v1(A, B, C);
            return vs;
        }

        public int Scalaire (Vecteur_v1 a, Vecteur_v1 b)
        {
            int calc = a.vecteur_a * b.vecteur_a + a.vecteur_b * b.vecteur_b + a.vecteur_c * b.vecteur_c;

            return calc;
        }

        private void Vecteur_Load(object sender, EventArgs e)
        {

        }

        public int vecteur_a
        {
            get { return m_vecteur[0]; }
            set { m_vecteur[0] = value; }
        }
        public int vecteur_b
        {
            get { return m_vecteur[1]; }
            set { m_vecteur[1] = value; }
        }
        public int vecteur_c
        {
            get { return m_vecteur[2]; }
            set { m_vecteur[2] = value; }
        }

        /*private void label1_Click(object sender, EventArgs e)
        {

        }*/

        private void produitScalaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            textBox_v3_y.Text = Scalaire(GetV1(), GetV2()).ToString();
            textBox_v3_x.Visible = false;
            textBox_v3_z.Visible = false;
        }



        private void produitVectorielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vecteur_v1 Vsca = new Vecteur_v1();
            Vsca = Vectoriel(GetV1(), GetV2());

            textBox_v3_x.Text = (Vsca.vecteur_a).ToString();
            textBox_v3_y.Text = (Vsca.vecteur_b).ToString();
            textBox_v3_z.Text = (Vsca.vecteur_c).ToString();
            textBox_v3_x.Visible = true;
            textBox_v3_z.Visible = true;
        }
    }
}
/**/