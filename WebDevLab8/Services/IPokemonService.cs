using System.Collections.Generic;
using WebDevLab8.Models.View;

namespace WebDevLab8.Services
{
    public interface IPokemonService
    {
        PokemonViewModel GetPokemon(int id);

        IEnumerable<PokemonViewModel> GetPokemonsForUser(string userId);

        void SavePokemon(string userId, PokemonViewModel pokemon);

        void UpdatePokemon(PokemonViewModel user);

        void DeletePokemon(int id);
    }
}
