using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatPhatAcc.Models
{
    public record InventoryItemSummary2: InventoryItemSummary
    {
        public decimal UnitRetailPrice { get; set; } = 0;
    }
}
