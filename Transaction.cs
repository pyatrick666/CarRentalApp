namespace CarRentalApp.API.Models {
    public class Transaction {
        public int TransactionId { get; set; }
        public int PaymentId { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public string TransactionType { get; set; }
        public string TransactionStatus { get; set; }
        public string GatewayResponse { get; set; }
        public DateTime CreatedAt { get; set; }
        public Payment Payment { get; set; }
        public User User { get; set; }
    }
}