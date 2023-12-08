﻿using System;
using System.Collections.Generic;

namespace Bits_Brewery.Models
{
    public partial class RecipeIngredient
    {
        public int RecipeIngredientId { get; set; }
        public int RecipeId { get; set; }
        public int IngredientId { get; set; }
        public double Quantity { get; set; }
        public double? Time { get; set; }
        public int? UseDuringId { get; set; }

        public virtual Ingredient Ingredient { get; set; } = null!;
        public virtual Recipe Recipe { get; set; } = null!;
        public virtual UseDuring? UseDuring { get; set; }
    }
}
