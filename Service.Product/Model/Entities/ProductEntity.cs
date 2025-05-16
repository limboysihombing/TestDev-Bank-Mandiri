namespace Model.Entities
{
    public class ProductEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Stock { get; set; }
        public DateTime CreatedDate { get; set; }

        // Joined with Category
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
    }
}
