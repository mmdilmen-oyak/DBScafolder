using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DBScaffolder.Data.Entities;

namespace DBScaffolder.Data
{
    public partial class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public virtual DbSet<CodeNEInvoice> CodeNEInvoice { get; set; }
        public virtual DbSet<CodeNEInvoiceLine> CodeNEInvoiceLine { get; set; }
        public virtual DbSet<CodeNEInvoiceLineTax> CodeNEInvoiceLineTax { get; set; }
        public virtual DbSet<CodeNEInvoiceTax> CodeNEInvoiceTax { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=10.65.100.108;Database=eBA;User Id=sa; password=EbaWF.@; Integrated Security=false;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CodeNEInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("codeN_E_Invoice");

                entity.Property(e => e.AliciBinaAdi)
                    .HasColumnName("aliciBinaAdi")
                    .HasMaxLength(255);

                entity.Property(e => e.AliciBinaNo)
                    .HasColumnName("aliciBinaNo")
                    .HasMaxLength(255);

                entity.Property(e => e.AliciCadde)
                    .HasColumnName("aliciCadde")
                    .HasMaxLength(255);

                entity.Property(e => e.AliciEmail)
                    .HasColumnName("aliciEMail")
                    .HasMaxLength(255);

                entity.Property(e => e.AliciEtiket)
                    .HasColumnName("aliciEtiket")
                    .HasMaxLength(255);

                entity.Property(e => e.AliciFaks)
                    .HasColumnName("aliciFaks")
                    .HasMaxLength(255);

                entity.Property(e => e.AliciKapiNo)
                    .HasColumnName("aliciKapiNo")
                    .HasMaxLength(255);

                entity.Property(e => e.AliciKasaba)
                    .HasColumnName("aliciKasaba")
                    .HasMaxLength(255);

                entity.Property(e => e.AliciPostaKodu)
                    .HasColumnName("aliciPostaKodu")
                    .HasMaxLength(255);

                entity.Property(e => e.AliciSehir)
                    .HasColumnName("aliciSehir")
                    .HasMaxLength(255);

                entity.Property(e => e.AliciSemt)
                    .HasColumnName("aliciSemt")
                    .HasMaxLength(255);

                entity.Property(e => e.AliciTelefon)
                    .HasColumnName("aliciTelefon")
                    .HasMaxLength(255);

                entity.Property(e => e.AliciUlke)
                    .HasColumnName("aliciUlke")
                    .HasMaxLength(255);

                entity.Property(e => e.AliciUnvan)
                    .HasColumnName("aliciUnvan")
                    .HasMaxLength(255);

                entity.Property(e => e.AliciVergiDairesi)
                    .HasColumnName("aliciVergiDairesi")
                    .HasMaxLength(255);

                entity.Property(e => e.AliciVkn)
                    .HasColumnName("aliciVKN")
                    .HasMaxLength(255);

                entity.Property(e => e.AliciWebAdresi)
                    .HasColumnName("aliciWebAdresi")
                    .HasMaxLength(255);

                entity.Property(e => e.ArchiveMessage).HasColumnName("archiveMessage");

                entity.Property(e => e.CevapVerildimi).HasColumnName("cevapVerildimi");

                entity.Property(e => e.Description).HasColumnName("DESCRIPTION");

                entity.Property(e => e.FaturaNo)
                    .HasColumnName("faturaNo")
                    .HasMaxLength(255);

                entity.Property(e => e.FaturaTarihi)
                    .HasColumnName("faturaTarihi")
                    .HasMaxLength(255);

                entity.Property(e => e.FaturaTipi)
                    .HasColumnName("faturaTipi")
                    .HasMaxLength(255);

                entity.Property(e => e.FaturaninEvrenselTekilNumarasi)
                    .HasColumnName("faturaninEvrenselTekilNumarasi")
                    .HasMaxLength(255);

                entity.Property(e => e.GelisZamani)
                    .HasColumnName("gelisZamani")
                    .HasColumnType("datetime");

                entity.Property(e => e.GonderenBinaAdi)
                    .HasColumnName("gonderenBinaAdi")
                    .HasMaxLength(255);

                entity.Property(e => e.GonderenBinaNo)
                    .HasColumnName("gonderenBinaNo")
                    .HasMaxLength(255);

                entity.Property(e => e.GonderenCadde)
                    .HasColumnName("gonderenCadde")
                    .HasMaxLength(255);

                entity.Property(e => e.GonderenEmail)
                    .HasColumnName("gonderenEMail")
                    .HasMaxLength(255);

                entity.Property(e => e.GonderenEtiket)
                    .HasColumnName("gonderenEtiket")
                    .HasMaxLength(255);

                entity.Property(e => e.GonderenFaks)
                    .HasColumnName("gonderenFaks")
                    .HasMaxLength(255);

                entity.Property(e => e.GonderenKapiNo)
                    .HasColumnName("gonderenKapiNo")
                    .HasMaxLength(255);

                entity.Property(e => e.GonderenKasaba)
                    .HasColumnName("gonderenKasaba")
                    .HasMaxLength(255);

                entity.Property(e => e.GonderenPostaKodu)
                    .HasColumnName("gonderenPostaKodu")
                    .HasMaxLength(255);

                entity.Property(e => e.GonderenSehir)
                    .HasColumnName("gonderenSehir")
                    .HasMaxLength(255);

                entity.Property(e => e.GonderenSemt)
                    .HasColumnName("gonderenSemt")
                    .HasMaxLength(255);

                entity.Property(e => e.GonderenTelefon)
                    .HasColumnName("gonderenTelefon")
                    .HasMaxLength(255);

                entity.Property(e => e.GonderenUlke)
                    .HasColumnName("gonderenUlke")
                    .HasMaxLength(255);

                entity.Property(e => e.GonderenUnvan)
                    .HasColumnName("gonderenUnvan")
                    .HasMaxLength(255);

                entity.Property(e => e.GonderenVkn)
                    .HasColumnName("gonderenVKN")
                    .HasMaxLength(255);

                entity.Property(e => e.GonderenWebAdresi)
                    .HasColumnName("gonderenWebAdresi")
                    .HasMaxLength(255);

                entity.Property(e => e.HesaplananKdv)
                    .HasColumnName("hesaplananKdv")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.HesaplananVergiler)
                    .HasColumnName("hesaplananVergiler")
                    .HasMaxLength(255);

                entity.Property(e => e.IrsaliyeNo)
                    .HasColumnName("irsaliyeNo")
                    .HasMaxLength(255);

                entity.Property(e => e.IrsaliyeTarihi)
                    .HasColumnName("irsaliyeTarihi")
                    .HasMaxLength(255);

                entity.Property(e => e.KdvMuafiyetVarmi).HasColumnName("kdvMuafiyetVarmi");

                entity.Property(e => e.MalHizmetToplam)
                    .HasColumnName("malHizmetToplam")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Malzemeler)
                    .HasColumnName("malzemeler")
                    .HasMaxLength(255);

                entity.Property(e => e.Notlar).HasColumnName("notlar");

                entity.Property(e => e.Notlar2).HasColumnName("notlar2");

                entity.Property(e => e.OdenecekTutar)
                    .HasColumnName("odenecekTutar")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ParaBirimi)
                    .HasColumnName("paraBirimi")
                    .HasMaxLength(255);

                entity.Property(e => e.Processid).HasColumnName("PROCESSID");

                entity.Property(e => e.ReplyMessage).HasColumnName("replyMessage");

                entity.Property(e => e.Senaryo)
                    .HasColumnName("senaryo")
                    .HasMaxLength(255);

                entity.Property(e => e.SiparisNo)
                    .HasColumnName("siparisNo")
                    .HasMaxLength(255);

                entity.Property(e => e.SiparisTarihi)
                    .HasColumnName("siparisTarihi")
                    .HasMaxLength(255);

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.ToplamIskonto)
                    .HasColumnName("toplamIskonto")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VergilerDahilTutar)
                    .HasColumnName("vergilerDahilTutar")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VergilerHaricTutar)
                    .HasColumnName("vergilerHaricTutar")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ZarfId)
                    .HasColumnName("zarfID")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CodeNEInvoiceLine>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("codeN_E_Invoice_Line");

                entity.Property(e => e.Birim)
                    .HasColumnName("birim")
                    .HasMaxLength(255);

                entity.Property(e => e.BirimFiyat)
                    .HasColumnName("birimFiyat")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceId)
                    .HasColumnName("InvoiceID")
                    .HasMaxLength(255);

                entity.Property(e => e.IskontoOrani)
                    .HasColumnName("iskontoOrani")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IskontoTutari)
                    .HasColumnName("iskontoTutari")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.KdvMuafiyetVarmi).HasColumnName("kdvMuafiyetVarmi");

                entity.Property(e => e.KdvOrani)
                    .HasColumnName("kdvOrani")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.KdvTutari)
                    .HasColumnName("kdvTutari")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.MalzemeAdi)
                    .HasColumnName("malzemeAdi")
                    .HasMaxLength(255);

                entity.Property(e => e.MalzemeTutari)
                    .HasColumnName("malzemeTutari")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Miktar)
                    .HasColumnName("miktar")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MuafiyetSebebi)
                    .HasColumnName("muafiyetSebebi")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CodeNEInvoiceLineTax>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("codeN_E_Invoice_Line_Tax");

                entity.Property(e => e.InvoiceId)
                    .HasColumnName("InvoiceID")
                    .HasMaxLength(255);

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.Miktar)
                    .HasColumnName("miktar")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Oran)
                    .HasColumnName("oran")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxId).HasColumnName("TaxID");

                entity.Property(e => e.VergiTuru)
                    .HasColumnName("vergiTuru")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CodeNEInvoiceTax>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("codeN_E_Invoice_Tax");

                entity.Property(e => e.InvoiceId)
                    .HasColumnName("InvoiceID")
                    .HasMaxLength(255);

                entity.Property(e => e.Miktar)
                    .HasColumnName("miktar")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TaxId).HasColumnName("TaxID");

                entity.Property(e => e.VergiTuru)
                    .HasColumnName("vergiTuru")
                    .HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
