﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSP.Models.AppModels
{
    public class Project: DateTimeClass
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }

        public string? Description { get; set; }

        [Required]
        [MaxLength(100)]
        public string? ProjectType { get; set;}

        [Required]
       [MaxLength(100)]
        public string? ProjectStatus { get; set; }

       [Required]
        public DateTime ProjectStartDate { get; set; }

        public DateTime? ProjectEndDate { get; set; }

        public List<ProjectItem> ProjectItems { get; set;} = new List<ProjectItem>();

    }
}
