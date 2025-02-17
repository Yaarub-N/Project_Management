namespace Data.Entities
{
    public class ProfileEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactEmail { get; set; }
        public string PhoneNumber { get; set; }
        public string CompanyNumber { get; set; }

        public int AddressEntityId { get; set; }
        public AddressEntity Address { get; set; }
    }
}
