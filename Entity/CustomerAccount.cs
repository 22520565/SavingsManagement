namespace Entity
{
    public class CustomerAccount
    {
        public int Id { get; set; } = 0;

        public string Name { get; set; } = string.Empty;

        public bool IsMale { get; set; } = true;

        public string CicNumber { get; set; } = string.Empty;

        public DateOnly BirthDate { get; set; } = new DateOnly();

        public string PhoneNumber { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;

        public string HashedPassword { get; set; } = string.Empty;

        public decimal Balance { get; set; } = 0.0M;
    }
}
