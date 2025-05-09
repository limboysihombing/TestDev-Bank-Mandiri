namespace Model.DTO
{
    public class UserResponse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public DateTime CreatedAt { get; set; }

        public List<AddressResponse> Addresses { get; set; }
    }
}
