using Microsoft.AspNetCore.Mvc;
using MyPokemon.Fav.Business.Services.Pokes;
using MyPokemon.Fav.Business.Services;


namespace Progra2_Examen1.Controllers;

[ApiController]
[Route("[controller]")]

public class PokemonControllers : Controller
{
    private readonly PokemonServices _services;

    public PokemonControllers (PokemonServices services)
    {
        _services = services;
    }

    [HttpGet("{PokeName}")]

    public async Task<ActionResult<Pokemon>> Get(string PokeName)
    {
        var Poke = await _services.GetPokemonFav(PokeName);
        return Ok(Poke);
    }
}
