using System;
using System.Collections.Generic;
using TdxTechTest.Interfaces;
using TdxTechTest.Models;

namespace TdxTechTest.FileUtilities
{
    public class IntValidator : BaseValidator, IValidator
    {

        public void ValidateColumn(Result_<List<string>> result, FileRow row)
        {
            if (row.DirectReportsCount > 50)
            {
                AddError(result, "Too many direct reports");
            }
        }
    }
}
