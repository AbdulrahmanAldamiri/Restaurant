using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Restaurant.Models
{
    public partial class SystemSetting : BaseEntity
    {
        public int SystemSettingId { get; set; }
        [DisplayName("Logo Image 1")]
        public string SystemSettingLogoImageUrl { get; set; }
        [DisplayName("Logo Image 2")]
        public string SystemSettingLogoImageUrl2 { get; set; }
        [DisplayName("Copyright")]
        public string SystemSettingCopyright { get; set; }
        [DisplayName("Welcome Note Title")]
        public string SystemSettingWelcomeNoteTitle { get; set; }
        [DisplayName("Welcome Note Breef")]
        public string SystemSettingWelcomeNoteBreef { get; set; }
        [DisplayName("Welcome Note Description")]
        public string SystemSettingWelcomeNoteDesc { get; set; }
        [DisplayName("Welcome Note Url")]
        public string SystemSettingWelcomeNoteUrl { get; set; }
        [DisplayName("Welcome Note Image")]
        public string SystemSettingWelcomeNoteImageUrl { get; set; }
        [DisplayName("Map Location")]
        public string SystemSettingMapLocation { get; set; }

        public string SystemSettingPhoneNumber { get; set; }
        public string SystemSettingEmail { get; set; }
    }
}
