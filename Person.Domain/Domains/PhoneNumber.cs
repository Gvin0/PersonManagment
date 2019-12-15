using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Person.Domain.Domains
{
    public class PhoneNumber
    {
        [Key]
        public int Id { get; set; }
        public string Number { get; set; }
        public NumberType NumberType { get; set; }

        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }

    public enum NumberType
    {
        Mobile,
        Office,
        Home
    }
}
