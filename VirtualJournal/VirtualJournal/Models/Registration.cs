using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualJournal.Models
{
    public class Registration
    {
        [Key]
        public int id { get; set; }
        [StringLength(15)] // university of colorado bowlder.
        public string FirstName { get; set; }
        [StringLength(15)]
        [Column(TypeName = "text")]
        public string LastName { get; set; }
        [StringLength(20)]
        [Column(TypeName = "text")]
        public string UserName { get; set; }
        [StringLength(16)]
        [Column(TypeName = "text")]
        public string Password { get; set; }
        [StringLength(10)]
        [Column(TypeName = "text")]
        public string PhoneNumber { get; set; }
        [Column(TypeName = "text")]
        public string Email { get; set; }
    }
}
