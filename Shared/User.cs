namespace FoodCards.Shared
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ViewRights { get; set; }
        public Guid Token { get; private set; }

        DateTime tokenChanged;

        public void AddToken(Guid id)
        {
            var lastTokenChanged = tokenChanged;
            tokenChanged = DateTime.Now;

            if (Token != Guid.Empty && DateTime.Now.Subtract(lastTokenChanged).Minutes < 30)
                return;

            Token = id;
        }

        public List<string> ViewRightsId()
        {
            return string.IsNullOrEmpty(ViewRights) ? new() : ViewRights.Split(';').ToList();
        }
    }
}
