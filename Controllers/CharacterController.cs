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
        public ActionResult<List<Character>> GetCharacterList() {
            return Ok(_characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public ActionResult<Character> GetCharacterById(int id) {
            return Ok(_characterService.GetCharacterById(id));
        }

        [HttpPost]
        public ActionResult<List<Character>> AddCharacters(Character character) {
            return Ok(_characterService.AddCharacter(character));
        }
    }
}