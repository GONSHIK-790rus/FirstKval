using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FirstKval;

internal class DataBaseContext : DbContext {
    private const string _SERVER = @"Server = DESKTOP-VD7T692\SQLEXPRESS;";
    private const string _DATABASE = @"Database = company_database;";
    private const string _TRUSTED_CONNECTION = @"Trusted_Connection = True;";
    private const string _TRUST_SERVER = @"TrustServerCertificate = True;";

    public DbSet<Partner> Partners { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlServer(_SERVER + _DATABASE + _TRUSTED_CONNECTION + _TRUST_SERVER);
    }

    private readonly string _tableName = "partners";
    private readonly string _tableScheme = "dbo";
    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Partner>(entity => {
            entity.ToTable(_tableName, _tableScheme);
            entity.HasKey(partner => partner.Id);

            SetPropertiesToEntity(entity);
        });
    }

    private void SetPropertiesToEntity(EntityTypeBuilder<Partner> entity) {
        entity.Property(partner => partner.Id).HasColumnName("id_partner");
        entity.Property(partner => partner.CompanyName).HasColumnName("name_partner").IsRequired();
        entity.Property(partner => partner.DirectorName).HasColumnName("CEO_partner").IsRequired();
        entity.Property(partner => partner.PhoneNumber).HasColumnName("phone_number").IsRequired();
        entity.Property(partner => partner.Rating).HasColumnName("rating");
        entity.Property(partner => partner.Discount).HasColumnName("discount").IsRequired();
        entity.Property(partner => partner.Type).HasColumnName("category").IsRequired();
        entity.Property(partner => partner.NumOfSoldProducts).HasColumnName("num_of_sold_products");
    }
}
