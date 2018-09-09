using System;
using Microsoft.AspNetCore.Http;
using TdxTechTest.Models;

namespace TdxTechTest.Interfaces
{
    public interface IFileParser
    {
        Result_<UploadedFile> ParseFile(IFormFile file);
    }
}
