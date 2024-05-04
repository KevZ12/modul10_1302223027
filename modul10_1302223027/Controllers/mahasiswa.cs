using Microsoft.AspNetCore.Mvc;
using System.Data.SqlTypes;
namespace modul10_1302223027.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class mahasiswa : ControllerBase
    {
        public static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("kevin Albany Junaidi","1302223027",["Object Oriented Programming","user experience"],2022),
             new Mahasiswa("Rindang Bani","1302223023",["Databae","ui/ux"],2022),
             new Mahasiswa("Adrian Fahren","1302220018",["Web Programming","AI"],2022)
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        { 
            return dataMahasiswa;
        }
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody]Mahasiswa mahasiswa) { 
            dataMahasiswa.Add(mahasiswa);
        }
        [HttpDelete("{id}")] 
        public void Delete(int id) {
            dataMahasiswa.RemoveAt(id);
        }

    }
}
