namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
         private static List<Character> characters = new List<Character>{
            new Character(),
            new Character{Name = "sam"}
        
        };

        public List<Character> GetAllCharacters(){
            return characters;
        }
         public Character GetCharacterById(int id){
            return characters.FirstOrDefault(c => c.Id == id);
         }
         public List<Character> AddCharacter(Character character){
            characters.Add(character);
            return characters;
         }
    }
}