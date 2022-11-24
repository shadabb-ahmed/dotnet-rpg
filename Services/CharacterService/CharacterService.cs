namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
         private static List<Character> characters = new List<Character>{
            new Character(),
            new Character{Name = "sam"}
        
        };

        public async Task<ServiceResponse<List<Character>>> GetAllCharacters(){
            var serviceResponse = new ServiceResponse<List<Character>>();
            serviceResponse.Data = characters;
            return serviceResponse;
        }
         public async Task<ServiceResponse<Character>> GetCharacterById(int id){
            var serviceResponse = new ServiceResponse<Character>();
            serviceResponse.Data = characters.FirstOrDefault(c => c.Id == id);
            return serviceResponse;
         }
         public async Task<ServiceResponse<List<Character>>> AddCharacter(Character character){
            characters.Add(character);
            var serviceResponse = new ServiceResponse<List<Character>>();
            serviceResponse.Data = characters;
            return serviceResponse;            
         }
    }
}