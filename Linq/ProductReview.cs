﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Linq
{
    public class ProductReview
    {
        internal bool IsLike;

        public int ProductId { get; set; }
        public int UserId { get; set; }
        public double Rating { get; set; }
        public string Review { get; set; }
        public bool isLike { get; set; }
    }
}
