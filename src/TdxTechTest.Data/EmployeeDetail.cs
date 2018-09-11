using System;

namespace TdxTechTest.Data
{
    public class EmployeeDetail
    {
        public int EmployeeDetailId { get; set; }
        public DateTime EmploymentDate { get; set; }
        public double HourlyRate { get; set; }
        public int DirectReportsCount { get; set; }

        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}