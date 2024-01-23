using MagicAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MagicAPI.Controllers
{
    [Route("api/MagicVilla")]
    [ApiController]
    public class MagicVilla_ApiController : ControllerBase
    {
        public IEnumerable<Villa> GetVillas()
        {
            return new List<Villa> {
                new Villa { Id=1, Name="Pool View"},
                new Villa { Id=2, Name="Beach View"}

            };
        }
    }
}
