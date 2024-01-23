using MagicAPI.Models;
using MagicAPI.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace MagicAPI.Controllers
{
    [Route("api/MagicVilla")]
    [ApiController]
    public class MagicVilla_ApiController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return new List<VillaDTO> {
                new VillaDTO { Id=1, Name="Pool View"},
                new VillaDTO { Id=2, Name="Beach View"}

            };
        }

     
    }
}
