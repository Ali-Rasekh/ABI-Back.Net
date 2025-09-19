using System;
using System.Collections.Generic;
using MaroonModels;
using Microsoft.EntityFrameworkCore;

namespace Context.MaroonContext;

public partial class MaroonContext : DbContext
{
    public MaroonContext()
    {
    }

    public MaroonContext(DbContextOptions<MaroonContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BiAccessGroup> BiAccessGroups { get; set; }

    public virtual DbSet<BiAccessGroupLabor> BiAccessGroupLabors { get; set; }

    public virtual DbSet<BiAccessGroupPermission> BiAccessGroupPermissions { get; set; }

    public virtual DbSet<BiCalendar> BiCalendars { get; set; }

    public virtual DbSet<BiCategory> BiCategories { get; set; }

    public virtual DbSet<BiDocument> BiDocuments { get; set; }

    public virtual DbSet<BiDocumentCategory> BiDocumentCategories { get; set; }

    public virtual DbSet<BiFilter> BiFilters { get; set; }

    public virtual DbSet<BiFilterAvailableValue> BiFilterAvailableValues { get; set; }

    public virtual DbSet<BiFilterGroup> BiFilterGroups { get; set; }

    public virtual DbSet<BiFilterRelation> BiFilterRelations { get; set; }

    public virtual DbSet<BiFilterStaticGroup> BiFilterStaticGroups { get; set; }

    public virtual DbSet<BiFilterStaticItem> BiFilterStaticItems { get; set; }

    public virtual DbSet<BiIndicator> BiIndicators { get; set; }

    public virtual DbSet<BiIndicatorGroup> BiIndicatorGroups { get; set; }

    public virtual DbSet<BiSavedFilter> BiSavedFilters { get; set; }

    public virtual DbSet<BiSavedFilterValue> BiSavedFilterValues { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=entAMSMPC;Trusted_Connection=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BiAccessGroup>(entity =>
        {
            entity.HasKey(e => e.Pk).HasName("PK_RAccessGroup");

            entity.ToTable("BI_AccessGroup", "rep");

            entity.Property(e => e.Pk).HasColumnName("PK");
            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<BiAccessGroupLabor>(entity =>
        {
            entity.HasKey(e => e.Pk).HasName("PK__BI_Acces__321507877AE06979");

            entity.ToTable("BI_AccessGroupLabor", "rep");

            entity.Property(e => e.Pk).HasColumnName("PK");
            entity.Property(e => e.AccessGroupPk).HasColumnName("AccessGroupPK");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatorLaborPk).HasColumnName("CreatorLaborPK");
            entity.Property(e => e.LaborPk).HasColumnName("LaborPK");
        });

        modelBuilder.Entity<BiAccessGroupPermission>(entity =>
        {
            entity.HasKey(e => e.Pk).HasName("PK__BI_Acces__32150787EA6DA51A");

            entity.ToTable("BI_AccessGroupPermission", "rep");

            entity.Property(e => e.Pk).HasColumnName("PK");
            entity.Property(e => e.AccessGroupPk).HasColumnName("AccessGroupPK");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatorLaborPk).HasColumnName("CreatorLaborPK");
            entity.Property(e => e.PermissionPk)
                .HasComment("Enum")
                .HasColumnName("PermissionPK");
            entity.Property(e => e.RefPk)
                .HasComment("DocumentPK OR CategoryPK")
                .HasColumnName("RefPK");
        });

        modelBuilder.Entity<BiCalendar>(entity =>
        {
            entity.HasKey(e => e.MiladiDate).HasName("PK__ACalndar__D2A1CF5E6B792B551");

            entity.ToTable("BI_Calendar", "rep");

            entity.Property(e => e.ShamsiDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ShamsiDayOfWeekName).HasMaxLength(20);
            entity.Property(e => e.ShamsiMonthName).HasMaxLength(50);
            entity.Property(e => e.ShamsiSeasonName).HasMaxLength(50);
        });

        modelBuilder.Entity<BiCategory>(entity =>
        {
            entity.HasKey(e => e.Pk).HasName("PK__BI_Categ__321507877296FBBF");

            entity.ToTable("BI_Category", "rep");

            entity.Property(e => e.Pk).HasColumnName("PK");
            entity.Property(e => e.Active).HasDefaultValue(true);
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("deleted_at");
            entity.Property(e => e.Description).HasMaxLength(300);
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ParentPk).HasColumnName("ParentPK");
            entity.Property(e => e.SortOrder).HasDefaultValue(1);
        });

        modelBuilder.Entity<BiDocument>(entity =>
        {
            entity.HasKey(e => e.Pk).HasName("PK_Reports_1");

            entity.ToTable("BI_Document", "rep");

            entity.Property(e => e.Pk).HasColumnName("PK");
            entity.Property(e => e.Abiid)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ABIID");
            entity.Property(e => e.BasePk).HasColumnName("BasePK");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatorLaborPk).HasColumnName("CreatorLaborPK");
            entity.Property(e => e.DeletedAt)
                .HasColumnType("datetime")
                .HasColumnName("deleted_at");
            entity.Property(e => e.Description).HasMaxLength(300);
            entity.Property(e => e.MasterPk).HasColumnName("MasterPK");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.ParentPk).HasColumnName("ParentPK");
            entity.Property(e => e.Type).HasComment("Report=1; Dashboard=2;");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatorLaborPk).HasColumnName("UpdatorLaborPK");
        });

        modelBuilder.Entity<BiDocumentCategory>(entity =>
        {
            entity.HasKey(e => e.Pk).HasName("PK_ReportCategories");

            entity.ToTable("BI_DocumentCategory", "rep");

            entity.Property(e => e.Pk).HasColumnName("PK");
            entity.Property(e => e.CategoryPk).HasColumnName("CategoryPK");
            entity.Property(e => e.DocumentPk).HasColumnName("DocumentPK");
        });

        modelBuilder.Entity<BiFilter>(entity =>
        {
            entity.HasKey(e => e.Pk).HasName("PK_Filters");

            entity.ToTable("BI_Filter", "rep");

            entity.Property(e => e.Pk).HasColumnName("PK");
            entity.Property(e => e.ApiToGet)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AvailableValuePk).HasColumnName("AvailableValuePK");
            entity.Property(e => e.CodeName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DisplayName).HasMaxLength(50);
            entity.Property(e => e.DocumentPk).HasColumnName("DocumentPK");
            entity.Property(e => e.FilterGroupPk).HasColumnName("FilterGroupPK");
            entity.Property(e => e.ShouldDisplayIfAnotherFilterPk).HasColumnName("ShouldDisplayIfAnotherFilterPK");
            entity.Property(e => e.ShouldDisplayIfAnotherFilterValue).HasMaxLength(100);
        });

        modelBuilder.Entity<BiFilterAvailableValue>(entity =>
        {
            entity.HasKey(e => e.Pk).HasName("PK_BI_FilterAvailableValues1");

            entity.ToTable("BI_FilterAvailableValues", "rep");

            entity.Property(e => e.Pk).HasColumnName("PK");
            entity.Property(e => e.LabelField).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.OrderBy)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SourceName).HasMaxLength(100);
            entity.Property(e => e.ValueField).HasMaxLength(50);
            entity.Property(e => e.ValueType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("INT");
        });

        modelBuilder.Entity<BiFilterGroup>(entity =>
        {
            entity.HasKey(e => e.Pk);

            entity.ToTable("BI_FilterGroup", "rep");

            entity.Property(e => e.Pk).HasColumnName("PK");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<BiFilterRelation>(entity =>
        {
            entity.HasKey(e => e.Pk);

            entity.ToTable("BI_FilterRelation", "rep");

            entity.Property(e => e.Pk).HasColumnName("PK");
            entity.Property(e => e.BaseFilterPk).HasColumnName("BaseFilterPK");
            entity.Property(e => e.Data).HasMaxLength(1000);
            entity.Property(e => e.Type)
                .HasMaxLength(4)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BiFilterStaticGroup>(entity =>
        {
            entity.HasKey(e => e.Pk);

            entity.ToTable("BI_FilterStaticGroup", "rep");

            entity.Property(e => e.Pk)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PK");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.ValueType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("INT");
        });

        modelBuilder.Entity<BiFilterStaticItem>(entity =>
        {
            entity.HasKey(e => e.Pk).HasName("PK_BI_FilterStaticValues");

            entity.ToTable("BI_FilterStaticItem", "rep");

            entity.Property(e => e.Pk).HasColumnName("PK");
            entity.Property(e => e.Label).HasMaxLength(100);
            entity.Property(e => e.StaticGroupPk)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("StaticGroupPK");
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<BiIndicator>(entity =>
        {
            entity.HasKey(e => e.Pk);

            entity.ToTable("BI_Indicators", "rep");

            entity.Property(e => e.Pk).HasColumnName("PK");
            entity.Property(e => e.AcceptLimit).HasColumnType("numeric(5, 3)");
            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID");
            entity.Property(e => e.IndicatorGroupPk)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("IndicatorGroupPK");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<BiIndicatorGroup>(entity =>
        {
            entity.HasKey(e => e.Pk);

            entity.ToTable("BI_IndicatorGroup", "rep");

            entity.Property(e => e.Pk).HasColumnName("PK");
            entity.Property(e => e.Name).HasMaxLength(150);
        });

        modelBuilder.Entity<BiSavedFilter>(entity =>
        {
            entity.HasKey(e => e.Pk).HasName("PK_SavedFilters");

            entity.ToTable("BI_SavedFilter", "rep");

            entity.Property(e => e.Pk).HasColumnName("PK");
            entity.Property(e => e.DocumentPk).HasColumnName("DocumentPK");
            entity.Property(e => e.LaborPk).HasColumnName("LaborPK");
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<BiSavedFilterValue>(entity =>
        {
            entity.HasKey(e => e.Pk).HasName("PK_SavedFilterValues");

            entity.ToTable("BI_SavedFilterValue", "rep");

            entity.Property(e => e.Pk).HasColumnName("PK");
            entity.Property(e => e.FilterPk).HasColumnName("FilterPK");
            entity.Property(e => e.SavedFilterPk).HasColumnName("SavedFilterPK");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
