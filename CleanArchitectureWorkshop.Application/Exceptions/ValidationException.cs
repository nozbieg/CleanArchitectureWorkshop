using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWorkshop.Application.Exceptions
{
    public class ValidationException : ApplicationException
    {
        public List<string> ValdiationErrors { get; set; }

        public ValidationException(ValidationResult validationResult)
        {
            ValdiationErrors = new List<string>();
            foreach (var validationError in validationResult.Errors)
            {
                ValdiationErrors.Add(validationError.ErrorMessage);
            }
        }
    }
}
