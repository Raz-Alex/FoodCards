namespace FoodCards.Shared
{
    public class ServerConfirmation
    {
        public ServerConfirmationStatus Status { get; set; }

        public ServerConfirmation(ServerConfirmationStatus status)
        {
            Status = status;
        }
    }

    public enum ServerConfirmationStatus
    {
        OK,
        Failed
    }
}
