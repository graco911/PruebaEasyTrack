using PokemonAPI.Models;
using Refit;
using System.Threading.Tasks;

namespace PokemonAPI.Interface
{
    public interface IPokemon
    {
        [Get("/v2/pokemon/{name}")]
        Task<PokeTypeData> GetPokemonByName(string name);
    }
}
