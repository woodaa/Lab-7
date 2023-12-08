﻿using System;
using System.Collections.Generic;

namespace Bits_Brewery.Models
{
    public partial class InventoryTransaction
    {
        public int InventoryTransactionId { get; set; }
        public int ProductContainerSizeId { get; set; }
        public int BatchId { get; set; }
        public DateTime InventoryTransactionDate { get; set; }
        public int InventoryTransctionTypeId { get; set; }
        public int Quantity { get; set; }
        public int AccountId { get; set; }
        public int AppUserId { get; set; }
        public string? Notes { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual AppUser AppUser { get; set; } = null!;
        public virtual Batch Batch { get; set; } = null!;
        public virtual InventoryTransactionType InventoryTransctionType { get; set; } = null!;
        public virtual ProductContainerSize ProductContainerSize { get; set; } = null!;
    }
}
