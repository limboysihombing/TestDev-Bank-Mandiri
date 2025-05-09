namespace Model.Entities
{
    public class AddressEntity
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int CreatedById {get;set;}
        public DateTime CreatedDate { get; set; }

    }
}
