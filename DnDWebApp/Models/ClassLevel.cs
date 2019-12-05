using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DnDWebApp.Models
{
    public class ClassLevel
    {
        public int Id { get; set; }
        [Display(Name = "Class Name")]
        [Required]
        public string ClassName { get; set; }
        [Display(Name = "Hit Dice")]
        [Required]
        public string HitDice { get; set; }
        [Required]
        public int Level { get; set; }
        public string Features { get; set; }
    }
}
