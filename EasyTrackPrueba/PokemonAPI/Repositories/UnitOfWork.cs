using PokemonAPI.Services;

namespace PokemonAPI.Repositories
{
    public class UnitOfWork
    {
        public PokemonRepository PokemonRepo
        {
            get
            {
                return new PokemonRepository(GetConfig.GetPokemonApi());
            }
        }
    }
}
