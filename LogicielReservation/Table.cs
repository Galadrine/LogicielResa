using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicielReservation
{
    class Table
    {

        #region variables

        public int _nbTable;
        protected static int _nbTotalTables;
        protected string _etat;
        protected bool _mobile;

        #endregion



        #region getters/setters

        public int monNumTable
        {
            get { return _nbTable; }
            protected set { _nbTable = value; }
        }

        public int monNombreTotalTables
        {
            get { return _nbTotalTables; }
            set { _nbTotalTables = value; }
        }

        public bool MyProperty
        {
            get { return jumelable; }
            set { jumelable = value; }
        }

        public bool monJumelage
        {
            get { return _jumelable; }
            set { _jumelable = value; }
        }

        public string monEtat
        {
            get { return _etat; }
            set { _etat = value; }
        }

        public bool maMobilite
        {
            get { return _mobile; }
            set { _mobile = value; }
        }


        #endregion



    }
}
