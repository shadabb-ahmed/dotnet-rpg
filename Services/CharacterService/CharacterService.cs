namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
         private static List<Character> characters = new List<Character>{
            new Character(),
            new Character{Name = "sam"}
        
        };
        private readonly IMapper _mapper;
        public CharacterService(IMapper mapper){
	        _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters(){
            var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            serviceResponse.Data = characters;
            return serviceResponse;
        }
         public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id){
            var serviceResponse = new ServiceResponse<GetCharacterDto>();
             var character = characters.FirstOrDefault(c => c.Id == id);
            serviceResponse.Data = _mapper.Map<GetCharacterDto>(character);
            return serviceResponse;
         }
         public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto character){
            characters.Add(_mapper.Map<Character>(character));
            var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            serviceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
            return serviceResponse;            
         }
    }
}