using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using Microsoft.AspNetCore.Http;
using TdxTechTest.Interfaces;
using TdxTechTest.Models;

namespace TdxTechTest.FileUtilities
{
    public class FileProcessor : IFileParser, IFileValidator
    {
        private readonly IEnumerable<IValidator> _validators;

        public FileProcessor(IEnumerable<IValidator> validators)
        {
            _validators = validators;
        }

        public Result_<UploadedFile> ParseFile(IFormFile file)
        {
            var result = string.Empty;
            IEnumerable<FileRow> parsedFile = new List<FileRow>;
            if (file != null)
            {
                using (var reader = new StreamReader(file.OpenReadStream()))
                {
                    var csv = new CsvReader(reader);
                    parsedFile = csv.GetRecords<FileRow>();
                }
            }

            var uploadedFile = new UploadedFile();
            if(parsedFile != null)
            {
                uploadedFile.Rows = parsedFile.ToList();
            }

            return new Result_<UploadedFile>() { IsSuccess = true, Data = uploadedFile };
        }

        public Result_<List<string>> ValidateFile(UploadedFile file)
        {
            var result = new Result_<List<string>> { IsSuccess = true, Data = new List<string> };

            foreach (var row in file.Row)
            {
                foreach(var validator in _validators)
                {
                    validator.ValidateColumn(result, row);
                }
            }

            return result;
        }
    }
}
