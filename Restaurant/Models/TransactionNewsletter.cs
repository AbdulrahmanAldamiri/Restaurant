using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Restaurant.Models
{
    public partial class TransactionNewsletter : BaseEntity
    {
        public int TransactionNewsletterId { get; set; }
        [DisplayName("Email")]
        [Required]
        [EmailAddress]
        public string TransactionNewsletterEmail { get; set; }
    }
}
