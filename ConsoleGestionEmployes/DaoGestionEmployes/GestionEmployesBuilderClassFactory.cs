using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoGestionEmployes
{
    public class GestionEmployesBuilderClassFactory
    {
        public static IGestionEmployes getInterface()
        {
               return new DaoGestionEmployes.ImplementationSql.GestionEmployes();
        }
    }
}
