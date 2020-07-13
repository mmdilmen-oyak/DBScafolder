using System;
using System.Collections.Generic;

namespace DBScaffolder.Data.Entities
{
    public partial class CodeNEInvoiceLineTax
    {
        public string InvoiceId { get; set; }
        public int? LineId { get; set; }
        public int? TaxId { get; set; }
        public string VergiTuru { get; set; }
        public decimal? Oran { get; set; }
        public decimal? Miktar { get; set; }
    }
}
