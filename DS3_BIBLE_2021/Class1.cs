using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DS3_BIBLE_2021
{
    public class CPlat
    {
        private int m_id;
        private string m_name;
        private float m_price;
        

        public CPlat(int id, string name, float price)
        {
            m_id =id;
            m_name = name;
            m_price = price;
        }

        /*public CPlat( string name, float price)
        {
            m_id = Form1.count_plat; count_plat++;
            m_name = name;
            m_price = price;
        }*/

        public CPlat(CPlat cPlat)
        {
            m_id = cPlat.m_id;
            m_name = cPlat.m_name;
            m_price = cPlat.m_price;
        }

        public int Id
        {
            get { return m_id; }
            set { m_id = value; }
        }
        public float Price
        {
            get { return m_price; }
            set { m_price = value; }
        }

        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

    }

    public class CRepas
    {
        private int m_id;
        private List<CPlat> m_list;

        public CRepas(int id, CPlat[] list)
        {
            m_id = id;
            m_list = new List<CPlat>(); 
            m_list.Add(list[0]);
            m_list.Add(list[1]);
            m_list.Add(list[2]);
        }
        public CRepas(int id)
        {
            m_id = id;
            m_list = new List<CPlat>();
        }


        public int Id
        {
            get { return m_id; }
            set { m_id = value; }
        }

        public List<CPlat> List
        {

            get { return m_list; }
            set { m_list = value; }

        }

        public double Prix_Repas()
        {
            float somme = 0;
            foreach (CPlat p in m_list) 
            {
                somme += p.Price;
            }
            return somme;
        }
        
        public string[] All()
        {
            string[] temp = new string[5];
            temp[0] = m_id.ToString() ;
            temp[1] = m_list[0].Name;
            temp[2] = m_list[1].Name;
            temp[3] = m_list[2].Name;
            temp[4] = Prix_Repas().ToString();


            return temp;

        }
            

    }
}
