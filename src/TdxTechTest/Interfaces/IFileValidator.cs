using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using TdxTechTest.Models;

namespace TdxTechTest.Interfaces
{
    public interface IFileValidator
    {
        Result_<List<string>> ValidateFile(UploadedFile file);
    }
}
