using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicielReservation
{
    class Reservation
    {
        #region variables

        private DateTime _date;
        private int _numConvives;
        private string _formule;
        private string _nomReservation;
        private string _numeroTelephone;

        public string monNumeroReservation
        {
            get { return _numeroTelephone; }
            set { _numeroTelephone = value; }
        }
        


        public string monNomReservation
        {
            get { return _nomReservation; }
            set { _nomReservation = value; }
        }
        
        public string maFormule
        {
            get { return _formule; }
            set { _formule = value; }
        }
        

        public int monNumConvives
        {
            get { return _numConvives; }
            set { _numConvives = value; }
        }
        

        public DateTime maDate
        {
            get { return _date; }
            set { _date = value; }
        }
        

        #endregion


        #region getters/setters



        #endregion


        #region constructeur



        #endregion


        #region methodes



        #endregion

    }
}
