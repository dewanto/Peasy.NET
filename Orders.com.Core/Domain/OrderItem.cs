﻿using Facile;
using Facile.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.com.Core.Domain
{
    public class OrderItem : DomainBase
    {
        public long OrderItemID { get; set; }

        [FacileForeignKey, FacileRequired]
        public long OrderID { get; set; }

        [FacileForeignKey, FacileRequired]
        public long ProductID { get; set; }

        [Required]
        public decimal? Quantity { get; set; }

        //[Editable(false)] -> TODO: create a rule that looks up current price for product id and ensure that totals match to avoid price changes or amount hijacking
        public decimal Amount { get; set; }

        public override long ID
        {
            get { return OrderItemID; }
            set { OrderItemID = value; }
        }
    }
}