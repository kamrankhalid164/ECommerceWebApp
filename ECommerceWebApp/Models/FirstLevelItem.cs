using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_CommerceWebApp.Models
{
    public partial class FirstLevelItem
    {
        public int FirstLevelItemId { get; set; }
        public int FirstLevelItemCode { get; set; }
        [Required]
        public string FirstLevelItemName { get; set; } = string.Empty;
        public int FkCompanyId { get; set; }
        public string? CompanyName { get; set; } = string.Empty;

    }
}
