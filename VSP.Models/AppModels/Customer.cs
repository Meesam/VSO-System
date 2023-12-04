using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSP.Models.AppModels
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(255)]
        public string? Website { get; set; }

        [Required]
        [MaxLength(255)]
        public string? LogoUrl { get; set; }

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedDate { get; set;}

        public List<Address> AddressList { get; set; } = new List<Address>();

        public List<EmailAddress> EmailAddresses { get; set; } = new List<EmailAddress>();

    }
}
