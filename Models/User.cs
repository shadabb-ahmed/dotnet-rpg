namespace dotnet_rpg
{
    public class User
    {
        public int Id { get; set;}

        public string Username {get; set;} = string.Empty;

        public byte[] PasswordSalt {get; set;}

        public byte[] PasswordHash {get; set;}

        public List<Character>? Characters {get; set;}
    }
}