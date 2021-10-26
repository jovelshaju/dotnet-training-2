using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PViewExcercise.Models
{
    [Table("Players")]
    public class Player
    {
        [Key]
        public int PId { get; set; }
        public string PName { get; set; }
        public string PType { get; set; }
        public string PCountry { get; set; }
    }
}