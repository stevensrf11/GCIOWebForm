// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.7
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace DataLayer.Maps
{
    using DataLayer.Entities;

    // ToDoItems
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public partial class ToDoItemConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<ToDoItem>
    {
        public ToDoItemConfiguration()
            : this("dbo")
        {
        }

        public ToDoItemConfiguration(string schema)
        {
            ToTable("ToDoItems", schema);
            HasKey(x => x.ToDoItemId);

            Property(x => x.ToDoItemId).HasColumnName(@"ToDoItemId").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.ToDoItem_).HasColumnName(@"ToDoItem").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(256);
            Property(x => x.ToDoStrikeThrough).HasColumnName(@"ToDoStrikeThrough").HasColumnType("bit").IsRequired();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
