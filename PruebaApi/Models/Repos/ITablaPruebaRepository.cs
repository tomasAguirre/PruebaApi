using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaApi.Models.Repos
{
    public interface ITablaPruebaRepository
    {
        List<TablaPrueba> GetPruebas();

        bool savePrueba(TablaPrueba prueba);
    }
}
