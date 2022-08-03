namespace Net6
{
    public class Customer
    {
        public int Id { get; init; }
        public string Email { get; init; } = default!;
        public string FullName { get; init; } = default!;
        public DateTime DateOfBirth { get; init; }
    }
}