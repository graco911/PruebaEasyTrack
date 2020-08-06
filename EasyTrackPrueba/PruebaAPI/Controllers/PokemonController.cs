using PokemonAPI.Models;
using PokemonAPI.Repositories;
using System.Threading.Tasks;
using System.Web.Http;

namespace PruebaAPI.Controllers
{
    public class PokemonController : ApiController
    {
        UnitOfWork unitOfWork = new UnitOfWork();

        // GET: api/Pokemon/5
        [HttpGet]
        public async Task<PokeTypeData> Get(string id)
        {
            return await unitOfWork.PokemonRepo.GetPokemonByName(id);
        }
    }
}
