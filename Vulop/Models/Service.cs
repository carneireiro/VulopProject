using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vulop.Models
{
    public class Service
    {
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Display(Name = "Duração")]
        public TimeSpan Duration { get; set; }
    }
}