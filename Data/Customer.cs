namespace StateOfIdaho.UI.Data
{
    public class Customer
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? BillingAddress1 { get; set; }
        public string? BillingAddress2 { get; set; }
        public string? Email { get; set; }
        public string? City{ get; set; }
        public string? State { get; set; }
        public int Zip { get; set; }
    }
}
