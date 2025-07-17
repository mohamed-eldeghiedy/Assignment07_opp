
namespace Assignment07_opp
{
    public interface IAuthenticationService
    {
        bool AuthenticateUser(string username, string password);
        bool AuthorizeUser(string username, string role);
    }


    public class BasicAuthenticationService : IAuthenticationService
    {
       
        private Dictionary<string, (string Password, string Role)> users =
            new Dictionary<string, (string, string)>()
        {
        { "alice", ("password123", "Admin") },
        { "bob", ("securepass", "User") }
        };

        public bool AuthenticateUser(string username, string password)
        {
            if (users.ContainsKey(username) && users[username].Password == password)
            {
                return true;
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            if (users.ContainsKey(username) && users[username].Role == role)
            {
                return true;
            }
            return false;
        }
    }
}
