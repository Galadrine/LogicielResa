using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicielReservation
{
    class Salle
    {
        #region variables

        protected string _nom;
        protected List<Table> _tables;

        #endregion


        #region getters/setters

        public List<Table> mesTables
        {
            get { return _tables; }
            set { _tables = value; }
        }

        public string monNom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        #endregion


        #region constructeur


        #endregion


        #region methodes



        #endregion


    }
}
