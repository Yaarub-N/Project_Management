using System.Collections.Generic;

namespace Data.Entities
{
    public class ServiceEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal HourlyRate { get; set; }
        public ICollection<ProjectEntity> Projects { get; set; }
    }
}
