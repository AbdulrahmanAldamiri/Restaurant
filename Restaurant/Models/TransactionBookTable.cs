using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Restaurant.Models
{
    public partial class TransactionBookTable : BaseEntity
    {
        public int TransactionBookTableId { get; set; }
        [DisplayName("Full Name")]
        [Required]
        public string TransactionBookTableFullName { get; set; }
        [Required]
        [DisplayName("Email")]
        [EmailAddress]
        public string TransactionBookTableEmail { get; set; }
        [DisplayName("Mobile Number")]
        [Required]
        public string TransactionBookTableMobileNumber { get; set; }
        [Required]
        [DisplayName("Reservation Date")]
        public DateTime TransactionBookTableDate { get; set; }
    }
}
