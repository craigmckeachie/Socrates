using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Socrates.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"[A-Z]+-\d+", ErrorMessage = "Must be in the format AAA-123")]
        public string Number { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public float Duration { get; set; }
        public string Description { get; set; }
        
        [Required]
        [Display(Name="Available")]
        [DisplayFormat(DataFormatString ="{0:d}", ApplyFormatInEditMode =true)]
        public DateTime AvailabilityDate { get; set; }
        public bool IsActive { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }
    }
}