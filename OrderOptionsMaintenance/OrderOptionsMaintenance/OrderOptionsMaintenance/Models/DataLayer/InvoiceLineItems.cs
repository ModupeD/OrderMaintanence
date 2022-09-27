using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace OrderOptionsMaintenance.Models.DataLayer
{
    public partial class InvoiceLineItems
    {
        [Key]
        [Column("InvoiceID")]
        public int InvoiceId { get; set; }
        [Key]
        [StringLength(10)]
        public string ProductCode { get; set; }
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "money")]
        public decimal ItemTotal { get; set; }

        [ForeignKey(nameof(InvoiceId))]
        [InverseProperty(nameof(Invoices.InvoiceLineItems))]
        public virtual Invoices Invoice { get; set; }
        [ForeignKey(nameof(ProductCode))]
        [InverseProperty(nameof(Products.InvoiceLineItems))]
        public virtual Products ProductCodeNavigation { get; set; }
    }
}
