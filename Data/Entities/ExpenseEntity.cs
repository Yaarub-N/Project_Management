using System;

namespace Data.Entities
{
    public class ExpenseEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        public int ProjectEntityId { get; set; }
        public ProjectEntity Project { get; set; }
    }
}
