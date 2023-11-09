using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DB_Library
{
    [Table("Bird", Schema ="Person")]
    public class Bird
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string BirdName { get; set; }    
    }
}
