using Person.Domain.Domains;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Person.Domain.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Person.WebClient.ViewModels
{
    public class PersonCreateViewModel
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^([ა-ჰ\s]+|[A-Za-z\s]+)$", ErrorMessage = "Please dont mix languages")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^([ა-ჰ\s]+|[A-Za-z\s]+)$", ErrorMessage = "Please dont mix languages")]
        public string LastName { get; set; }
        public Gender? Gender { get; set; }

        [Required]
        [StringLength(11, MinimumLength = 11)]

        //[Remote(action: "IsPrivateNumberInUse", controller: "Person")]
        public string PrivateNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [ValidMinAge(allowedAge: 18, ErrorMessage = "Min 18 Years Bro")]
        public DateTime BirthDate { get; set; }
        public string City { get; set; }
        public IFormFile Photo { get; set; }
        public virtual PhoneNumberViewModel[] PhoneNumbers { get; set; }
        //[BindProperty]
        public virtual RelationViewModel[] Relations { get; set; }
    }

    public class RelationViewModel
    {
        public string Value { get; set; }
        public RelationType RelationType { get; set; }
    }

    public class PhoneNumberViewModel
    {
        public string Number { get; set; }
        public NumberType NumberType { get; set; }
    }
}
