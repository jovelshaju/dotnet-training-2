
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExcerciseFilter.Models
{
    public class EmpAuth
    {
        [Required]
        [Display(Name = "UserName")]

        public string UserName { get; set; }
        [Required]
        [Display(Name = "UserPwd")]
        [DataType(DataType.Password)]
        public string UserPwd { get; set; }
        public int Id { get; set; }
    }
}