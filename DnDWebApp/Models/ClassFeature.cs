using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DnDWebApp.Models
{
    public class ClassFeature
    {
        public int Id { get; set; }
        [Display(Name = "Feature Name")]
        [Required]
        public string FeatureName { get; set; }
        [Display(Name = "Feature Description")]
        [Required]
        public string FeatureDescription { get; set; }
        public bool Active { get; set; }
        public bool Combat { get; set; }
    }
}
