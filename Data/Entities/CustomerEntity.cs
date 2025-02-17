

namespace Data.Entities;

public class CustomerEntity
{
    public int Id { get; set; }
    public int ProfileEntityId { get; set; }
    public ProfileEntity Profile { get; set; }

    public ICollection<ProjectEntity> Projects { get; set; }
}
