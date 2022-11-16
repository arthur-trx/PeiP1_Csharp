using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;



namespace bible2021
{
    internal class CSphere
    {
        double m_radius;

        public CSphere()
        {
            m_radius = 0;
        }
        public CSphere(double x)
        {
            m_radius = x;
        }

        public double[] coordonée (double Theta, double Phi)
        {
            double[] coordo = new double[3];
            coordo[0] = m_radius * Math.Cos(Theta) * Math.Cos(Phi);
            coordo[1] = m_radius * Math.Cos(Theta) * Math.Sin(Phi);
            coordo[2] = m_radius * Math.Sin(Theta);
            return coordo;
        }
        public double Surface (double Theta_1, double Theta_2, double Phi_1, double Phi_2)
        {
            double temp = m_radius * m_radius * (Math.Sin(Theta_1) - Math.Sin(Theta_2) ) * (Phi_2 - Phi_2);
            return temp;
        }
    }
}
