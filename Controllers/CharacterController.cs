using Microsoft.AspNetCore.Mvc;
using dotnet_rpg.Services.CharacterService;
namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterService){
            _characterService = characterService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> GetCharacterList() {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Character>>> GetCharacterById(int id) {
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> AddCharacters(Character character) {
            return Ok(await _characterService.AddCharacter(character));
        }
    }
}