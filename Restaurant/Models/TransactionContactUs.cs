using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Restaurant.Models
{
    public partial class TransactionContactUs : BaseEntity
    {
        public int TransactionContactUsId { get; set; }
        [DisplayName("Full Name")]
        [Required]
        public string TransactionContactUsFullName { get; set; }
        [Required]
        [DisplayName("Email")]
        public string TransactionContactUsEmail { get; set; }
        [Required]
        [DisplayName("Subject")]
        public string TransactionContactUsSubject { get; set; }
        [Required]
        [DisplayName("Message")]
        public string TransactionContactUsMessage { get; set; }
    }
}
