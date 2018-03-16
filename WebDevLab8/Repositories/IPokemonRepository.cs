using System.Collections.Generic;
using WebDevLab8.Data.Entities;

namespace WebDevLab8.Repositories
{
    public interface IPokemonRepository
    {
        Pokemon GetPokemon(int id);

        IEnumerable<Pokemon> GetPokemonsForUser(string userId);

        void SavePokemon(Pokemon pokemon);

        void UpdatePokemon(Pokemon user);

        void DeletePokemon(int id);
    }
}
