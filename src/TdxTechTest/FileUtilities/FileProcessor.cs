using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.AspNetCore.Http;
using TdxTechTest.Interfaces;
using TdxTechTest.Models;

namespace TdxTechTest.FileUtilities
{
    public class FileProcessor : IFileParser, IFileValidator
    {
        private readonly IEnumerable<IValidator> _validators;
        private readonly List<string> _errors;

        public FileProcessor(IEnumerable<IValidator> validators)
        {
            _validators = validators;
            _errors = new List<string>();
        }

        public Result_<UploadedFile> ParseFile(IFormFile file)
        {
            var result = string.Empty;
            IEnumerable<FileRow> parsedFile = new List<FileRow>();
            if (file != null)
            {
                using (var reader = new StreamReader(file.OpenReadStream()))
                {
                    var csv = new CsvReader(reader, GetConfiguation());
                    parsedFile = csv.GetRecords<FileRow>();
       
                    var uploadedFile = new UploadedFile();

                    if (parsedFile != null)
                    {
                        uploadedFile.Rows = parsedFile.ToList();
                    }

                    return new Result_<UploadedFile>() { IsSuccess = true, Data = uploadedFile };
                 }
            }

            return new Result_<UploadedFile>() { IsSuccess = false };
        }

        public Result_<List<string>> ValidateFile(UploadedFile file)
        {
            var result = new Result_<List<string>> { IsSuccess = true, Data = new List<string>() };

            foreach (var row in file.Rows)
            {
                foreach (var validator in _validators)
                {
                    validator.ValidateColumn(result, row);
                }
            }

            return result;
        }

        private Configuration GetConfiguation()
        {
            var config = new Configuration();
            config.DetectColumnCountChanges = true;
            config.HasHeaderRecord = false;
            config.BadDataFound = context =>
            {
                _errors.Add(string.Format("Bad data found on row {0}", context.Row));
            };
            config.MissingFieldFound = (headerNames, index, context) =>
            {
                _errors.Add($"Field with names ['{string.Join("', '", headerNames)}'] at index '{index}' was not found.");
            };
            config.ReadingExceptionOccurred = exception =>
            {
                _errors.Add($"Reading exception: {exception.Message}");
            };

            return config;
        }
    }
}
