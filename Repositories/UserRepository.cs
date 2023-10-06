using ApiAuth.Models;

namespace ApiAuth.Repositories
{
    public class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>
            {
                new User {Id = 1, Username = "Murilo", Password = "123", Role = "Gerente"},
                new User {Id = 1, Username = "Fulano", Password = "123", Role = "Estagiario"}
            };

            return users.First(x => x.Username == username && x.Password == password) ;
        }
    }
}
