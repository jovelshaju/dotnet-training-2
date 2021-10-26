using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MovieExcercise.Models
{
    [Table("Movies")]
    public class Movie
    {
        [Key]
        public int MId { get; set; }
        public string MName { get; set; }
        public string StarCast { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}