using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ODataExcercise.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int SId { get; set; }
        public string SName { get; set; }
        public string SPassword { get; set; }
        public double SFee { get; set; }

    }
}