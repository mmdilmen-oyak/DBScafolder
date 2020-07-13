using System;
using System.Collections.Generic;

namespace DBScaffolder.Data.Entities
{
    public partial class CodeNEInvoiceLine
    {
        public string InvoiceId { get; set; }
        public int? LineId { get; set; }
        public string MalzemeAdi { get; set; }
        public decimal? Miktar { get; set; }
        public decimal? BirimFiyat { get; set; }
        public string Birim { get; set; }
        public decimal? IskontoOrani { get; set; }
        public decimal? IskontoTutari { get; set; }
        public decimal? MalzemeTutari { get; set; }
        public decimal? KdvOrani { get; set; }
        public decimal? KdvTutari { get; set; }
        public bool? KdvMuafiyetVarmi { get; set; }
        public string MuafiyetSebebi { get; set; }
    }
}
