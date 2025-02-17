﻿namespace ModelEF.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int ID { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [Display(Name = "Đơn giá")]
        [DisplayFormat(DataFormatString = "{0:0,0} Đ")]
        public decimal? UnitCost { get; set; }

        public int? Quantity { get; set; }

        [StringLength(250)]
        public string Image { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public bool? Status { get; set; }

        public int? IDCategory { get; set; }

        public virtual Category Category { get; set; }
    }
}
