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

namespace TP9
{
    public partial class FormTextEditor : Form
    {
        StreamWriter writer;
        StreamReader reader;
        Form_Recherche F_Rechercher = new Form_Recherche();
        OpenFileDialog dialog = new OpenFileDialog();
        SaveFileDialog dialog_save = new SaveFileDialog();
        bool m_is_modified = false;
        string m_file_path = ""; //attenetion je vais avoir des erreur;
       
        public FormTextEditor()
        {
            InitializeComponent();
            F_Rechercher.Owner = this; 
        }
        public void Surligne(int debut, int longueur)
        {
            richTextBox_main.Select(debut, longueur);

        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialog.InitialDirectory = Application.ExecutablePath;
            dialog.Filter = "Fichier texte(*.txt)|*.txt|Tous les fichiers(*.*) | *.* ";
            dialog.FilterIndex = 0;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                reader = new StreamReader(dialog.FileName);
                richTextBox_main.Text = reader.ReadToEnd();
                reader.Close();
                enregistrerToolStripMenuItem.Enabled = true;
                enregisterSousToolStripMenuItem.Enabled = true;
                m_file_path = dialog.FileName;
            }
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            writer = new StreamWriter(m_file_path);
            writer.Write(richTextBox_main.Text);
            writer.Close();
            m_is_modified = false;
        }

        private void enregisterSousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialog_save.InitialDirectory = "c:\\temp\\";
            dialog_save.Filter = "Fichier texte(*.txt)|*.txt|Tous les fichiers(*.*) | *.* ";
            if (dialog_save.ShowDialog() == DialogResult.OK)
            {

                writer = new StreamWriter(dialog_save.FileName);
                writer.Write(richTextBox_main.Text);
                m_file_path = dialog_save.FileName;
                writer.Close();
                m_is_modified = false;
            }

        }

        private void richTextBox_main_TextChanged(object sender, EventArgs e)
        {
            m_is_modified = true;
        }

        private void FormTextEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_is_modified == true)
            {
                /*if (MessageBox.Show("Votre Texte a été modifié, mais non sauvegardé. Souhaitez-vous enregistre les modifications avant de quitter ?", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    writer = new StreamWriter(m_file_path);
                    writer.Write(richTextBox_main.Text);
                    writer.Close();
                    m_is_modified = false;

                }*/
                MessageBox.Show("Votre Texte a été modifié, mais non sauvegardé. Souhaitez-vous enregistre les modifications avant de quitter ?", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    writer = new StreamWriter(m_file_path);
                    writer.Write(richTextBox_main.Text);
                    writer.Close();
                    m_is_modified = false;

                }
                /*if (DialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }*/


            }
        }
    }
}
