using System;
using System.Collections.Generic;

namespace E_CommerceWebApp.Models
{
    public partial class SecondLevelItem
    {
        public int SecondLevelItemId { get; set; }
        public int SecondLevelItemCode { get; set; }
        public string SecondLevelItemName { get; set; } = string.Empty;
        public int FkFirstLevelItemId { get; set; }
        public int FkcompanyId { get; set; }
    }
}
