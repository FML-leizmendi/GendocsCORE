using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GendocsModeloDatos.models
{
    public partial class GenDocsContext : DbContext
    {
        public GenDocsContext()
        {
        }

        public GenDocsContext(DbContextOptions<GenDocsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CatApoyoCuerpos> CatApoyoCuerpos { get; set; }
        public virtual DbSet<CatTiposApoyo> CatTiposApoyo { get; set; }
        public virtual DbSet<CatTiposApoyoRecursos> CatTiposApoyoRecursos { get; set; }
        public virtual DbSet<GdAlertas> GdAlertas { get; set; }
        public virtual DbSet<GdCamposProyecto> GdCamposProyecto { get; set; }
        public virtual DbSet<GdCargos> GdCargos { get; set; }
        public virtual DbSet<GdClienteCodigosRecurso> GdClienteCodigosRecurso { get; set; }
        public virtual DbSet<GdClientes> GdClientes { get; set; }
        public virtual DbSet<GD_EmpleadosFML_Accesos> GD_EmpleadosFML_Accesos { get; set; }
        public virtual DbSet<GdClientesCodificacionRecursos> GdClientesCodificacionRecursos { get; set; }
        public virtual DbSet<GdContratas> GdContratas { get; set; }
        public virtual DbSet<GdDoc> GdDoc { get; set; }
        public virtual DbSet<GdDocCampos> GdDocCampos { get; set; }
        public virtual DbSet<GdEmpleados> GdEmpleados { get; set; }
        public virtual DbSet<GdEmpleadosEtiquetas> GdEmpleadosEtiquetas { get; set; }
        public virtual DbSet<GdEmpleadosFml> GdEmpleadosFml { get; set; }
        public virtual DbSet<GdEmpleadosFmlEtiquetas> GdEmpleadosFmlEtiquetas { get; set; }
        public virtual DbSet<GdEmpleadosFmlTiposTrabajo> GdEmpleadosFmlTiposTrabajo { get; set; }
        public virtual DbSet<GdEnviosEmail> GdEnviosEmail { get; set; }
        public virtual DbSet<GdEtiquetas> GdEtiquetas { get; set; }
        public virtual DbSet<GdEtiquetasFml> GdEtiquetasFml { get; set; }
        public virtual DbSet<GdHitos> GdHitos { get; set; }
        public virtual DbSet<GdListasVarias> GdListasVarias { get; set; }
        public virtual DbSet<GdModeloCon> GdModeloCon { get; set; }
        public virtual DbSet<GdModeloDoc> GdModeloDoc { get; set; }
        public virtual DbSet<GdModeloEsq> GdModeloEsq { get; set; }
        public virtual DbSet<GdModeloEsqCampos> GdModeloEsqCampos { get; set; }
        public virtual DbSet<GdNormasReglamentacion> GdNormasReglamentacion { get; set; }
        public virtual DbSet<GdPedidosCab> GdPedidosCab { get; set; }
        public virtual DbSet<GdPedidosDet> GdPedidosDet { get; set; }
        public virtual DbSet<GdProyectoApoyos> GdProyectoApoyos { get; set; }
        public virtual DbSet<GdProyectoApoyosDetGenesis> GdProyectoApoyosDetGenesis { get; set; }
        public virtual DbSet<GdProyectoEstados> GdProyectoEstados { get; set; }
        public virtual DbSet<GdProyectoLineas> GdProyectoLineas { get; set; }
        public virtual DbSet<GdProyectoPresupuestoActuacion> GdProyectoPresupuestoActuacion { get; set; }
        public virtual DbSet<GdProyectoPresupuestoDetalle> GdProyectoPresupuestoDetalle { get; set; }
        public virtual DbSet<GdProyectoPresupuestoLocalidades> GdProyectoPresupuestoLocalidades { get; set; }
        public virtual DbSet<GdProyectoPresupuestos> GdProyectoPresupuestos { get; set; }
        public virtual DbSet<GdProyectoTipos> GdProyectoTipos { get; set; }
        public virtual DbSet<GdProyectos> GdProyectos { get; set; }
        public virtual DbSet<GdProyectosHitos> GdProyectosHitos { get; set; }
        public virtual DbSet<GdRbda> GdRbda { get; set; }
        public virtual DbSet<GdRecursos> GdRecursos { get; set; }
        public virtual DbSet<GdRecursos_Unidad> GdRecursos_Unidad { get; set; }
        public virtual DbSet<GdRecursosActivos> GdRecursosActivos { get; set; }
        public virtual DbSet<GdRecursosAreas> GdRecursosAreas { get; set; }
        public virtual DbSet<GdTiposTrabajo> GdTiposTrabajo { get; set; }
        public virtual DbSet<GdTrabajoEstados> GdTrabajoEstados { get; set; }
        public virtual DbSet<GdUfupdate> GdUfupdate { get; set; }
        public virtual DbSet<GdUnidadesConstructivas> GdUnidadesConstructivas { get; set; }
        public virtual DbSet<GdUnidadesConstructivasPreciosHistorico> GdUnidadesConstructivasPreciosHistorico { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
               // To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("Server=DESKTOP-BGE7NFO;User ID=Alex;Password=1327Alex;database=GenDocs;");
                optionsBuilder.UseSqlServer("Server=PC-ALEXMOTA;Initial Catalog=GenDocs;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GD_EmpleadosFML_Accesos>(entity =>
            {
                entity.HasKey(e => e.IdAcceso)
                    .HasName("IdAcceso");

                entity.ToTable("GD_EmpleadosFML_Accesos");

                entity.HasIndex(e => e.IdEmpleadoFML)
                    .HasName("IdEmpleadoFML");

                entity.HasIndex(e => e.Acceso)
                    .HasName("Acceso");

                entity.HasIndex(e => e.Usuario)
                   .HasName("Usuario");

                entity.HasIndex(e => e.Password)
                   .HasName("Password");
            });

            modelBuilder.Entity<CatApoyoCuerpos>(entity =>
            {
                entity.HasKey(e => e.Mid)
                    .HasName("PK__CAT_Apoy__C797348ADFA61AED");

                entity.ToTable("CAT_Apoyo_Cuerpos");

                entity.HasIndex(e => e.CodModCuerpo)
                    .HasName("COD_MOD_CUERPO");

                entity.HasIndex(e => e.CodSubtipMatCuerpo)
                    .HasName("COD_SUBTIP_MAT_CUERPO");

                entity.HasIndex(e => e.CodTipMatCuerpo)
                    .HasName("COD_TIP_MAT_CUERPO");

                entity.HasIndex(e => e.NumMatSap)
                    .HasName("NUM_MAT_SAP");

                entity.Property(e => e.Mid)
                    .HasColumnName("MID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AltCuerpoMm).HasColumnName("ALT_CUERPO (mm)");

                entity.Property(e => e.CanEsfuerMaxCuerpoDN).HasColumnName("CAN_ESFUER_MAX_CUERPO (dN)");

                entity.Property(e => e.CodModCuerpo).HasColumnName("COD_MOD_CUERPO");

                entity.Property(e => e.CodSubtipMatCuerpo).HasColumnName("COD_SUBTIP_MAT_CUERPO");

                entity.Property(e => e.CodTipMatCuerpo).HasColumnName("COD_TIP_MAT_CUERPO");

                entity.Property(e => e.ModCuerpo)
                    .HasColumnName("MOD_CUERPO")
                    .HasMaxLength(255);

                entity.Property(e => e.NumMatSap).HasColumnName("NUM_MAT_SAP");

                entity.Property(e => e.Ordinal).HasColumnName("ORDINAL");

                entity.Property(e => e.SubtipMatCuerpo)
                    .HasColumnName("SUBTIP_MAT_CUERPO")
                    .HasMaxLength(255);

                entity.Property(e => e.TipMatCuerpo)
                    .HasColumnName("TIP_MAT_CUERPO")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CatTiposApoyo>(entity =>
            {
                entity.HasKey(e => e.IdTipoApoyo)
                    .HasName("PK__CAT_Tipo__DF75E68B68037005");

                entity.ToTable("CAT_TiposApoyo");

                entity.HasIndex(e => e.TipoApoyo)
                    .HasName("TipoApoyo")
                    .IsUnique();

                entity.Property(e => e.Lado)
                    .HasColumnType("decimal(8, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mid).HasColumnName("MID");

                entity.Property(e => e.Ord)
                    .HasColumnType("decimal(5, 1)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Serie).HasMaxLength(20);

                entity.Property(e => e.TipoApoyo).HasMaxLength(50);
            });

            modelBuilder.Entity<CatTiposApoyoRecursos>(entity =>
            {
                entity.ToTable("CAT_TiposApoyo_Recursos");

                entity.HasIndex(e => new { e.IdTipoApoyo, e.IdRecurso })
                    .HasName("TipoApoyo_Recurso")
                    .IsUnique();

                entity.Property(e => e.IdRecurso).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdTipoApoyo).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GdAlertas>(entity =>
            {
                entity.HasKey(e => e.IdAlerta)
                    .HasName("PK__GD_Alert__D2CDBC4FE9558EB4");

                entity.ToTable("GD_Alertas");

                entity.HasIndex(e => e.IdAlerta)
                    .HasName("IdAlerta");

                entity.HasIndex(e => e.IdProyectoHito)
                    .HasName("IdProyectoHito");

                entity.Property(e => e.Alerta).HasMaxLength(255);

                entity.Property(e => e.User).HasMaxLength(25);
            });

            modelBuilder.Entity<GdCamposProyecto>(entity =>
            {
                entity.HasKey(e => e.IdCampoPro)
                    .HasName("PK__GD_Campo__34BE5B51CACB8F52");

                entity.ToTable("GD_CamposProyecto");

                entity.HasIndex(e => e.CampoPro)
                    .HasName("CampoPro")
                    .IsUnique();

                entity.HasIndex(e => e.IdCampoPro)
                    .HasName("IdCampoPro");

                entity.Property(e => e.CampoPro).HasMaxLength(50);

                entity.Property(e => e.CodCampo).HasMaxLength(10);

                entity.Property(e => e.Funcion).HasMaxLength(255);

                entity.Property(e => e.FuncionAuto).HasMaxLength(255);

                entity.Property(e => e.FuncionNext).HasMaxLength(255);

                entity.Property(e => e.Orden)
                    .HasColumnType("decimal(3, 1)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GdCargos>(entity =>
            {
                entity.HasKey(e => e.IdCargo)
                    .HasName("PK__GD_Cargo__6C9856255ABAAA67");

                entity.ToTable("GD_Cargos");

                entity.HasIndex(e => e.Cargo)
                    .HasName("Cargo")
                    .IsUnique();

                entity.HasIndex(e => e.IdCargo)
                    .HasName("IdCargo");

                entity.HasIndex(e => e.IdCargoSuperior)
                    .HasName("IdCargoSuperior");

                entity.Property(e => e.IdCargo).ValueGeneratedNever();

                entity.Property(e => e.Cargo).HasMaxLength(255);
            });

            modelBuilder.Entity<GdClienteCodigosRecurso>(entity =>
            {
                entity.HasKey(e => new { e.IdRecurso, e.IdClientesCodificacionRecursos })
                    .HasName("PK__GD_Clien__04577AB4F7F9BDEC");

                entity.ToTable("GD_ClienteCodigosRecurso");

                entity.HasIndex(e => e.IdClientesCodificacionRecursos)
                    .HasName("IdClientes_CodigosRecursos");

                entity.HasIndex(e => e.IdRecurso)
                    .HasName("IdRecurso");

                entity.Property(e => e.IdClientesCodificacionRecursos).HasColumnName("IdClientes_CodificacionRecursos");

                entity.Property(e => e.ClienteCodigoRecurso).HasMaxLength(50);
            });

            modelBuilder.Entity<GdClientes>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__GD_Clien__D594664284AE52FC");

                entity.ToTable("GD_Clientes");

                entity.HasIndex(e => e.CódigoPersona)
                    .HasName("CódigoPersona")
                    .IsUnique();

                entity.HasIndex(e => e.IdCliente)
                    .HasName("IdCliente");

                entity.Property(e => e.Cliente).HasMaxLength(255);
            });

            modelBuilder.Entity<GdClientesCodificacionRecursos>(entity =>
            {
                entity.HasKey(e => e.IdClientesCodificacionRecursos)
                    .HasName("PK__GD_Clien__D4E325DA7391A967");

                entity.ToTable("GD_Clientes_CodificacionRecursos");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("IdCliente");

                entity.HasIndex(e => e.IdClientesCodificacionRecursos)
                    .HasName("IdClientes_CodigosRecursos");

                entity.Property(e => e.IdClientesCodificacionRecursos).HasColumnName("IdClientes_CodificacionRecursos");

                entity.Property(e => e.IdCliente).HasDefaultValueSql("((0))");

                entity.Property(e => e.NombreCodificacion).HasMaxLength(25);
            });

            modelBuilder.Entity<GdContratas>(entity =>
            {
                entity.HasKey(e => e.IdContrata)
                    .HasName("PK__GD_Contr__8569F06CE25D20A4");

                entity.ToTable("GD_Contratas");

                entity.HasIndex(e => e.Cif)
                    .HasName("CIF")
                    .IsUnique();

                entity.HasIndex(e => e.Contrata)
                    .HasName("Contrata")
                    .IsUnique();

                entity.HasIndex(e => e.RazonSocial)
                    .HasName("RazonSocial")
                    .IsUnique();

                entity.Property(e => e.Cif)
                    .HasColumnName("CIF")
                    .HasMaxLength(15);

                entity.Property(e => e.Contrata).HasMaxLength(20);

                entity.Property(e => e.RazonSocial).HasMaxLength(50);

                entity.Property(e => e.Telefono).HasMaxLength(30);
            });

            modelBuilder.Entity<GdDoc>(entity =>
            {
                entity.HasKey(e => e.IdDoc)
                    .HasName("PK__GD_Doc__0E65F8DB28730C04");

                entity.ToTable("GD_Doc");

                entity.HasIndex(e => e.IdDoc)
                    .HasName("IdDoc");

                entity.HasIndex(e => e.IdModeloDoc)
                    .HasName("IdModeloDoc");

                entity.HasIndex(e => e.IdProyecto)
                    .HasName("IdProyecto");

                entity.HasIndex(e => new { e.IdProyecto, e.NombreDoc })
                    .HasName("Proyecto_NombreDoc")
                    .IsUnique();

                entity.Property(e => e.DocumentoGenerado).HasMaxLength(255);

                entity.Property(e => e.IdModeloDoc).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdProyecto).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastUpdateU).HasMaxLength(25);

                entity.Property(e => e.NombreDoc).HasMaxLength(255);
            });

            modelBuilder.Entity<GdDocCampos>(entity =>
            {
                entity.HasKey(e => e.IdDocCampo)
                    .HasName("PK__GD_DocCa__C34F5EEECF6B6E73");

                entity.ToTable("GD_DocCampos");

                entity.HasIndex(e => e.IdCampo)
                    .HasName("IdCampo");

                entity.HasIndex(e => e.IdCampoPro)
                    .HasName("IdCampoPro");

                entity.HasIndex(e => e.IdDoc)
                    .HasName("IdDoc");

                entity.HasIndex(e => e.IdProyecto)
                    .HasName("IdProyecto");

                entity.Property(e => e.Campo).HasMaxLength(100);

                entity.Property(e => e.IdProyecto).HasDefaultValueSql("((0))");

                entity.Property(e => e.Valor1)
                    .HasColumnName("Valor_1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Valor10)
                    .HasColumnName("Valor_10")
                    .HasMaxLength(255);

                entity.Property(e => e.Valor12).HasColumnName("Valor_12");

                entity.Property(e => e.Valor4)
                    .HasColumnName("Valor_4")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Valor5)
                    .HasColumnName("Valor_5")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Valor8).HasColumnName("Valor_8");

                entity.Property(e => e.ValorExp).HasMaxLength(255);
            });

            modelBuilder.Entity<GdEmpleados>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado)
                    .HasName("PK__GD_Emple__CE6D8B9E6ECD79D1");

                entity.ToTable("GD_Empleados");

                entity.HasIndex(e => e.Empleado)
                    .HasName("Empleado")
                    .IsUnique();

                entity.HasIndex(e => e.IdCargo)
                    .HasName("IdCargo");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("IdCliente");

                entity.HasIndex(e => e.IdEmpleado)
                    .HasName("IdClientePlantilla");

                entity.HasIndex(e => e.IdEmpleadoSuperior)
                    .HasName("IdEmpleadoSuperior");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Empleado)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Etiquetas).HasMaxLength(255);

                entity.Property(e => e.Telefono).HasMaxLength(255);
            });

            modelBuilder.Entity<GdEmpleadosEtiquetas>(entity =>
            {
                entity.ToTable("GD_Empleados_Etiquetas");

                entity.HasIndex(e => e.IdEmpleado)
                    .HasName("GD_EmpleadosFML_EtiquetasIdEmpleadoFML");

                entity.HasIndex(e => new { e.IdEmpleado, e.IdEtiqueta })
                    .HasName("IDs")
                    .IsUnique();

                entity.Property(e => e.IdEmpleado).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdEtiqueta).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GdEmpleadosFml>(entity =>
            {
                entity.HasKey(e => e.IdEmpleadoFml)
                    .HasName("PK__GD_Emple__9744ED56779266DD");

                entity.ToTable("GD_EmpleadosFML");

                entity.Property(e => e.IdEmpleadoFml).HasColumnName("IdEmpleadoFML");

                entity.Property(e => e.Apellidos).HasMaxLength(255);

                entity.Property(e => e.CodigoPersona).HasDefaultValueSql("((0))");

                entity.Property(e => e.Direccion).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Estado).HasDefaultValueSql("((1))");

                entity.Property(e => e.Etiquetas).HasMaxLength(255);

                entity.Property(e => e.Nif)
                    .HasColumnName("NIF")
                    .HasMaxLength(15);

                entity.Property(e => e.Nombre).HasMaxLength(25);

                entity.Property(e => e.Telefono).HasMaxLength(255);

                entity.Property(e => e.TrelloIdMember).HasMaxLength(40);

                entity.Property(e => e.User).HasMaxLength(50);
            });

            modelBuilder.Entity<GdEmpleadosFmlEtiquetas>(entity =>
            {
                entity.ToTable("GD_EmpleadosFML_Etiquetas");

                entity.HasIndex(e => e.IdEmpleadoFml)
                    .HasName("GD_EmpleadosFML_EtiquetasIdEmpleadoFML");

                entity.HasIndex(e => new { e.IdEmpleadoFml, e.IdEtiqueta })
                    .HasName("IDs")
                    .IsUnique();

                entity.Property(e => e.IdEmpleadoFml)
                    .HasColumnName("IdEmpleadoFML")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdEtiqueta).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GdEmpleadosFmlTiposTrabajo>(entity =>
            {
                entity.ToTable("GD_EmpleadosFML_TiposTrabajo");

                entity.HasIndex(e => e.Id)
                    .HasName("Id");

                entity.HasIndex(e => e.IdEmpleadoFml)
                    .HasName("IdEmpleadoFML");

                entity.HasIndex(e => e.IdTipoTrabajo)
                    .HasName("IdTipoTrabajo");

                entity.Property(e => e.IdEmpleadoFml).HasColumnName("IdEmpleadoFML");

                entity.Property(e => e.Prioridad).HasDefaultValueSql("((1))");

                entity.Property(e => e.Provincia).HasMaxLength(255);
            });

            modelBuilder.Entity<GdEnviosEmail>(entity =>
            {
                entity.HasKey(e => e.IdEnvioEmail)
                    .HasName("PK__GD_Envio__0ACBB67073785D24");

                entity.ToTable("GD_EnviosEmail");

                entity.HasIndex(e => e.EntryId)
                    .HasName("IdItem");

                entity.HasIndex(e => e.IdDoc)
                    .HasName("IdFichaCab");

                entity.HasIndex(e => e.IdEnvioEmail)
                    .HasName("IdEnvioEmail");

                entity.HasIndex(e => e.IdProyecto)
                    .HasName("IdFactura");

                entity.Property(e => e.Adjuntos).HasMaxLength(255);

                entity.Property(e => e.Asunto).HasMaxLength(255);

                entity.Property(e => e.Bcc).HasMaxLength(255);

                entity.Property(e => e.Cc)
                    .HasColumnName("CC")
                    .HasMaxLength(255);

                entity.Property(e => e.EntryId).HasMaxLength(255);

                entity.Property(e => e.Firma).HasMaxLength(255);

                entity.Property(e => e.To).HasMaxLength(255);

                entity.Property(e => e.User).HasMaxLength(50);
            });

            modelBuilder.Entity<GdEtiquetas>(entity =>
            {
                entity.HasKey(e => e.IdEtiqueta)
                    .HasName("PK__GD_Etiqu__5041D723D2518CF4");

                entity.ToTable("GD_Etiquetas");

                entity.HasIndex(e => e.Etiqueta)
                    .HasName("EtiquetaFML")
                    .IsUnique();

                entity.Property(e => e.Etiqueta).HasMaxLength(50);

                entity.Property(e => e.Ord)
                    .HasColumnType("decimal(4, 1)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GdEtiquetasFml>(entity =>
            {
                entity.HasKey(e => e.IdEtiqueta)
                    .HasName("PK__GD_Etiqu__5041D7238B80C18F");

                entity.ToTable("GD_EtiquetasFML");

                entity.HasIndex(e => e.EtiquetaFml)
                    .HasName("EtiquetaFML")
                    .IsUnique();

                entity.Property(e => e.EtiquetaFml)
                    .HasColumnName("EtiquetaFML")
                    .HasMaxLength(50);

                entity.Property(e => e.Ord)
                    .HasColumnType("decimal(4, 1)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GdHitos>(entity =>
            {
                entity.HasKey(e => e.IdHito)
                    .HasName("PK__GD_Hitos__50E8E3BEE335550C");

                entity.ToTable("GD_Hitos");

                entity.HasIndex(e => e.Hito)
                    .HasName("Hito")
                    .IsUnique();

                entity.HasIndex(e => e.IdHito)
                    .HasName("Id")
                    .IsUnique();

                entity.HasIndex(e => e.IdHitoPadre)
                    .HasName("IdHitoPadre");

                entity.Property(e => e.AtSn)
                    .HasColumnName("AT_SN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BtSn)
                    .HasColumnName("BT_SN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fase).HasMaxLength(10);

                entity.Property(e => e.FechaCaducidadSn)
                    .HasColumnName("FechaCaducidadSN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaHechoSn)
                    .HasColumnName("FechaHechoSN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaPlazoSn)
                    .HasColumnName("FechaPlazoSN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Funcion).HasMaxLength(255);

                entity.Property(e => e.FuncionAuto).HasMaxLength(255);

                entity.Property(e => e.FuncionNext).HasMaxLength(255);

                entity.Property(e => e.Hito).HasMaxLength(255);

                entity.Property(e => e.IndicadorMecoSn)
                    .HasColumnName("IndicadorMecoSN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MtSn)
                    .HasColumnName("MT_SN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Orden)
                    .HasColumnType("decimal(3, 1)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrdenS)
                    .HasColumnType("decimal(3, 1)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReplanteoSn)
                    .HasColumnName("ReplanteoSN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SigorSn)
                    .HasColumnName("SigorSN")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GdListasVarias>(entity =>
            {
                entity.HasKey(e => e.IdElemento)
                    .HasName("PK__GD_Lista__4ED15E2DDD829287");

                entity.ToTable("GD_ListasVarias");

                entity.HasIndex(e => new { e.Lista, e.Elemento })
                    .HasName("ElementoLista")
                    .IsUnique();

                entity.Property(e => e.Elemento).HasMaxLength(255);

                entity.Property(e => e.Lista)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ord).HasColumnType("money");
            });

            modelBuilder.Entity<GdModeloCon>(entity =>
            {
                entity.HasKey(e => e.IdModeloContenido)
                    .HasName("PK__GD_Model__AB85F0A6074D1582");

                entity.ToTable("GD_ModeloCon");

                entity.HasIndex(e => e.IdEsquema)
                    .HasName("IdEsquema");

                entity.HasIndex(e => e.IdModeloContenido)
                    .HasName("IdModeloContenido");

                entity.Property(e => e.Orden)
                    .HasColumnType("decimal(3, 1)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GdModeloDoc>(entity =>
            {
                entity.HasKey(e => e.IdModeloDoc)
                    .HasName("PK__GD_Model__BE7BE15DE294AB41");

                entity.ToTable("GD_ModeloDoc");

                entity.HasIndex(e => e.CodModeloDoc)
                    .HasName("CodModeloDoc")
                    .IsUnique();

                entity.HasIndex(e => e.IdModeloDoc)
                    .HasName("IdModeloDoc")
                    .IsUnique();

                entity.HasIndex(e => e.ModeloDocumento)
                    .HasName("ModeloDoc")
                    .IsUnique();

                entity.Property(e => e.CarpetaDestino).HasMaxLength(255);

                entity.Property(e => e.CodModeloDoc).HasMaxLength(5);

                entity.Property(e => e.ModeloDocumento).HasMaxLength(255);

                entity.Property(e => e.ModeloWord).HasMaxLength(255);

                entity.Property(e => e.Orden)
                    .HasColumnType("decimal(3, 1)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GdModeloEsq>(entity =>
            {
                entity.HasKey(e => e.IdEsquema)
                    .HasName("PK__GD_Model__42DCB61020682023");

                entity.ToTable("GD_ModeloEsq");

                entity.HasIndex(e => e.IdEsquema)
                    .HasName("IdModelo");

                entity.HasIndex(e => e.IdEsquemaSuper)
                    .HasName("IdEsquemaSuper");

                entity.HasIndex(e => e.IdModeloDoc)
                    .HasName("IdModeloDoc");

                entity.HasIndex(e => e.IdParents)
                    .HasName("IdParents");

                entity.Property(e => e.Expanded).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdParents).HasMaxLength(255);

                entity.Property(e => e.ModeloWord).HasMaxLength(255);

                entity.Property(e => e.NumerarHijos).HasDefaultValueSql("((0))");

                entity.Property(e => e.Orden)
                    .HasColumnType("decimal(3, 1)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Orders).HasMaxLength(255);

                entity.Property(e => e.TituloEsquema).HasMaxLength(255);
            });

            modelBuilder.Entity<GdModeloEsqCampos>(entity =>
            {
                entity.HasKey(e => e.IdCampo)
                    .HasName("PK__GD_Model__6C61DA81C463F9B0");

                entity.ToTable("GD_ModeloEsq_Campos");

                entity.HasIndex(e => e.IdCampo)
                    .HasName("IdCampo");

                entity.HasIndex(e => e.IdEsquema)
                    .HasName("IdEsquema");

                entity.HasIndex(e => e.IdModeloDoc)
                    .HasName("IdModeloDoc");

                entity.Property(e => e.Campo).HasMaxLength(255);

                entity.Property(e => e.CodCampo).HasMaxLength(10);

                entity.Property(e => e.Funcion).HasMaxLength(255);

                entity.Property(e => e.FuncionAuto).HasMaxLength(255);

                entity.Property(e => e.FuncionNext).HasMaxLength(255);

                entity.Property(e => e.Info).HasMaxLength(255);

                entity.Property(e => e.Orden)
                    .HasColumnType("decimal(3, 1)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GdNormasReglamentacion>(entity =>
            {
                entity.HasKey(e => e.IdNorma)
                    .HasName("PK__GD_Norma__9B0E70ECDB67F4EC");

                entity.ToTable("GD_Normas_Reglamentacion");

                entity.HasIndex(e => e.CodNorma)
                    .HasName("CodNorma")
                    .IsUnique();

                entity.HasIndex(e => e.IdNorma)
                    .HasName("IdNorma");

                entity.Property(e => e.CodNorma).HasMaxLength(15);

                entity.Property(e => e.Norma).HasMaxLength(255);

                entity.Property(e => e.Ord).HasColumnType("money");

                entity.Property(e => e.SiCentroTransformador).HasDefaultValueSql("((0))");

                entity.Property(e => e.SiLineaAerea).HasDefaultValueSql("((0))");

                entity.Property(e => e.SiLineaSubterranea).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GdPedidosCab>(entity =>
            {
                entity.HasKey(e => e.IdPedidoCab)
                    .HasName("PK__GD_Pedid__0182BA0CBBB1B048");

                entity.ToTable("GD_PedidosCab");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("IdCliente");

                entity.HasIndex(e => e.IdEmpleadoGestor)
                    .HasName("IdEmpleadoResponsable");

                entity.HasIndex(e => e.IdPedidoCab)
                    .HasName("IdPedido");

                entity.HasIndex(e => e.IdProyecto)
                    .HasName("IdProyecto");

                entity.Property(e => e.Actuacion).HasMaxLength(150);

                entity.Property(e => e.CoeficienteFacturacion)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CoeficientePrecio)
                    .HasColumnType("decimal(4, 3)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DescripcionObra).HasMaxLength(150);

                entity.Property(e => e.Direccion).HasMaxLength(50);

                entity.Property(e => e.FilePdf)
                    .HasColumnName("FilePDF")
                    .HasMaxLength(255);

                entity.Property(e => e.Gestor).HasMaxLength(50);

                entity.Property(e => e.IvaSn).HasColumnName("IVA_SN");

                entity.Property(e => e.NumContrato).HasMaxLength(25);

                entity.Property(e => e.NumObra).HasMaxLength(50);

                entity.Property(e => e.NumRef).HasMaxLength(50);

                entity.Property(e => e.Poblacion).HasMaxLength(50);

                entity.Property(e => e.Provincia).HasMaxLength(50);

                entity.Property(e => e.TotalImporte).HasColumnType("money");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.GdPedidosCab)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_GD_PedidosCab_GD_Proyectos");
            });

            modelBuilder.Entity<GdPedidosDet>(entity =>
            {
                entity.HasKey(e => e.IdPedidoDet)
                    .HasName("PK__GD_Pedid__0CD5DFD0B681616E");

                entity.ToTable("GD_PedidosDet");

                entity.HasIndex(e => e.CodigoUc)
                    .HasName("GD_PedidosDetCodigoUC");

                entity.HasIndex(e => e.IdPedidoCab)
                    .HasName("IdPedidoCab");

                entity.HasIndex(e => e.IdPedidoDet)
                    .HasName("IdPeedidoDet");

                entity.HasIndex(e => e.IdResponsableFml)
                    .HasName("IdResponsableFML");

                entity.HasIndex(e => e.IdUc)
                    .HasName("IdUC");

                entity.Property(e => e.Cantidad).HasColumnType("money");

                entity.Property(e => e.CodigoUc)
                    .HasColumnName("CodigoUC")
                    .HasMaxLength(25);

                entity.Property(e => e.DescripcionUc)
                    .HasColumnName("DescripcionUC")
                    .HasMaxLength(200);

                entity.Property(e => e.IdResponsableFml).HasColumnName("IdResponsableFML");

                entity.Property(e => e.IdUc)
                    .HasColumnName("IdUC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Importe).HasColumnType("money");

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Unidad).HasMaxLength(25);

                entity.HasOne(d => d.IdPedidoCabNavigation)
                    .WithMany(p => p.GdPedidosDet)
                    .HasForeignKey(d => d.IdPedidoCab)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_GD_PedidosDet_GD_PedidosCab");
            });

            modelBuilder.Entity<GdProyectoApoyos>(entity =>
            {
                entity.HasKey(e => e.IdApoyo)
                    .HasName("PK__GD_Proye__2F2257016AB8E921");

                entity.ToTable("GD_Proyecto_Apoyos");

                entity.HasIndex(e => e.IdProyecto)
                    .HasName("GD_Proyecto_ApoyosIdProyecto");

                entity.HasIndex(e => new { e.IdProyecto, e.NumApoyo })
                    .HasName("IdProyecto")
                    .IsUnique();

                entity.Property(e => e.Altura)
                    .HasColumnType("decimal(4, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AmarreSn)
                    .HasColumnName("AmarreSN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AnclajeSn)
                    .HasColumnName("AnclajeSN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Angulo).HasDefaultValueSql("((0))");

                entity.Property(e => e.CableTierra).HasDefaultValueSql("((0))");

                entity.Property(e => e.CodTipoApoyo).HasMaxLength(255);

                entity.Property(e => e.CoordX)
                    .HasColumnName("coordX")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CoordY)
                    .HasColumnName("coordY")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CoordZ)
                    .HasColumnName("coordZ")
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DesmontarSn)
                    .HasColumnName("DesmontarSN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdLinea).HasDefaultValueSql("((0))");

                entity.Property(e => e.Material).HasMaxLength(25);

                entity.Property(e => e.NuevoSn)
                    .HasColumnName("NuevoSN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NumApoyo).HasMaxLength(25);

                entity.Property(e => e.Orden).HasDefaultValueSql("((0))");

                entity.Property(e => e.SisRefCoord)
                    .HasMaxLength(25)
                    .HasDefaultValueSql("(N'ETRS89-UTM-Zona30N')");

                entity.Property(e => e.VanoAnterior).HasDefaultValueSql("((0))");

                entity.Property(e => e.VanoPosterior).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GdProyectoApoyosDetGenesis>(entity =>
            {
                entity.ToTable("GD_Proyecto_ApoyosDet_Genesis");

                entity.HasIndex(e => e.IdApoyo)
                    .HasName("IdApoyo");

                entity.HasIndex(e => e.IdGcdet)
                    .HasName("IdGCDet");

                entity.Property(e => e.Campo).HasMaxLength(50);

                entity.Property(e => e.Cuenta).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdApoyo).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdGcdet)
                    .HasColumnName("IdGCDet")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Valor).HasMaxLength(100);
            });

            modelBuilder.Entity<GdProyectoEstados>(entity =>
            {
                entity.HasKey(e => e.IdProyectoEstado)
                    .HasName("PK__GD_Proye__42614F0733CE7F73");

                entity.ToTable("GD_ProyectoEstados");

                entity.HasIndex(e => e.ProyectoEstado)
                    .HasName("ProyectoEstado")
                    .IsUnique();

                entity.Property(e => e.IdProyectoEstado).ValueGeneratedNever();

                entity.Property(e => e.ProyectoEstado).HasMaxLength(255);
            });

            modelBuilder.Entity<GdProyectoLineas>(entity =>
            {
                entity.HasKey(e => e.IdLinea)
                    .HasName("PK__GD_Proye__3D1A3EAEBC2E7FDD");

                entity.ToTable("GD_Proyecto_Lineas");

                entity.HasIndex(e => e.IdLinea)
                    .HasName("IdProyecto_Linea");

                entity.HasIndex(e => e.IdProyecto)
                    .HasName("IdPRoyecto");

                entity.Property(e => e.IdProyecto).HasDefaultValueSql("((0))");

                entity.Property(e => e.NumLinea).HasMaxLength(5);

                entity.Property(e => e.Orden).HasDefaultValueSql("((0))");

                entity.Property(e => e.Subestación).HasMaxLength(50);
            });

            modelBuilder.Entity<GdProyectoPresupuestoActuacion>(entity =>
            {
                entity.HasKey(e => e.IdProPtoActuacion)
                    .HasName("PK__GD_Proye__3173DFE9DE839EA4");

                entity.ToTable("GD_Proyecto_Presupuesto_Actuacion");

                entity.HasIndex(e => e.IdPresupuesto)
                    .HasName("IdApoyo");

                entity.HasIndex(e => e.IdProPtoActuacion)
                    .HasName("IdApoyoPresupuestado");

                entity.Property(e => e.IdProPtoActuacion).HasColumnName("IdPro_Pto_Actuacion");

                entity.Property(e => e.Actuacion).HasMaxLength(100);

                entity.Property(e => e.CodActuacion).HasMaxLength(25);

                entity.Property(e => e.IdPresupuesto).HasDefaultValueSql("((0))");

                entity.Property(e => e.Orden).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GdProyectoPresupuestoDetalle>(entity =>
            {
                entity.HasKey(e => e.IdPtoDet)
                    .HasName("PK__GD_Proye__F0A6D9F9D8A102B9");

                entity.ToTable("GD_Proyecto_Presupuesto_Detalle");

                entity.HasIndex(e => e.IdPresupuesto)
                    .HasName("IdPresupuesto");

                entity.HasIndex(e => e.IdProAdetGenesis)
                    .HasName("IdPro_ADetGenesis");

                entity.HasIndex(e => e.IdProPtoActuacion)
                    .HasName("IdPro_Pto_Actuacion");

                entity.HasIndex(e => e.IdProPtoLocalidad)
                    .HasName("IdPro_Pto_Localidad");

                entity.HasIndex(e => e.IdPtoDet)
                    .HasName("IdPtoDet");

                entity.HasIndex(e => e.IdRecurso)
                    .HasName("IdRecurso");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodRecurso).HasMaxLength(50);

                entity.Property(e => e.IdPresupuesto).HasDefaultValueSql("((0))");

                entity.Property(e => e.IdProAdetGenesis)
                    .HasColumnName("IdPro_ADet_Genesis")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdProPtoActuacion)
                    .HasColumnName("IdPro_Pto_Actuacion")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdProPtoLocalidad)
                    .HasColumnName("IdPro_Pto_Localidad")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdRecurso).HasDefaultValueSql("((0))");

                entity.Property(e => e.Importe)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Orden).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrecioUnitario)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RecursoContratacion).HasMaxLength(75);

                entity.Property(e => e.Unidad).HasMaxLength(3);
            });

            modelBuilder.Entity<GdProyectoPresupuestoLocalidades>(entity =>
            {
                entity.HasKey(e => e.IdProPtoLocalidad)
                    .HasName("PK__GD_Proye__C995347787CA5740");

                entity.ToTable("GD_Proyecto_Presupuesto_Localidades");

                entity.HasIndex(e => e.IdPresupuesto)
                    .HasName("IdApoyo");

                entity.HasIndex(e => e.IdProPtoLocalidad)
                    .HasName("IdApoyoPresupuestado");

                entity.Property(e => e.IdProPtoLocalidad).HasColumnName("IdPro_Pto_Localidad");

                entity.Property(e => e.CodLocalidad).HasMaxLength(10);

                entity.Property(e => e.IdPresupuesto).HasDefaultValueSql("((0))");

                entity.Property(e => e.Localidad).HasMaxLength(255);

                entity.Property(e => e.Municipio).HasMaxLength(255);

                entity.Property(e => e.Orden).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GdProyectoPresupuestos>(entity =>
            {
                entity.HasKey(e => e.IdPresupuesto)
                    .HasName("PK__GD_Proye__D70FD1909DA2EF89");

                entity.ToTable("GD_Proyecto_Presupuestos");

                entity.HasIndex(e => e.IdPresupuesto)
                    .HasName("IdPresupuesto");

                entity.HasIndex(e => e.IdProyecto)
                    .HasName("IdProyectoq");

                entity.Property(e => e.IdProyecto).HasDefaultValueSql("((0))");

                entity.Property(e => e.Orden).HasDefaultValueSql("((0))");

                entity.Property(e => e.Presupuesto).HasMaxLength(255);

                entity.Property(e => e.TotalImporte)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GdProyectoTipos>(entity =>
            {
                entity.HasKey(e => e.CodTipoProyecto)
                    .HasName("PK__GD_Proye__79FDDFA160874D4C");

                entity.ToTable("GD_ProyectoTipos");

                entity.Property(e => e.CodTipoProyecto).HasMaxLength(2);

                entity.Property(e => e.CarpetasModelo).HasMaxLength(255);

                entity.Property(e => e.Orden).HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoProyecto).HasMaxLength(25);
            });

            modelBuilder.Entity<GdProyectos>(entity =>
            {
                entity.HasKey(e => e.IdProyecto)
                    .HasName("PK__GD_Proye__F4888673CF6D85C5");

                entity.ToTable("GD_Proyectos");

                entity.HasIndex(e => e.Alias)
                    .HasName("Alias")
                    .IsUnique();

                entity.HasIndex(e => e.CodigoProyecto)
                    .HasName("CódigoProyecto")
                    .IsUnique();

                entity.HasIndex(e => e.IdCliente)
                    .HasName("IdCliente");

                entity.HasIndex(e => e.IdEmpleadoGestor)
                    .HasName("IdEmpleadoGestor");

                entity.HasIndex(e => e.IdProyecto)
                    .HasName("IdProyecto");

                entity.HasIndex(e => e.Titulo)
                    .HasName("Titulo")
                    .IsUnique();

                entity.HasIndex(e => e.TituloCorto)
                    .HasName("TituloCorto")
                    .IsUnique();

                entity.Property(e => e.Alias).HasMaxLength(255);

                entity.Property(e => e.Autor).HasMaxLength(255);

                entity.Property(e => e.CarpetaBase).HasMaxLength(255);

                entity.Property(e => e.CentroTransformadorSn)
                    .HasColumnName("CentroTransformadorSN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CodigoProyecto).HasMaxLength(20);

                entity.Property(e => e.Colegiado).HasMaxLength(255);

                entity.Property(e => e.EmailGestor).HasMaxLength(255);

                entity.Property(e => e.EmailResponsable).HasMaxLength(255);

                entity.Property(e => e.Fmodificado).HasColumnName("FModificado");

                entity.Property(e => e.Gestor).HasMaxLength(255);

                entity.Property(e => e.LineaAereaSn)
                    .HasColumnName("LineaAereaSN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LineaSubterraneaSn)
                    .HasColumnName("LineaSubterraneaSN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Notas).HasMaxLength(255);

                entity.Property(e => e.Provincia).HasMaxLength(255);

                entity.Property(e => e.Responsable).HasMaxLength(255);

                entity.Property(e => e.TerminoMunicipal).HasMaxLength(255);

                entity.Property(e => e.TipoProyecto).HasMaxLength(2);

                entity.Property(e => e.Titulo).HasMaxLength(255);

                entity.Property(e => e.TituloCorto).HasMaxLength(255);

                entity.Property(e => e.Ucreado)
                    .HasColumnName("UCreado")
                    .HasMaxLength(255);

                entity.Property(e => e.Umodificado)
                    .HasColumnName("UModificado")
                    .HasMaxLength(255);

                entity.HasOne(d => d.IdProyectoEstadoNavigation)
                    .WithMany(p => p.GdProyectos)
                    .HasForeignKey(d => d.IdProyectoEstado)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_GD_Proyectos_GD_ProyectoEstados");

                entity.HasOne(d => d.TipoProyectoNavigation)
                    .WithMany(p => p.GdProyectos)
                    .HasForeignKey(d => d.TipoProyecto)
                    .HasConstraintName("FK_GD_Proyectos_GD_ProyectoTipos");
            });

            modelBuilder.Entity<GdProyectosHitos>(entity =>
            {
                entity.HasKey(e => e.IdProyectoHito)
                    .HasName("PK__GD_Proye__753AB42779C4E208");

                entity.ToTable("GD_Proyectos_Hitos");

                entity.HasIndex(e => e.IdHito)
                    .HasName("IdHito");

                entity.HasIndex(e => e.IdProyecto)
                    .HasName("IdProyecto");

                entity.HasIndex(e => e.IdProyectoHitoPadre)
                    .HasName("IdProyectoHitoPadre");

                entity.HasIndex(e => new { e.IdProyecto, e.IdHito })
                    .HasName("IdProyectoHito");

                entity.Property(e => e.AcabadoSn)
                    .HasColumnName("AcabadoSN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Falarma).HasColumnName("FAlarma");

                entity.Property(e => e.Fcaducidad).HasColumnName("FCaducidad");

                entity.Property(e => e.Fhecho).HasColumnName("FHecho");

                entity.Property(e => e.Fplazo).HasColumnName("FPlazo");

                entity.Property(e => e.HechoSn)
                    .HasColumnName("HechoSN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Hito).HasMaxLength(255);

                entity.Property(e => e.IncluirEnNotasGenerales).HasDefaultValueSql("((0))");

                entity.Property(e => e.Notas).HasMaxLength(255);

                entity.Property(e => e.Ord)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReplanteoOk)
                    .HasColumnName("ReplanteoOK")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReplanteoSn)
                    .HasColumnName("ReplanteoSN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SubhitosHechos)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("(N'-')");
            });

            modelBuilder.Entity<GdRbda>(entity =>
            {
                entity.ToTable("GD_RBDA");

                entity.HasIndex(e => e.Id)
                    .HasName("Id");

                entity.HasIndex(e => e.IdProyecto)
                    .HasName("GD_RBDAIdProyecto");

                entity.HasIndex(e => new { e.IdProyecto, e.NumFinca })
                    .HasName("IdProyecto_Finca")
                    .IsUnique();

                entity.Property(e => e.AfeccionActuacion)
                    .HasColumnName("Afeccion_Actuacion")
                    .HasMaxLength(15);

                entity.Property(e => e.AfeccionLongitudTendidoM)
                    .HasColumnName("Afeccion_Longitud_Tendido_m")
                    .HasMaxLength(255);

                entity.Property(e => e.AfeccionNumeroApoyo)
                    .HasColumnName("Afeccion_Numero_Apoyo")
                    .HasMaxLength(50);

                entity.Property(e => e.AfeccionOcupacionApoyoM2)
                    .HasColumnName("Afeccion_Ocupacion_Apoyo_m2")
                    .HasMaxLength(255);

                entity.Property(e => e.AfeccionServidumbreVueloM2)
                    .HasColumnName("Afeccion_Servidumbre_Vuelo_m2")
                    .HasMaxLength(255);

                entity.Property(e => e.FincaFinca)
                    .HasColumnName("Finca_Finca")
                    .HasMaxLength(10);

                entity.Property(e => e.FincaMunicipio)
                    .HasColumnName("Finca_Municipio")
                    .HasMaxLength(50);

                entity.Property(e => e.FincaNaturalezaCultivo)
                    .HasColumnName("Finca_Naturaleza_Cultivo")
                    .HasMaxLength(75);

                entity.Property(e => e.FincaParcela)
                    .HasColumnName("Finca_Parcela")
                    .HasMaxLength(10);

                entity.Property(e => e.FincaPoligono)
                    .HasColumnName("Finca_Poligono")
                    .HasMaxLength(5);

                entity.Property(e => e.IdProyecto).HasDefaultValueSql("((0))");

                entity.Property(e => e.NumFinca).HasDefaultValueSql("((0))");

                entity.Property(e => e.TalaArboladoM2)
                    .HasColumnName("Tala_Arbolado_m2")
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TitularCp).HasColumnName("Titular_CP");

                entity.Property(e => e.TitularDireccion).HasColumnName("Titular_Direccion");

                entity.Property(e => e.TitularLocalidad).HasColumnName("Titular_Localidad");

                entity.Property(e => e.TitularNif).HasColumnName("Titular_NIF");

                entity.Property(e => e.TitularPropietario).HasColumnName("Titular_Propietario");

                entity.Property(e => e.TitularProvincia).HasColumnName("Titular_Provincia");
            });

            modelBuilder.Entity<GdRecursos_Unidad>(entity =>
            {
                entity.HasKey(e => e.IdUnidad)
                    .HasName("PK_GD_Recursos_Unidad");

                entity.ToTable("GD_Recursos_Unidad");

                entity.HasIndex(e => e.IdUnidad)
                    .HasName("IdUnidad");
            });

            modelBuilder.Entity<GdRecursos>(entity =>
            {
                entity.HasKey(e => e.IdRecurso)
                    .HasName("PK__GD_Recur__B91948E90D1BD166");

                entity.ToTable("GD_Recursos");

                entity.HasIndex(e => e.IdRecurso)
                    .HasName("IdRecurso1");

                entity.HasIndex(e => e.IdRecursosActivo)
                    .HasName("IdActivo");

                entity.Property(e => e.CodRecurso).HasMaxLength(50);

                entity.Property(e => e.CosteManodeObra)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CosteMateriales)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CosteTotal)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdRecursosActivo).HasColumnName("IdRecursos_Activo");

                entity.Property(e => e.Prohibido).HasDefaultValueSql("((0))");

                entity.Property(e => e.RecursoContratacion).HasMaxLength(255);

                entity.Property(e => e.Unidad).HasMaxLength(3);
            });

            modelBuilder.Entity<GdRecursosActivos>(entity =>
            {
                entity.HasKey(e => e.IdRecursosActivo)
                    .HasName("PK__GD_Recur__C409E2CEC8F6C558");

                entity.ToTable("GD_Recursos_Activos");

                entity.HasIndex(e => e.IdRecursosActivo)
                    .HasName("IdRecursos_Activo");

                entity.HasIndex(e => e.IdRecursosArea)
                    .HasName("IdRecursos_Area");

                entity.Property(e => e.IdRecursosActivo).HasColumnName("IdRecursos_Activo");

                entity.Property(e => e.Activo).HasMaxLength(255);

                entity.Property(e => e.IdRecursosArea).HasColumnName("IdRecursos_Area");

                entity.Property(e => e.Orden).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GdRecursosAreas>(entity =>
            {
                entity.HasKey(e => e.IdRecursosArea)
                    .HasName("PK__GD_Recur__31F5F1B66E3AA08B");

                entity.ToTable("GD_Recursos_Areas");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("IdCliente");

                entity.HasIndex(e => e.IdRecursosArea)
                    .HasName("IdRecursos_Area");

                entity.Property(e => e.IdRecursosArea).HasColumnName("IdRecursos_Area");

                entity.Property(e => e.Area).HasMaxLength(255);

                entity.Property(e => e.Orden).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GdTiposTrabajo>(entity =>
            {
                entity.HasKey(e => e.IdTipoTrabajo)
                    .HasName("PK__GD_Tipos__8816D7FFDE6C41B8");

                entity.ToTable("GD_TiposTrabajo");

                entity.HasIndex(e => e.TipoTrabajo)
                    .HasName("TipoTrabajo")
                    .IsUnique();

                entity.Property(e => e.Ord)
                    .HasColumnType("decimal(4, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoTrabajo)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TipoTrabajoAlb).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<GdTrabajoEstados>(entity =>
            {
                entity.HasKey(e => e.IdEstadoTrabajo)
                    .HasName("PK__GD_Traba__D2B075719643FEA9");

                entity.ToTable("GD_TrabajoEstados");

                entity.HasIndex(e => e.EstadoTrabajo)
                    .HasName("EstadoTrabajo")
                    .IsUnique();

                entity.Property(e => e.IdEstadoTrabajo).ValueGeneratedNever();

                entity.Property(e => e.EstadoTrabajo).HasMaxLength(20);
            });

            modelBuilder.Entity<GdUfupdate>(entity =>
            {
                entity.ToTable("GD_UFUpdate");

                entity.HasIndex(e => e.IdDoc)
                    .HasName("IdDoc");

                entity.HasIndex(e => e.IdProyecto)
                    .HasName("IdProyecto");

                entity.HasIndex(e => e.IdProyectoHito)
                    .HasName("IdProyectoHito");

                entity.Property(e => e.Accion).HasMaxLength(255);

                entity.Property(e => e.Fupdate).HasColumnName("FUpdate");

                entity.Property(e => e.IdDoc).HasDefaultValueSql("((0))");

                entity.Property(e => e.Uupdate)
                    .HasColumnName("UUpdate")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<GdUnidadesConstructivas>(entity =>
            {
                entity.HasKey(e => e.IdUc)
                    .HasName("PK__GD_Unida__B77002569DB4CE16");

                entity.ToTable("GD_UnidadesConstructivas");

                entity.HasIndex(e => e.CodigoUc)
                    .HasName("GD_UnidadesConstructivasCodigoUC");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("GD_UnidadesConstructivasIdCliente");

                entity.HasIndex(e => e.IdTipoTrabajo)
                    .HasName("IdTipoTrabajo");

                entity.HasIndex(e => new { e.IdCliente, e.CodigoUc })
                    .HasName("CodigoCliente")
                    .IsUnique();

                entity.Property(e => e.IdUc).HasColumnName("IdUC");

                entity.Property(e => e.CodigoUc)
                    .HasColumnName("CodigoUC")
                    .HasMaxLength(25);

                entity.Property(e => e.CodigoUc2)
                    .HasColumnName("CodigoUC2")
                    .HasMaxLength(25);

                entity.Property(e => e.DescripcionUc)
                    .HasColumnName("DescripcionUC")
                    .HasMaxLength(255);

                entity.Property(e => e.IdCliente).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrecioUnidad)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ud).HasMaxLength(5);
            });

            modelBuilder.Entity<GdUnidadesConstructivasPreciosHistorico>(entity =>
            {
                entity.ToTable("GD_UnidadesConstructivasPreciosHistorico");

                entity.HasIndex(e => e.Id)
                    .HasName("Id");

                entity.HasIndex(e => new { e.IdUc, e.Fecha, e.PrecioUc })
                    .HasName("Unica")
                    .IsUnique();

                entity.Property(e => e.DescripcionUc)
                    .HasColumnName("DescripcionUC")
                    .HasMaxLength(255);

                entity.Property(e => e.IdUc)
                    .HasColumnName("IdUC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrecioUc)
                    .HasColumnName("PrecioUC")
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ud).HasMaxLength(5);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
