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

        #endregion


        #region getters/setters

        public List<Salle> MesSalles
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

        #endregion



    }
}
