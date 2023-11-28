using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VisionX.Models
{
    public class ServiceWithInvoice
    {
        public Service Service { get; set; }
        public int InvoiceID { get; set; }
    }
}