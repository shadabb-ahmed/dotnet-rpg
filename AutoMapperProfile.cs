namespace dotnet_rpg
{
    public  class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, getCharacterDto>();
        }
    }
}