using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClientManagement.Models
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string Address { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        [Required]
        public string City { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        [Required]
        public string State { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        [Required]
        public string PostCode { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        [Required]
        public string Country { get; set; }

    }
}
