using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoGestionEmployes
{
    public class Utilisateur
    {
        public int IdUtilisateur;
        public int IdRole;
        public string Identifiant;
        public string MotPasse;
        public DateTime DateDebut;
        public DateTime DateFin;
        public string Prenom;
        public string Nom;
        public int IdSociete;

        public Utilisateur()
        {
        }
        public Utilisateur(int IdUtilisateurTmp, int IdRoleTmp, string IdentifiantTmp, string MotPasseTmp, DateTime DateDebutTmp, DateTime DateFinTmp, string PrenomTmp, string NomTmp, int IdSocieteTmp)
        {
            this.IdUtilisateur = IdUtilisateurTmp;
            this.IdRole = IdRoleTmp;
            this.Identifiant = IdentifiantTmp;
            this.MotPasse = MotPasseTmp;
            this.DateDebut = DateDebutTmp;
            this.DateFin = DateFinTmp;
            this.Prenom = PrenomTmp;
            this.Nom = NomTmp;
            this.IdSociete = IdSocieteTmp;
        }
        public int idUtilisateur
        {
            get { return IdUtilisateur; }
            set
            {
                IdUtilisateur = value;
            }
        }
        public int idRole
        {
            get { return IdRole; }
            set
            {
                IdRole = value;
            }
        }
        public string identifiant
        {
            get { return Identifiant; }
            set
            {
                Identifiant = value;
            }
        }
        public string motPasse
        {
            get { return MotPasse; }
            set
            {
                MotPasse = value;
            }
        }
        public DateTime dateDebut
        {
            get { return DateDebut; }
            set
            {
                DateDebut = value;
            }
        }
        public DateTime dateFin
        {
            get { return DateFin; }
            set
            {
                DateFin = value;
            }
        }
        public string prenom
        {
            get { return Prenom; }
            set
            {
                Prenom = value;
            }
        }
        public string nom
        {
            get { return Nom; }
            set
            {
                Nom = value;
            }
        }
        public int idSociete
        {
            get { return IdSociete; }
            set
            {
                IdSociete = value;
            }
        }
    }
}
