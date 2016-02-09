using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoGestionEmployes
{
    public class Ville
    {
        public int IdVille;
        public string CodeVille;
        public string DescriptionVille;

        public Ville()
        {
        }
        public Ville(int IdVilleTmp, string CodeVilleTmp, string DescriptionVilleTmp)
        {
            this.IdVille = IdVilleTmp;
            this.CodeVille = CodeVilleTmp;
            this.DescriptionVille = DescriptionVilleTmp;
        }
        public int idVille
        {
            get { return IdVille; }
            set
            {
                IdVille = value;
            }
        }
        public string codeVille
        {
            get { return CodeVille; }
            set
            {
                CodeVille = value;
            }
        }
        public string descriptionVille
        {
            get { return DescriptionVille; }
            set
            {
                DescriptionVille = value;
            }
        }
    }
}
