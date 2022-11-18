using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_2022
{
    internal class CIngredient
    {
        private string m_nom;
        private int m_quantite;
        private string m_unite;
        public CIngredient(string nom, int quantite, string unite)
        {
            m_nom = nom;
            m_quantite = quantite;
            m_unite = unite;
        }
        public CIngredient()
        {
            m_nom = null;
            m_quantite = 0;
            m_unite = null;

        }

        public string nom { get { return m_nom; } set { m_nom = value; } }
        public int quantite { get { return m_quantite; } set { m_quantite = value; } }
        public string unite { get { return m_unite; } set { m_unite = value; } }

        public string[] All()
        {
            string[] temp = { m_nom, m_quantite + "  " + m_unite };

            return temp;
        }

    }

    internal class CRecette
    {
        string m_nom;
        string m_intruction;
        List<CIngredient> m_LIngredients;

        public CRecette(string nom, string intruction, List<CIngredient> c_LIngredients)
        {
            m_nom = nom;
            m_intruction = intruction;
            this.m_LIngredients = new List<CIngredient>();
        }


        public List<CIngredient> GetListe()
        {
            return m_LIngredients;
        }

        public string nom { get { return m_nom; } set { m_nom = value; } }
        public string instruction { get { return m_intruction; } set { m_intruction = value;} }

        public void Add(CIngredient temp)
        {
            m_LIngredients.Add(temp);
        }

 

    }
    

}
