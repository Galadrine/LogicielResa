using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicielReservation
{
    class Restaurant
    {
        #region variables

        protected List<Salle> _salles;
        protected List<Personnel> _personnels;
        protected List<Formule> _formules;
        protected string _nom;
        protected string _motDePasse;
        protected DateTime[] _horaires;
        protected List<Reservation> _reservations;

        
        #endregion


        #region getters/setters

        public List<Salle> mesSalles
        {
            get { return _salles; }
            set { _salles = value; }
        }

        public List<Personnel> mesPersonnels
        {
            get { return _personnels; }
            set { _personnels = value; }
        }

        public List<Formule> mesFormules
        {
            get { return _formules; }
            set { _formules = value; }
        }

        public DateTime[] mesHoraires
        {
            get { return _horaires; }
            set { _horaires = value; }
        }

        public string monMotDePasse
        {
            get { return _motDePasse; }
            set { _motDePasse = value; }
        }


        public string monNom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public List<Reservation> mesReservations
        {
            get { return _reservations; }
            set { _reservations = value; }
        }

        #endregion


        #region constructeur

        public Restaurant(String restaurant, string mdp)
        {
            monNom = restaurant;
            mesSalles = new List<Salle>();
            mesFormules = new List<Formule>();
            mesReservations = new List<Reservation>();
            mesPersonnels = new List<Personnel>();
            monMotDePasse = mdp;
        }   

        #endregion


        #region methodes



        #endregion

    }
}
