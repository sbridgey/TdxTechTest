using System;
using System.ComponentModel.DataAnnotations;

namespace TdxTechTest.Data
{
    public class Employee
    {
        [Key]
        public Guid EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
    }
}
