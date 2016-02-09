using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoGestionEmployes
{
    public class Societe
    {
        public int IdSociete;
        public string NomSociete;
        public string DescriptionSociete;
        public string NumeroSiret;

        public Societe()
        {
        }
        public Societe(int IdSocieteTmp, string NomSocieteTmp, string DescriptionSocieteTmp, string NumeroSiretTmp)
        {
            this.IdSociete = IdSocieteTmp;
            this.NomSociete = NomSocieteTmp;
            this.DescriptionSociete = DescriptionSocieteTmp;
            this.NumeroSiret = NumeroSiretTmp;
        }
        public int idSociete
        {
            get { return IdSociete; }
            set
            {
                IdSociete = value;
            }
        }
        public string nomSociete
        {
            get { return NomSociete; }
            set
            {
                NomSociete = value;
            }
        }
        public string descriptionSociete
        {
            get { return DescriptionSociete; }
            set
            {
                DescriptionSociete = value;
            }
        }
        public string numeroSiret
        {
            get { return NumeroSiret; }
            set
            {
                NumeroSiret = value;
            }
        }
    }
}
