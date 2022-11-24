namespace dotnet_rpg.Data
{
    public interface IAuthRepository
    {
         Task<ServiceResponse<int>> Register(User user, string password);

         ServiceResponse<string> Login(string username, string password);

         bool UserExists(string username);
    }
}