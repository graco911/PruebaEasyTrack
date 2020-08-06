using PokemonAPI.Interface;
using PokemonAPI.Models;
using System.Threading.Tasks;

namespace PokemonAPI.Repositories
{
    public class PokemonRepository
    {
        private readonly IPokemon _context;

        public PokemonRepository(IPokemon context)
        {
            _context = context;
        }

        public async Task<PokeTypeData> GetPokemonByName(string name)
        {
            return await _context.GetPokemonByName(name);
        }
    }
}
