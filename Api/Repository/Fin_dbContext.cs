using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Finance_Api.Repository
{
    public partial class Fin_dbContext : DbContext
    {
        public Fin_dbContext()
        {
        }

        public Fin_dbContext(DbContextOptions<Fin_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EmiCard> EmiCard { get; set; }
        public virtual DbSet<LoginAdmin> LoginAdmin { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<UserRegistration> UserRegistration { get; set; }
        public object UserRegistrations { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=localhost;initial catalog=Fin_db;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmiCard>(entity =>
            {
                entity.HasKey(e => e.EmiCardNumber)
                    .HasName("PK__EmiCard__FE8A004DAF8CD574");

                entity.Property(e => e.EmiCardNumber)
                    .HasColumnName("emiCardNumber")
                    .ValueGeneratedNever();

                entity.Property(e => e.CardType)
                    .IsRequired()
                    .HasColumnName("cardType")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreditUsed)
                    .HasColumnName("creditUsed")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('UNAPPROVED')");

                entity.Property(e => e.TotalCredit)
                    .HasColumnName("totalCredit")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ValidTill)
                    .HasColumnName("validTill")
                    .HasColumnType("date");

                entity.HasOne(d => d.EmailNavigation)
                    .WithMany(p => p.EmiCard)
                    .HasForeignKey(d => d.Email)
                    .HasConstraintName("FK__EmiCard__email__571DF1D5");
            });

            modelBuilder.Entity<LoginAdmin>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AccPassword)
                    .IsRequired()
                    .HasColumnName("accPassword")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("userName")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__Orders__0809335D26AE0679");

                entity.Property(e => e.OrderId)
                    .HasColumnName("orderId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmiTenure).HasColumnName("emiTenure");

                entity.Property(e => e.Productid).HasColumnName("productid");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.TotalCost)
                    .HasColumnName("totalCost")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.EmailNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Email)
                    .HasConstraintName("FK__Orders__email__4E88ABD4");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Productid)
                    .HasConstraintName("FK__Orders__producti__4F7CD00D");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__Products__2D10D16AABEB7ADC");

                entity.Property(e => e.ProductId)
                    .HasColumnName("productId")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cost)
                    .HasColumnName("cost")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductDetails)
                    .IsRequired()
                    .HasColumnName("productDetails")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnName("productName")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserRegistration>(entity =>
            {
                entity.HasKey(e => e.Email)
                    .HasName("PK__UserRegi__AB6E6165FA71D0E6");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AccPassword)
                    .IsRequired()
                    .HasColumnName("accPassword")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .HasColumnName("accountNumber")
                    .HasColumnType("numeric(20, 0)");

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasColumnName("bankName")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CardType)
                    .IsRequired()
                    .HasColumnName("cardType")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmPassword)
                    .IsRequired()
                    .HasColumnName("confirmPassword")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasColumnType("date");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("fullName")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.HomeAddress)
                    .IsRequired()
                    .HasColumnName("homeAddress")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IfscCode)
                    .IsRequired()
                    .HasColumnName("ifscCode")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phoneNumber")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
