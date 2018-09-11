using System;
using System.Collections.Generic;
using TdxTechTest.Interfaces;
using TdxTechTest.Models;

namespace TdxTechTest.FileUtilities
{
    public class StringValidator : BaseValidator, IValidator
    {
        public void ValidateColumn(Result_<List<string>> result, FileRow row)
        {
            if (string.IsNullOrWhiteSpace(row.FirstName))
            {
                AddError(result, "FirstName is empty");
            }

            if (row.FirstName.Length > 20)
            {
                AddError(result, "FirstName is too long");
            }

            if (string.IsNullOrWhiteSpace(row.Surname))
            {
                AddError(result, "Surname is empty");
            }

            if (row.Surname.Length > 20)
            {
                AddError(result, "Surname is too long");
            }
        }
    }
}
