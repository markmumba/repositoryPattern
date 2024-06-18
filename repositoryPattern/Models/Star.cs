using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using repositoryPattern.Data;

namespace repositoryPattern.Models
{
    public class Star : IEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string? Name { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string? Surname { get; set; }

        [Required]
        [StringLength(30)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string? Nationality { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        public bool WonOscar { get; set; }
    }
}