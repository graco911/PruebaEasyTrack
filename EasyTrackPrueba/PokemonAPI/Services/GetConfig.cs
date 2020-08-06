using PokemonAPI.Interface;
using Refit;

namespace PokemonAPI.Services
{
    public static class GetConfig
    {
        public static IPokemon GetPokemonApi()
        {
            return RestService.For<IPokemon>("https://pokeapi.co/api");
        }
    }
}
