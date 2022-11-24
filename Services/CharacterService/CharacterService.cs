namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
         private static List<Character> characters = new List<Character>{
            new Character(),
            new Character{Name = "sam"}
        
        };

        public async Task<List<Character>> GetAllCharacters(){
            return characters;
        }
         public async Task<Character> GetCharacterById(int id){
            return characters.FirstOrDefault(c => c.Id == id);
         }
         public async Task<List<Character>> AddCharacter(Character character){
            characters.Add(character);
            return characters;
         }
    }
}