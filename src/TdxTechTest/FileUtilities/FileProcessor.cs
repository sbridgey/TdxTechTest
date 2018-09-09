using System;
using Microsoft.AspNetCore.Http;
using TdxTechTest.Interfaces;
using TdxTechTest.Models;

namespace TdxTechTest.FileUtilities
{
    public class FileProcessor : IFileParser, IFileValidator
    {
        public Result_<UploadedFile> ParseFile(IFormFile file)
        {
            throw new NotImplementedException();
        }

        public Result_<string> ValidateFile(UploadedFile file)
        {
            throw new NotImplementedException();
        }
    }
}
