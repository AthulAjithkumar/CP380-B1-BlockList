
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
        
        public Payload(string user, TransactionTypes transactionType, int amount, string item)
        {
            User = user;
            TransactionType = transactionType;
            Amount = amount;
            Item = item;
        }
    }
}
