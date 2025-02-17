namespace Data.Entities
{
    public class AddressEntity
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int LocationEntityId { get; set; }
        public LocationEntity Location { get; set; }
    }
}
