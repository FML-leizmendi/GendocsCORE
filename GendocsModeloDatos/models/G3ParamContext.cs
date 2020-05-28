using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GendocsModeloDatos.models
{
    public partial class G3ParamContext : DbContext
    {
        public G3ParamContext()
        {
        }

        public G3ParamContext(DbContextOptions<GenDocsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<G3Param> G3Params { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("Server=DESKTOP-BGE7NFO;User ID=Alex;Password=123456;database=GenDocs;");
                //optionsBuilder.UseSqlServer("Server=PC-ALEXMOTA;Initial Catalog=GenDocs;Integrated Security=True;");
                //optionsBuilder.UseSqlServer("Server=ZUBIXILEKO-PC\\SQLEXPRESS;database=GenDocs;Integrated Security=True;");
                //optionsBuilder.UseSqlServer("Server=DESKTOP-BGE7NFO;Integrated Security=True;database=GenDocs;");
                string g3_connection = Environment.GetEnvironmentVariable("G3_CONNECTION",EnvironmentVariableTarget.User);
                optionsBuilder.UseSqlServer(g3_connection);


            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<G3Param>(entity =>
            {
                entity.HasKey(e => e.NP)
                    .HasName("PK_NompreParametro");

                entity.ToTable("cfgParam");

                entity.HasIndex(e => e.FModificado)
                    .HasName("FechaModificacion");

            });
        }
    }
}
