using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character{Name = "sam"}
        
        };

        [HttpGet("GetAll")]
        public ActionResult<List<Character>> GetCharacterList() {
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public ActionResult<Character> GetCharacterById(int id) {
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }

        [HttpPost]
        public ActionResult<List<Character>> AddCharacters(Character character) {
            characters.Add(character);
            return Ok(characters);
        }
    }
}