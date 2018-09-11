using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TdxTechTest.Interfaces;
using TdxTechTest.Models;

namespace TdxTechTest.Pages
{
    public class EmployeeDataModel : PageModel
    {
        readonly IEmployeeRepository _employeeRepository;

        public List<EmployeeData> EmployeeData { get; set; }

        public EmployeeDataModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public void OnGet()
        {
            EmployeeData = _employeeRepository.GetAllEmployeeDetails().Data;
        }
    }
}
