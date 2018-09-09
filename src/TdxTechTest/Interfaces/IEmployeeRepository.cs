using System;
using TdxTechTest.Models;

namespace TdxTechTest.Interfaces
{
    public interface IEmployeeRepository
    {
        Result_<string> StoreEmployeeDetails(UploadedFile fileData);

        Result_<string> GetEmployeeDetails();
    }
}
