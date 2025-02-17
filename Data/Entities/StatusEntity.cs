using System.Collections.Generic;

namespace Data.Entities
{
    public class StatusEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } // Ex: Ej påbörjad, Pågående, Avslutad
        public ICollection<ProjectEntity> Projects { get; set; }
    }
}
