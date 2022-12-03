using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TARROUX_Arthu_DS3
{
    public partial class Form_Agenda : Form
    {
        List<CEvenement> _AgendaList = new List<CEvenement>();
        string _file_path;
        public Form_Agenda()
        {
            InitializeComponent();
        }

        public void Maj_ListeView()
        {
            listView_main.Items.Clear();
            foreach (CEvenement e in _AgendaList) 
            {
                var temp = new ListViewItem(e.All() );
                listView_main.Items.Add(temp); 
            }
        }

        public void Add_event (DateTime start, DateTime end, string place, string description)
        {
            CEvenement temp = new CEvenement(start, end, place, description);
            _AgendaList.Add(temp);
        }

        private void ajouterUnÉvénementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_add_event form_Add_Event= new Form_add_event();
            if (form_Add_Event.ShowDialog() == DialogResult.OK)
            {
                Maj_ListeView();
                return;
            }
            else return;
        }

        private void supprimerUnÉvénementrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem I in listView_main.SelectedItems)
            {
                _AgendaList.RemoveAt(I.Index);
                //listView_main.Items.RemoveAt(I.Index);
                Maj_ListeView();
            }

        }

        private void enregistrerSousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog_save= new SaveFileDialog();
            StreamWriter writer;

            dialog_save.InitialDirectory = "c:\\temp\\";
            dialog_save.Filter = "Fichier texte(*.txt)|*.txt|Tous les fichiers(*.*) | *.* ";
            if (dialog_save.ShowDialog() == DialogResult.OK)
            {

                writer = new StreamWriter(dialog_save.FileName);
                writer.WriteLine(_AgendaList.Count);
                foreach(CEvenement eve in _AgendaList) 
                {
                    writer.WriteLine(eve.stratS);
                    writer.WriteLine(eve.endS);
                    writer.WriteLine(eve.lieu);
                    writer.WriteLine(eve.description);

                }
                _file_path = dialog_save.FileName;
                writer.Close();
            }

        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog_open= new OpenFileDialog();
            StreamReader reader;

            if (dialog_open.ShowDialog() == DialogResult.OK)
                {
                reader = new StreamReader(dialog_open.FileName);
                int nb = reader.Read();
                for (int x =0; x< nb; x++) 
                {
                    string[] temp = new string[4];
                    temp[0] = reader.ReadLine();
                    temp[1] = reader.ReadLine();
                    temp[2] = reader.ReadLine();
                    temp[3] = reader.ReadLine();

                    DateTime temp_start = DateTime.Parse(temp[0]);

                    DateTime temp_end = DateTime.Parse(temp[1]);
                    Add_event(temp_start, temp_end, temp[2], temp[3]);

                }
                _file_path = dialog_open.FileName;
                reader.Close();
                return;
            }
            return;

        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter writer;
            writer = new StreamWriter(_file_path);
            writer.WriteLine(_AgendaList.Count);
            foreach (CEvenement eve in _AgendaList)
            {
                writer.WriteLine(eve.stratS);
                writer.WriteLine(eve.endS);
                writer.WriteLine(eve.lieu);
                writer.WriteLine(eve.description);

            }
            writer.Close();

        }
    }
}
