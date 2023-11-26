using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisionX.Models
{
    public class ProductWithInvoice
    {
        public Product Product { get; set; }
        public int InvoiceID { get; set; }
    }
}