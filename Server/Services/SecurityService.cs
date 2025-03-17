using Dashboard.Shared;

namespace Dashboard.Server.Services
{
    public class SecurityService
    {
        List<User> users = new();

        public User GetUser(Guid id) => users.Where(x => x != null && x.Token == id).FirstOrDefault();

        public UserToken<T> GetToken<T>(User user)
        {
            if(user == null)
                throw new ArgumentNullException(nameof(user));

            if (!users.Contains(user))
                users.Add(user);

            user.AddToken(Guid.NewGuid());
            return new UserToken<T>(user.Token);
        }

        public UserToken<T?>? RequestToken<T>(Guid token, T content)
        {
            var newToken = GetToken<T?>(GetUser(token));
            newToken.Obj = content;
            return newToken;
        }

        public bool Authorized(Guid token)
        {
            var user = GetUser(token);
            return user != null;
        }
    }
}
