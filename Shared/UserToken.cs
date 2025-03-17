namespace FoodCards.Shared
{
    public class UserToken<T>
    {
        public Guid Token { get; }

        public T Obj { get; set; }

        public UserToken(Guid token)
        {
            Token = token;
        }
    }
}
