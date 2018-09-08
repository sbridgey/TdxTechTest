using System;
using Microsoft.AspNetCore.Http;
using TdxTechTest.Models;

namespace TdxTechTest.Interfaces
{
    public interface IFileParser
    {
        FileValidationResult ValidateFile(IFormFile file);
        UploadedFile ParseFile();
    }
}
