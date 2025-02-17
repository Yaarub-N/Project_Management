

namespace Data.Entities;

public class EmployeeEntity
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }

    public int RoleEntityId { get; set; }
    public RoleEntity? Role { get; set; }

    public ICollection<TimesheetEntity>? Timesheets { get; set; }
}
