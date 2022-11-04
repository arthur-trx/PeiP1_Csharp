using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5
{
    internal class EtatCivil
    {
        private string m_sName;
        private string m_sPrenom;
        private char m_cSexe;
        private DateTime m_dBirthDate;
        private string m_dBirthPlace;

        EtatCivil()
        {
            m_sName = null;
            m_sPrenom = null;
            m_cSexe = '0';
            m_dBirthDate = new DateTime(0);
            m_dBirthPlace = null;
        }

        public EtatCivil(string s1, string s2, char c1, DateTime d1, string s3)
            {
            m_sName = s1;
            m_sPrenom = s2;
            m_cSexe = c1;
            m_dBirthDate = d1;
            m_dBirthPlace = s3;
        }

        public string name
        {
            get { return m_sName; }
            set { m_sName = value; }
        }
        public string firstname
        {
            get { return m_sPrenom; }
            set { m_sPrenom = value; }
        }
        public char Sexe
        {
            get { return m_cSexe; }
            set { m_cSexe = value; }
        }

        public string Sexe_string()
        {
            string s = "" ;
            if (m_cSexe == 'H') s = "Homme";
            else if (m_cSexe == 'F') s = "Femme";
            else if (m_cSexe == 'N') s = "NSPR / non binaire";
            else { s = "erreur"; }
            return s;
        }
        public DateTime BirthDate
        {
            get { return m_dBirthDate; }
            set { m_dBirthDate = value; }
        }
        public string Birth_string()
        {
            return m_dBirthDate.ToString("dd/MM/yyyy");
        }
        public string BirthPlace
        {
            get {  return m_dBirthPlace; }
            set { m_dBirthPlace = value; }
        }
        public string[] all()
        {
            string[] temp = { m_sName, m_sPrenom, this.Sexe_string(), this.Birth_string(), BirthPlace };


            return temp;
        }

        public int Age()
        {
           
            int age = DateTime.Today.Year - m_dBirthDate.Year -1;
            if (m_dBirthDate.Month < DateTime.Today.Month)
                age++;
            if (m_dBirthDate.Day == DateTime.Today.Month && m_dBirthDate.Day < DateTime.Today.Day)
                age++;
            return age;
        }
    }
}