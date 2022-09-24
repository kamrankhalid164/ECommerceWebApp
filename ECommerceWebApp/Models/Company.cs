using System;
using System.Collections.Generic;

namespace E_CommerceWebApp.Models
{
    public partial class Company
    {
        public int CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? WarehouseAddress { get; set; }
        public string? ReturnAddress { get; set; }
        public string? Ntn { get; set; }
    }
}
