namespace WebApplication.DTOs
{
    public class CreateUserDTO
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public string? ContactName { get; set; }
    }
}
