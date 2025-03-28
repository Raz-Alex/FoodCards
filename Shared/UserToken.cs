namespace FoodCards.Shared
{
    public class UserToken<T>(Guid token)
    {
        public Guid Token { get; } = token;

        public T Obj { get; set; }
    }
}
