using BusinessLayer.Interfaces.Models;
namespace BusinessLayer.Models
{
    /// <summary>
    /// DLToDoItenInputModel input model class derived from the class<see cref="DLModel"/>
    /// , and the interface <seealso cref="IDLToDoItemsInputModel"/>
    /// Used as input model forTodoItems
    /// </summary>
    public class BLToDoItemsInputModel :BLModel
        , IBLToDoItemsInputModel
    {
        #region Accessors
        /// <summary>
        /// ToDoItemId set/get accwssor
        /// Idenitifies the to do item idetification
        /// </summary>
        /// <value> Nullable long</value>
        public long? ToDoItemId { get; set; }

        /// <summary>
        /// ToDoItem set/get accwssor
        /// Idenitifies the to do item value
        /// </summary>
        /// <value> string</value>
        public string ToDoItem { get; set; }

        /// <summary>
        /// ToDoItemStrikeThrough set/get accwssor
        /// Idenitifies the to do item is set
        /// </summary>
        /// <value> Nullable boolean</value>
        public bool? ToDoItemStrikeThrough { get; set; }

        #endregion

    }
}
