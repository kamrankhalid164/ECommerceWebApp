using System;
using System.Collections.Generic;

namespace E_CommerceWebApp.Models
{
    public partial class FourthLevelItem
    {
        public int FourthLevelItemId { get; set; }
        public int FourthLevelItemCode { get; set; }
        public string FourthLevelItemName { get; set; } = string.Empty;
        public int Price { get; set; }
        public int FkcolorId { get; set; }
        public int FksizeId { get; set; }
        public int FkmeasuringUnitId { get; set; }
        public int FkthirdLevelItemId { get; set; }
        public byte[]? Barcode { get; set; }
        public int FkCompanyId { get; set; }
    }
}
