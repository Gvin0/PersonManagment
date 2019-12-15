using Person.Domain.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Person.Domain.Domains
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^([ა-ჰ\s]+|[A-Za-z\s]+)$", ErrorMessage = "Please dont mix languages")]
        public string FirstName { get; set; }

        [StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^([ა-ჰ\s]+|[A-Za-z\s]+)$", ErrorMessage = "Please dont mix languages")]
        public string LastName { get; set; }
        public Gender? Gender { get; set; }

        //[MaxLength(11), MinLength(11)]
        [StringLength(11, MinimumLength = 11)]
        public string PrivateNumber { get; set; }

        [DataType(DataType.Date)]
        [ValidMinAge(allowedAge: 18, ErrorMessage = "Min 18 Year Bro")]
        public DateTime BirthDate { get; set; }
        public string City { get; set; }
        public string PhotoPath { get; set; }
        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }

        public virtual ICollection<Relation> RelatedTo { get; set; }
        public virtual ICollection<Relation> RelatedFrom { get; set; }
    }

    public enum Gender
    {
        Female,
        Male
    }
}
