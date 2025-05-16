namespace Model.DTO
{
    public class ProductPayload
    {
        public string Name { get; set; } = string.Empty;
        public int Stock { get; set; }
        public int CategoryId { get; set; }
    }
}
