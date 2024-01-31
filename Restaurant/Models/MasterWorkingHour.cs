using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Restaurant.Models
{
    public partial class MasterWorkingHour : BaseEntity
    {
        public int MasterWorkingHourId { get; set; }
        [DisplayName("Working Hours Day")]
        public string MasterWorkingHourIdName { get; set; }
        [DisplayName("Working Hours Time")]
        public string MasterWorkingHourIdTimeFormTo { get; set; }
    }
}
