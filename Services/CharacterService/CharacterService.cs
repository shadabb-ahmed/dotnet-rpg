using System.Threading.Tasks;
using System.Collections.Generic;
using AutoMapper;
namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
         private static List<Character> characters = new List<Character>{
            new Character(),
            new Character{Id=1, Name = "sam"}
        
        };
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        public CharacterService(IMapper mapper, DataContext context){
	        _mapper = mapper;
            _context = context;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters(){
            var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            var dbCharacters = _context.Characters.ToList();
            serviceResponse.Data = dbCharacters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
            return serviceResponse;
        }
         public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id){
            var serviceResponse = new ServiceResponse<GetCharacterDto>();
             var dbCharacater = _context.Characters.FirstOrDefault(c => c.Id == id);
            serviceResponse.Data = _mapper.Map<GetCharacterDto>(dbCharacater);
            return serviceResponse;
         }
        //  public async Task<ServiceResponse<GetCharacterDto>> UpdateCharacterById(AddCharacterDto updateCharacter){
        //     var serviceResponse = new ServiceResponse<GetCharacterDto>();
        //     var dbCharacater = _context.Characters.FirstOrDefault(c => c.Id == updateCharacter.);
        //     serviceResponse.Data = _mapper.Map<GetCharacterDto>(dbCharacater);
        //     return serviceResponse;
        // }
         public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto character){
            var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            Character character1 = _mapper.Map<Character>(character);
            _context.Characters.Add(character1);
            await _context.SaveChangesAsync();
            serviceResponse.Data = _context.Characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
            return serviceResponse;            
         }

    }
}