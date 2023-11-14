using ApiSederhana.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiSederhana.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalController : ControllerBase
    {
        private static List<Personal> personal = new List<Personal>()
        {
            new Personal()
            {
                Umur = 28,
                Name = "Yanti PWK",
                //Alamat = "Ciamis",
                Address = new Alamat{Kecamatan = "Kawali",Kota = "Ciamis",Provinsi = "Jawa Barat"},
                Skill = new List<string>{ "JavaScript","Kalkulus"}
            },
            new Personal()
            {
                Umur = 52,
                Name = "Pak Iwan",
                //Alamat = "Bandung",
                Address = new Alamat{Kecamatan = "Cicendo",Kota = "Bandung",Provinsi = "Jawa Barat"},
                Skill = new List<string>{ "Marah-marah","Photographer"}
            },
            new Personal()
            {
                Umur = 30,
                Name = "Pak Nyoman",
                //Alamat = "Pasteur",
                Address = new Alamat{Kecamatan = "Pasteur",Kota = "Bandung",Provinsi = "Jawa Barat"},
                Skill = new List<string>{ "Kemanan","Bulu Tangkis"}
            },
            new Personal()
            {
                Umur = 45,
                Name = "Pak Dany",
                //Alamat = "Cimindi",
                Address = new Alamat{Kecamatan = "Cimindi",Kota = "Bandung",Provinsi = "Jawa Barat"},
                Skill = new List<string>{ "Mudah ramah","Mudah marah"}
            }
        };

        [HttpGet]
        public IEnumerable<Personal> GET()
        {
            return personal;
        }

        [HttpPost]
        public void Post([FromBody] Personal personal1)
        {
            personal.Add(personal1);
        }
    }
}
