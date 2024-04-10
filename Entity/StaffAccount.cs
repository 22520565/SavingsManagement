namespace Entity
{
    public class StaffAccount
    {
        public int Id { get; set; } = 0;

        public string Name { get; set; } = string.Empty;

        public bool IsMale { get; set; } = true;

        public string Position { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;

        public string HashedPassword { get; set; } = string.Empty;

        public int StaffAccountTypeId { get; set; } = 0;
    }
}
