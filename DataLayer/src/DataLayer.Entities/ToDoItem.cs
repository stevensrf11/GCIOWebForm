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


namespace DataLayer.Entities
{

    // ToDoItems
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.4.0")]
    public partial class ToDoItem
    {
        public long ToDoItemId { get; set; } // ToDoItemId (Primary key)
        public string ToDoItem_ { get; set; } // ToDoItem (length: 256)
        public bool ToDoStrikeThrough { get; set; } // ToDoStrikeThrough

        public ToDoItem()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>