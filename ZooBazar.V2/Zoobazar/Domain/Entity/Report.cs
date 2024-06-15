using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Report
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ReportCategory Category { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public Employee CreatedBy { get; set; }

        public Report(string title, ReportCategory category, string description, Employee createdBy)
        {
            Title = title;
            Category = category;
            Description = description;
            DateCreated = DateTime.Now;
            CreatedBy = createdBy;
        }
    }
}
