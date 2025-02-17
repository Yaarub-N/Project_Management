namespace Data.Entities
{
    public class ProjectEntity
    {
        public int ProjectNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal TotalPrice { get; set; }

        public int DateRangeEntityId { get; set; }
        public DateRangeEntity DateRange { get; set; }

        public int CustomerId { get; set; }
        public CustomerEntity Customer { get; set; }

        public int ServiceEntityId { get; set; }
        public ServiceEntity Service { get; set; }

        public int StatusEntityId { get; set; }
        public StatusEntity Status { get; set; }

        public ICollection<ExpenseEntity> Expenses { get; set; }
        public ICollection<TimesheetEntity> Timesheets { get; set; }
    }
}
