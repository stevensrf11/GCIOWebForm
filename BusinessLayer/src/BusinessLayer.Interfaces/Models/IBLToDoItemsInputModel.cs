namespace BusinessLayer.Interfaces.Models
{
    /// <summary>
    /// IBLToDoItemsInputModel input model interface derived from <see cref="IBLModel"/>
    /// Used as input model forTodoItems
    /// </summary>
    public interface IBLToDoItemsInputModel : IBLModel
    {
        #region Accessors
        /// <summary>
        /// ToDoItemId set/get accwssor
        /// Idenitifies the to do item idetification
        /// </summary>
        /// <value> Nullable long</value>
        long? ToDoItemId { get; set; }

        /// <summary>
        /// ToDoItem set/get accwssor
        /// Idenitifies the to do item value
        /// </summary>
        /// <value> string</value>
       string ToDoItem { get; set; }

        /// <summary>
        /// ToDoItemStrikeThrough set/get accwssor
        /// Idenitifies the to do item is set
        /// </summary>
        /// <value> Nullable boolean</value>
        bool? ToDoItemStrikeThrough { get; set; }

        #endregion
    }
}
