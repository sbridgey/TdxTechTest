using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TdxTechTest.Data
{
    public class EmployeeDetail
    {
        [ForeignKey("Employee")]
        public Guid EmployeeId { get; set; }
        public DateTime EmploymentDate { get; set; }
        public double PayGrade { get; set; }
        public int DirectReportsCount { get; set; }
    }
}