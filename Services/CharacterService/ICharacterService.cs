namespace dotnet_rpg.Services.CharacterService
{
    public interface ICharacterService
    {
         Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
         Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);

        //  Task<ServiceResponse<GetCharacterDto>> UpdateCharacterById(AddCharacterDto updateCharacter);
         Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto character);

    }
}