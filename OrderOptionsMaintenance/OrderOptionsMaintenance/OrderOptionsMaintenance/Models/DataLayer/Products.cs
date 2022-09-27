using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace OrderOptionsMaintenance.Models.DataLayer
{
    public partial class Products
    {
        public Products()
        {
            InvoiceLineItems = new HashSet<InvoiceLineItems>();
        }

        [Key]
        [StringLength(10)]
        public string ProductCode { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }
        public int OnHandQuantity { get; set; }

        [InverseProperty("ProductCodeNavigation")]
        public virtual ICollection<InvoiceLineItems> InvoiceLineItems { get; set; }
    }
}
