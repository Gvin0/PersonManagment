using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Person.Domain.Utilities
{
    public class ValidMinAgeAttribute : ValidationAttribute
    {
        private readonly int _allowedAge;
        public ValidMinAgeAttribute(int allowedAge)
        {
            _allowedAge = allowedAge;
        }
        public override bool IsValid(object value)
        {
            var bday = Convert.ToDateTime(value);
            var ts = DateTime.Today - bday;
            var year = DateTime.MinValue.Add(ts).Year - 1;
            return year >= _allowedAge;
        }
    }
}
