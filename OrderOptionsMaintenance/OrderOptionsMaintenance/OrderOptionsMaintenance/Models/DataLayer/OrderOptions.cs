using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace OrderOptionsMaintenance.Models.DataLayer
{
    public partial class OrderOptions
    {
        [Key]
        [Column("OptionID")]
        public int OptionId { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal SalesTaxRate { get; set; }
        [Column(TypeName = "money")]
        public decimal FirstBookShipCharge { get; set; }
        [Column(TypeName = "money")]
        public decimal AdditionalBookShipCharge { get; set; }
    }
}
