namespace Data.Entities;

public class ProfileEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string ContactEmail { get; set; } = null!;
    public int PhoneNumber { get; set; }

    public int AddressEntityId { get; set; }
    public AddressEntity? Address { get; set; }
}

