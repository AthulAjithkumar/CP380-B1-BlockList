
namespace CP380_B1_BlockList.Models
{
    public enum TransactionTypes
    {
        BUY, SELL, GRANT
    }

    public class Payload
    {
        // TODO
        public string User;
        public enum TransactionTypes { }
        public string Item;
        public int Amount;
    }
}
