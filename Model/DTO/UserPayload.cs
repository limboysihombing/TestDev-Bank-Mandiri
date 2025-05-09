namespace Model.DTO
{
    public class UserPayload
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public List<AddressPayload> Addresses { get; set; }
    }
}
