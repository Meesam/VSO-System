﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSP.Models.AppModels
{
    public class User: DateTimeClass
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Department { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Role { get; set; }

        public List<Project> Projects { get; set; } = new List<Project>();
        public List<ProjectItem> ProjectItems { get; set; } = new List<ProjectItem>();
        public List<EmailAddress> EmailAddresses { get; set; } = new List<EmailAddress>();
        public List<Address> Addresss { get; set; } = new List<Address>();
    }
}
