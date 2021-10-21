using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaApi.Models.Repos
{
    public class PruebaRepository : ITablaPruebaRepository
    {
        DBContext dBContext = new DBContext();
        public List<TablaPrueba> GetPruebas()
        {
            return dBContext.TablaPruebas.ToList();
        }

        public bool savePrueba(TablaPrueba prueba)
        {
            dBContext.TablaPruebas.Add(prueba);
            return true;
        }
    }

}
