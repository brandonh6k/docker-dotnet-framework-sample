using System;
using System.ComponentModel.DataAnnotations;

namespace myWebApp.Models
{
    public class Student
    {
        public int ID { get; set; }
        
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        
        [Required]
        [StringLength(50)]
        public string FirstMidName { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }
    }
}