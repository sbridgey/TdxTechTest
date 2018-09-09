using Microsoft.AspNetCore.Http;
using TdxTechTest.Models;

namespace TdxTechTest.Interfaces
{
    public interface IFileValidator
    {
        Result_<string> ValidateFile(UploadedFile file);
    }
}
