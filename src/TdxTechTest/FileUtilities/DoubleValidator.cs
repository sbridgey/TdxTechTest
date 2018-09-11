using System;
using System.Collections.Generic;
using TdxTechTest.Interfaces;
using TdxTechTest.Models;

namespace TdxTechTest.FileUtilities
{
    public class DoubleValidator : BaseValidator, IValidator
    {
        readonly List<double> _validPayGrades = new List<double>() { 1.0, 1.1, 1.2, 1.3, 2.0, 2.1, 2.2, 2.3, 3.0, 3.1, 3.2, 3.3 };

        public void ValidateColumn(Result_<List<string>> result, FileRow row)
        {
            if (!_validPayGrades.Contains(row.PayGrade))
            {
                AddError(result, "Invalid Paygrade");
            }
        }
    }
}
