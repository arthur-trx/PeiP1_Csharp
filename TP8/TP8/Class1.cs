using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP8
{
    internal class POI
    {
        private string m_latitude;
        private string m_longitude;

        public POI()
        {
            m_latitude = null;
            m_longitude = null;
        }
        public POI(string latitude, string longitude)
        {
            m_latitude = latitude;
            m_longitude = longitude;
        }
        public POI(string[] tab)
        {
            m_latitude = tab[0];
            m_longitude = tab[1];
        }
        public string[] All()
        {
            string[] temp = { m_latitude, m_longitude };
            return temp;

        }
    }
}
