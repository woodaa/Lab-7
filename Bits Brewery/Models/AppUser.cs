﻿using System;
using System.Collections.Generic;

namespace Bits_Brewery.Models
{
    public partial class AppUser
    {
        public AppUser()
        {
            InventoryTransactions = new HashSet<InventoryTransaction>();
        }

        public int AppUserId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<InventoryTransaction> InventoryTransactions { get; set; }
    }
}
