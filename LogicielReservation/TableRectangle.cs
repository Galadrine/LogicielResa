using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicielReservation
{
    class TableRectangle
    {
        #region variables

        private int[] _numPlaces;
        private bool[] _cotesJumelables;
        private bool[] _cotesJumeles;



        #endregion



        #region getters/setters

        public int[] monNumPlaces
        {
            get { return _numPlaces; }
            set { _numPlaces = value; }
        }

        public bool[] mesCotesJumeles
        {
            get { return _cotesJumeles; }
            set { _cotesJumeles = value; }
        }


        public bool[] mesCotesJumelables
        {
            get { return _cotesJumelables; }
            set { _cotesJumelables = value; }
        }
        


        #endregion
    }
}
