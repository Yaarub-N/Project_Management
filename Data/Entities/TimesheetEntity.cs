using System;

namespace Data.Entities
{
    public class TimesheetEntity
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Hours { get; set; }

        public int EmployeeEntityId { get; set; }
        public EmployeeEntity Employee { get; set; }

        public int ProjectEntityId { get; set; }
        public ProjectEntity Project { get; set; }
    }
}
