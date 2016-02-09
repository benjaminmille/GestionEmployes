using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoGestionEmployes
{
    public class Role
    {
        public int IdRole;
        public string CodeRole;
        public string DescriptionRole;

        public Role()
        {
        }
        public Role(int IdRoleTmp, string CodeRoleTmp, string DescriptionRoleTmp)
        {
            this.IdRole = IdRoleTmp;
            this.CodeRole = CodeRoleTmp;
            this.DescriptionRole = DescriptionRoleTmp;
        }
        public int idRole
        {
            get { return IdRole; }
            set
            {
                IdRole = value;
            }
        }
        public string codeRole
        {
            get { return CodeRole; }
            set
            {
                CodeRole = value;
            }
        }
        public string descriptionRole
        {
            get { return DescriptionRole; }
            set
            {
                DescriptionRole = value;
            }
        }
    }
}
