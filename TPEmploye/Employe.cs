using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPEmploye
{
    /// <summary>
    /// Classe représentant un employé
    /// </summary>
    public class Employe
    {
        // attributs
        #region Attributs
        private uint _Matricule;
        private string _Nom;
        private string _Prenom;
        private DateTime _DateNaissance;
        private DateTime _DateEmbauche;
        private decimal _Salaire;
        #endregion

        #region Constructeurs
        public Employe(uint matricule, string nom, string prenom, DateTime dateNaissance, DateTime dateEmbauche, decimal salaire)
        {
            Matricule = matricule;
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            DateEmbauche = dateEmbauche;
            Salaire = salaire;
        }
        #endregion

        #region Propriétés
        public uint Matricule { get => _Matricule; set => _Matricule = value; }
        public string Nom { get => _Nom; set => _Nom = value; }
        public string Prenom { get => _Prenom; set => _Prenom = value; }
        public DateTime DateNaissance { get => _DateNaissance; set => _DateNaissance = value; }
        public DateTime DateEmbauche { get => _DateEmbauche; set => _DateEmbauche = value; }
        public decimal Salaire { get => _Salaire; set => _Salaire = value; }
        #endregion

        #region Méthodes

        /// <summary>
        /// Fonction retournant l'âge de la personne
        /// </summary>
        /// <returns></returns>
        public int Age()
        {
            int Age = DateTime.Today.Year - this.DateNaissance.Year;
            if (this.DateNaissance.DayOfYear > DateTime.Today.DayOfYear)
            {
                Age--;
            }

            return Age;
        }


        /// <summary>
        /// Fonction retournant l'ancienneté de la personne
        /// </summary>
        /// <returns></returns>
        public int Anciennete()
        {
            int Anciennete = DateTime.Today.Year - this.DateEmbauche.Year;
            if (this.DateEmbauche.DayOfYear > DateTime.Today.DayOfYear)
            {
                Anciennete--;
            }
            return Anciennete;
        }

        /// <summary>
        /// Fonction mettant à jour le salaire de l'employé en fonction de son ancienneté
        /// </summary>
        public void AugmentationSalaire()
        {
            int Anciennete = this.Anciennete();
            if (Anciennete < 5)
            {
                Salaire *= 1.02m;
            }
            else if (Anciennete < 10)
            {
                Salaire *= 1.05m;
            }
            else
            {
                Salaire *= 1.1m;

            }
        }

        /// <summary>
        /// Procédure affichant les informations de l'employé
        /// </summary>
        public void AfficherEmploye()
        {
            Console.WriteLine($"- Matricule : {Matricule}\n" +
                $"- Nom complet : {Nom.ToUpper()} {Prenom[0].ToString().ToUpper()+Prenom.Substring(1).ToLower()}\n" +
                $"- Age : {Age()}\n" +
                $"- Ancienneté : {Anciennete()}\n" +
                $"- Salaire : {Salaire} ");
        }
        #endregion
    }
}
