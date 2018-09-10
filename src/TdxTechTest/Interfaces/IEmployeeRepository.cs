using System;
using System.Collections.Generic;
using TdxTechTest.Models;

namespace TdxTechTest.Interfaces
{
    public interface IEmployeeRepository
    {
        Result_<string> StoreEmployeeDetails(UploadedFile fileData);

        Result_<List<EmployeeData>> GetAllEmployeeDetails();
    }
}
