using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoGestionEmployes
{
    public class Adresse
    {
        public int IdAdresse;
        public string NumeroRue;
        public string NomRue;
        public string CodePostal;
        public int IdVille;
        public int IdUtilisateur;

        public Adresse()
        {
        }
        /*public Adresse(string NumeroRueTmp, string NomRueTmp, string CodePostalTmp, int IdVilleTmp, int IdUtilisateurTmp)
        {
            this.NumeroRue = NumeroRueTmp;
            this.NomRue = NomRueTmp;
            this.CodePostal = CodePostalTmp;
            this.IdVille = IdVilleTmp;
            this.IdUtilisateur = IdUtilisateurTmp;
        }*/
        public Adresse(int IdAdresseTmp, string NumeroRueTmp, string NomRueTmp, string CodePostalTmp, int IdVilleTmp, int IdUtilisateurTmp)
        {
            this.IdAdresse = IdAdresseTmp;
            this.NumeroRue = NumeroRueTmp;
            this.NomRue = NomRueTmp;
            this.CodePostal = CodePostalTmp;
            this.IdVille = IdVilleTmp;
            this.IdUtilisateur = IdUtilisateurTmp;
        }
        public string numeroRue
        {
            get { return NumeroRue; }
            set
            {
                NumeroRue = value;
            }
        }
        public string nomRue
        {
            get { return NomRue; }
            set
            {
                NomRue = value;
            }
        }
        public string codePostal
        {
            get { return CodePostal; }
            set
            {
                CodePostal = value;
            }
        }
        public int idVille
        {
            get { return IdVille; }
            set
            {
                IdVille = value;
            }
        }
        public int idUtilisateur
        {
            get { return IdUtilisateur; }
            set
            {
                IdUtilisateur = value;
            }
        }
    }
    

}
