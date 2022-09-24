using System;
using System.Collections.Generic;

namespace E_CommerceWebApp.Models
{
    public partial class ThirdLevelItem
    {
        public int ThirdLevelItemId { get; set; }
        public int ThirdLevelItemCode { get; set; }
        public string ThirdLevelItemName { get; set; } = string.Empty;  
        public int FksecondLevelItemId { get; set; }
        public int FkCompanyId { get; set; }

    }
}
