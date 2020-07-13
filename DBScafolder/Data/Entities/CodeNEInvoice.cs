using System;
using System.Collections.Generic;

namespace DBScaffolder.Data.Entities
{
    public partial class CodeNEInvoice
    {
        public string FaturaNo { get; set; }
        public string FaturaninEvrenselTekilNumarasi { get; set; }
        public bool? CevapVerildimi { get; set; }
        public DateTime? GelisZamani { get; set; }
        public string Senaryo { get; set; }
        public string FaturaTarihi { get; set; }
        public string FaturaTipi { get; set; }
        public string ParaBirimi { get; set; }
        public string SiparisNo { get; set; }
        public string SiparisTarihi { get; set; }
        public string IrsaliyeNo { get; set; }
        public string IrsaliyeTarihi { get; set; }
        public string GonderenVkn { get; set; }
        public string GonderenEtiket { get; set; }
        public string GonderenKapiNo { get; set; }
        public string GonderenCadde { get; set; }
        public string GonderenBinaAdi { get; set; }
        public string GonderenBinaNo { get; set; }
        public string GonderenSemt { get; set; }
        public string GonderenSehir { get; set; }
        public string GonderenPostaKodu { get; set; }
        public string GonderenKasaba { get; set; }
        public string GonderenUlke { get; set; }
        public string GonderenTelefon { get; set; }
        public string GonderenFaks { get; set; }
        public string GonderenEmail { get; set; }
        public string GonderenWebAdresi { get; set; }
        public string GonderenUnvan { get; set; }
        public string AliciVkn { get; set; }
        public string AliciEtiket { get; set; }
        public string AliciVergiDairesi { get; set; }
        public string AliciKapiNo { get; set; }
        public string AliciCadde { get; set; }
        public string AliciBinaAdi { get; set; }
        public string AliciBinaNo { get; set; }
        public string AliciSemt { get; set; }
        public string AliciSehir { get; set; }
        public string AliciPostaKodu { get; set; }
        public string AliciKasaba { get; set; }
        public string AliciUlke { get; set; }
        public string AliciTelefon { get; set; }
        public string AliciFaks { get; set; }
        public string AliciEmail { get; set; }
        public string AliciWebAdresi { get; set; }
        public string AliciUnvan { get; set; }
        public string Notlar { get; set; }
        public string Notlar2 { get; set; }
        public string Malzemeler { get; set; }
        public string HesaplananVergiler { get; set; }
        public decimal? MalHizmetToplam { get; set; }
        public decimal? ToplamIskonto { get; set; }
        public decimal? HesaplananKdv { get; set; }
        public decimal? VergilerDahilTutar { get; set; }
        public decimal? VergilerHaricTutar { get; set; }
        public decimal? OdenecekTutar { get; set; }
        public bool? KdvMuafiyetVarmi { get; set; }
        public string ZarfId { get; set; }
        public int? Processid { get; set; }
        public int? Status { get; set; }
        public string Description { get; set; }
        public string ReplyMessage { get; set; }
        public string ArchiveMessage { get; set; }
    }
}
