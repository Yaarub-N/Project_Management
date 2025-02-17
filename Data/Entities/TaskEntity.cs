namespace Data.Entities
{
    public class TaskEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public int ProjectEntityId { get; set; }
        public ProjectEntity Project { get; set; }
    }
}
