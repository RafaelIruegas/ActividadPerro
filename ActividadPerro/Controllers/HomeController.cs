using ActividadPerro.Models.Entities;
using ActividadPerro.Models.ViewModels;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ActividadPerro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string id)
        {
            PerrosContext context = new();
            IndexViewModels vm = new();
            if (id != null)
            {
                var dato = context.Razas.Where(x => x.Nombre.Substring(0, 1) == id).Select(x =>
           new Dog
           {
               Id = (int)x.Id,
               NamePerro = x.Nombre ?? " "
           }).OrderBy(x => x.NamePerro).ToList();
                vm.DogList = dato;
                return View(vm);
            }
            else
            {

            var dato = context.Razas.Select(x =>
            new Dog
            {
                Id = (int)x.Id,
                NamePerro = x.Nombre ?? " "
            }).OrderBy(x => x.NamePerro).ToList();
            vm.DogList = dato;
            return View(vm);
            }
        }
        [Route("/Pais")]
        public IActionResult Pais()
        {
            PerrosContext contex = new();
            Pais vm = new();
            var datopais = contex.Paises.Select(x=>
            new Pai
            {
                Id=x.Id,
                NamePais = x.Nombre ?? " ",
                perros = x.Razas.Select(x => 
                new Perro
                {
                    Id=(int)x.Id,
                    Nombre = x.Nombre,
                }),
            }).OrderBy(x=> x.NamePais).ToList();
            vm.pai = datopais;
            return View(vm);
        }
        [Route("raza/{nombre}")]
        public IActionResult Raza(string nombre) 
        {
            nombre = nombre.Replace("_", " ");
            PerrosContext contex = new();
            Razas vm = new();
            var datoraza = contex.Razas.Where(x => x.Nombre == nombre).Select(x =>
            new Raza
            {
                Id = (int)x.Id,
                NameRaza = x.Nombre ?? " ",
                Description = x.Descripcion,
                OtroNombre = x.OtrosNombres ?? " ",
                NomPais = x.Nombre,
                PesoMax = (int)x.PesoMax,
                PesoMin = (int)x.PesoMin,
                AlturaMax = (int)x.AlturaMax,
                AlturaMin = (int)x.AlturaMin,
                Esperanza = (int)x.EsperanzaVida,
                Pelo = x.Caracteristicasfisicas.Pelo,
                Cola = x.Caracteristicasfisicas.Cola,
                Hosico = x.Caracteristicasfisicas.Hocico,
                Color = x.Caracteristicasfisicas.Color,
                Patas = x.Caracteristicasfisicas.Patas,
                AmistadDesconocido = x.Estadisticasraza.AmistadDesconocidos,
                NivelEnergia = x.Estadisticasraza.NivelEnergia,
                EjercicioObligatorio = x.Estadisticasraza.EjercicioObligatorio,
                AmistadePerro = x.Estadisticasraza.AmistadPerros,
                FacilidadEntrenamiento = x.Estadisticasraza.FacilidadEntrenamiento,
                NecesidadCepillado = x.Estadisticasraza.FacilidadEntrenamiento
            }).First();
            return View(datoraza);
        }
    }
}
