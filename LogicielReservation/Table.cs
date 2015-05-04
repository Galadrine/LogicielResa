using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicielReservation
{
    class Table
    {
        private int _nbTotalTables;

        public int monNombreTotalTables
        {
            get { return _nbTotalTables; }
            set { _nbTotalTables = value; }
        }

        private bool jumelable;

        public bool MyProperty
        {
            get { return jumelable; }
            set { jumelable = value; }
        }


        private int _nbTable;

        public int monNumTable
        {
            get { return _nbTable; }
            protected set { _nbTable = value; }
        }

    }
}
