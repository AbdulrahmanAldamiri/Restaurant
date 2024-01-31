using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace Restaurant.Models
{
    public partial class MasterItemMenu : BaseEntity
    {
        public int MasterItemMenuId { get; set; }
        [DisplayName("MasterCategoryMenu Item")]
        public int MasterCategoryMenuId { get; set; }
        [DisplayName("Menu Title")]
        public string MasterItemMenuTitle { get; set; }
        [DisplayName("Menu Breef")]

        public string MasterItemMenuBreef { get; set; }
        [DisplayName("Menu Description")]

        public string MasterItemMenuDesc { get; set; }
        [DisplayName("Price")]

        public decimal? MasterItemMenuPrice { get; set; }
        [DisplayName("Menu Image")]

        public string MasterItemMenuImageUrl { get; set; }
        [DisplayName("Menu Date")]

        public DateTime? MasterItemMenuDate { get; set; }
        [DisplayName("CategoryMenuId")]
        public virtual MasterCategoryMenu MasterCategoryMenu { get; set; }
    }
}
