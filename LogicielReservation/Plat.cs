﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicielReservation
{
    class Plat
    {
        #region variables

        private string _nom;
        private string _type;
        private DateTime _tempsPresence;
        private DateTime _tempsPreparation;

        

        #endregion


        #region getters/setters

        public DateTime monTempsPreparation
        {
            get { return _tempsPreparation; }
            set { _tempsPreparation = value; }
        }


        public DateTime monTempsPresence
        {
            get { return _tempsPresence; }
            set { _tempsPresence = value; }
        }


        public string monType
        {
            get { return _type; }
            set { _type = value; }
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
