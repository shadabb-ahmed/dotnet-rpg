namespace dotnet_rpg.Data
{
    public interface IAuthRepository
    {
         Task<ServiceResponse<int>> Register(User user, string password);

         Task<ServiceResponse<string>> Login(string username, string password);

         bool UserExists(string username);
    }
}