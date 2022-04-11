﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pustok.Models
{
    public class Tag
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:255)]
        public string Name { get; set; }
        public List<ProductTag> ProductTags { get; set; }
    }
}
