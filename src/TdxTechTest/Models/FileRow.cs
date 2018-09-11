using System;
namespace TdxTechTest.Models
{
    public class FileRow
    {
        
        public Guid EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public DateTime EmploymentDate { get; set; }
        public double HourlyRate { get; set; }
        public int DirectReportsCount { get; set; }
    }
}
