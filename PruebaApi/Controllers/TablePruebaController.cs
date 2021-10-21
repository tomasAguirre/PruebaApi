using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaApi.Models;
using PruebaApi.Models.Repos;

namespace PruebaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TablePruebaController : Controller
    {
        ITablaPruebaRepository repoTablaPrueba;
        public TablePruebaController(ITablaPruebaRepository tablaPrueba)
        {
            this.repoTablaPrueba = tablaPrueba;
        }
        // GET: TablePrueba
        public ActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult getPruebas() {
            try
            {
                var pruebas = repoTablaPrueba.GetPruebas();
                return Ok(pruebas);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public ActionResult addPrueba(string nombrePrueba)
        {
            try
            {
                TablaPrueba tablaPrueba = new TablaPrueba();
                tablaPrueba.NombrePrueba = nombrePrueba;
                bool resultado = repoTablaPrueba.savePrueba(tablaPrueba);
                return Ok(resultado);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}