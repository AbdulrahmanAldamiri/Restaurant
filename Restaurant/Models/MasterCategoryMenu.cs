﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Restaurant.Models
{
    public partial class MasterCategoryMenu : BaseEntity
    {

        public int MasterCategoryMenuId { get; set; }
        public string MasterCategoryMenuName { get; set; }

    }
}
