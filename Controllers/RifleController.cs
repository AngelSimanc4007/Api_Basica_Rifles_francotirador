using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIRifle.Models;

namespace APIRifle.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RifleController : ControllerBase
    {
        List<Rifle> rifles = new List<Rifle> //Una lista que almacena en memoria objetos de la clase Rifle, simulando una base de datos para poder hacer un crud basico
        {
            new Rifle
            {
                id_rifle = 1,
                nombre = "Chukavin SVch",
                tipo_bala = ".338 lapua magnum",  //Cada llamada al constructo Rifle es un objeto cuyos atributos tienen sus propios valores, pero con el mismo tipo de datos
                alcance_maximo_km = 1.5,
                tipo_rifle = "Semiautomatico"
            },
            new Rifle
            {
                id_rifle = 2,
                nombre = "CdX 50 Tremor",
                tipo_bala = ".50 BMG",
                alcance_maximo_km = 2.0,
                tipo_rifle = "Cerrojo"
            },
            new Rifle
            {
                id_rifle = 3,
                nombre = "Barret MRAD",
                tipo_bala = ".338 lapua magnum",
                alcance_maximo_km = 1.6,
                tipo_rifle = "Cerrojo"
            },
            new Rifle
            {
                id_rifle = 4,
                nombre = "M2010 Enhanced sniper rifle",
                tipo_bala = ".308 winchester magnum",
                alcance_maximo_km = 1.2,
                tipo_rifle = "Cerrojo"
            },
            new Rifle
            {
                id_rifle = 5,
                nombre = "Orsis T-5000",
                tipo_bala = ".338 lapua magnum",
                alcance_maximo_km = 2.0,
                tipo_rifle = "Cerrojo"
            },
            new Rifle
            {
                id_rifle = 6,
                nombre = "DesertTech SRS-A2",
                tipo_bala = ".338 lapua magnum",
                alcance_maximo_km = 1.5,
                tipo_rifle = "Cerrojo"
            },
            new Rifle
            {
                id_rifle = 7,
                nombre = "Cheytac M200 Intervention",
                tipo_bala = ".408 Cheytac",
                alcance_maximo_km = 2.3,
                tipo_rifle = "Cerrojo"
            },
            new Rifle
            {
                id_rifle = 8,
                nombre = "AS50",
                tipo_bala = ".50 BMG",
                alcance_maximo_km = 1.5,
                tipo_rifle = "Semiautomatico"
            },
            new Rifle
            {
                id_rifle = 9,
                nombre = "Mcmillan TAC-50c",
                tipo_bala = ".50 BMG",
                alcance_maximo_km = 3.5,
                tipo_rifle = "Cerrojo"
            },
            new Rifle
            {
                id_rifle = 10,
                nombre = "SVLK-14S TWILIGHT",
                tipo_bala = ".408 Cheytac",
                alcance_maximo_km = 3.5,
                tipo_rifle = "Cerrojo"
            }
        };

        [HttpGet]
        public ActionResult<List<Rifle>> GetAllRifles() //Retorna una lista de rifles, si esta vacia entonces nos devolvera un mensaje de error
        {
            var Rifles = rifles.Count();

            if (Rifles.Equals(0))
                return NotFound("There are no rifle to show");
            
            return Ok(rifles);
        }

        [HttpGet("{id}")]
        public ActionResult<Rifle> GetRifleById(int id) //Nos retorna un rifle especifico segun su id, si no esta entonces devolvera un mensaje de error
        {

            var GetRifle = rifles.FirstOrDefault(r => r.id_rifle == id);

            if (GetRifle == null)
                return NotFound("Rifle not found");
                
            return Ok(GetRifle);
        }

        [HttpPost]

        public ActionResult CreateRifle(Rifle rifle) //Creamos un rifle y nos devuelve en un JSON el rifle que creamos con Swagger para rectificar que le pusimos los datos correspondientes, respetando los tipos de datos
        {
         if(rifle == null)
           return BadRequest("You must create a rifle");

        rifles.Add(rifle);

        return CreatedAtAction(nameof(GetRifleById), new { id = rifle.id_rifle }, rifle);
        }

        [HttpPut("{id}")]
        public ActionResult<List<Rifle>> UpdateRifle(int id, Rifle rifle)//Nos devolvera la lista junto con el rifle actualizado
        {
            var FindRifle = rifles.FirstOrDefault(r => r.id_rifle == id);

            if (FindRifle == null)
                return NotFound();

            FindRifle.id_rifle = rifle.id_rifle;
            FindRifle.nombre = rifle.nombre;
            FindRifle.tipo_bala = rifle.tipo_bala;
            FindRifle.alcance_maximo_km = rifle.alcance_maximo_km;
            FindRifle.tipo_rifle = rifle.tipo_rifle;

            return Ok(rifles);

        }

        [HttpDelete("{id}")]

        public ActionResult<List<Rifle>> DeleteRifle(int id)//Nos devolvera la lista de rifles pero sin el que acabamos de eliminar
        {

            var FindRifle = rifles.FirstOrDefault(r => r.id_rifle == id);
            if (FindRifle == null)
                return NotFound();

            rifles.Remove(FindRifle);

            return Ok(rifles);
        }
    }
}
