using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARROUX_Arthu_DS3
{
    public class CEvenement
    {
        DateTime _start;
        DateTime _end;
        string _lieux;
        string _description;

        public CEvenement(DateTime start, DateTime end, string lieux, string description)
        {
            _start = start;
            _end = end;
            _lieux = lieux;
            _description = description;
        }

        public DateTime strat
        {
            get { return _start; }
            set { _start = value; }
        }

        public String stratS
        {
            get { return _start.ToString("dd/MM/yyyy/HH/mm"); }
        }
        public String endS
        {
            get { return _end.ToString("dd/MM/yyyy/HH/mm"); }
        }

        public DateTime end
        {
            get { return _end; }
            set { _end = value; }
        }
        public string lieu
        {
            get { return _lieux; }
            set { _lieux = value; }
        }
        public string description
        {
            get { return _description; }
            set { _description = value; }
        }


        public string[] All()
        {
            string[] temp_tab = new string[4];
            temp_tab[0] = _start.ToString("dd/MM/yyyy/HH/mm");
            temp_tab[1] = _end.ToString("dd/MM/yyyy/HH/mm");
            temp_tab[2] = _lieux;
            temp_tab[3] = _description;
            return temp_tab;
        }
    }
}
