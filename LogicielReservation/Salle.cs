using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicielReservation
{
    class Salle
    {
        private List<Table> _tables;

        public List<Table> mesTables
        {
            get { return _tables; }
            set { _tables = value; }
        }


    }
}
