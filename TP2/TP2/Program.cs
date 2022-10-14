namespace TP2
{
    class Program
    {
        static void Main()
        {
            Personne pers = new Personne();
            pers.Set_Nom("tarroux");
            pers.Set_PreNom("arthur");
            pers.Set_Masse(65);
            pers.Set_Taille((float) 1.84);
            Console.WriteLine(pers.IMC());
     

        }
    }
    public class Personne
    {
        private string m_nom;
        private string m_prenom;
        private float m_taille;
        private float m_masse;

        public Personne()
        {
            m_nom = null;
            m_prenom = null;
            m_taille = 0;
            m_masse = 0;
        }
        public Personne(string name, string firstname, float size, float weight)
        {
            m_nom = name;
            m_prenom = firstname;
            m_taille = size;
            m_masse = weight;
        }

        public string Get_Nom() { return m_nom; }
        public string Get_PreNom() { return m_prenom; }
        public float Get_Taille() { return m_taille; }
        public float Get_Masse() { return m_masse; }

        public void Set_Nom(string nom) { m_nom = nom; }
        public void Set_PreNom(string prenom) {m_prenom = prenom; }
        public void Set_Taille(float taille) { m_taille = taille; }
        public void Set_Masse(float masse) { m_masse = masse; }

        public string IMC ()
        {
            float ICM;
            string legende;
            ICM = m_masse / (m_taille*m_taille);
            if (ICM < 16.5) legende = "denutrition";
            else if (ICM < 18.5) legende = "maigreur";
            else if (ICM < 25) legende = "corpulence normale";
            else legende = "surpodis";
            return legende;
        }
    }
}