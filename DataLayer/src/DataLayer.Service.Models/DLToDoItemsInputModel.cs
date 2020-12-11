using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Service.Interfaces.Models;
namespace DataLayer.Service.Models
{
    /// <summary>
    /// DLToDoItenInputModel input model class derived from the class<see cref="DLModel"/>
    /// , and the interface <seealso cref="IDLToDoItemsInputModel"/>
    /// Used as input model forTodoItems
    /// </summary>
    public class DLToDoItemsInputModel :DLModel
        , IDLToDoItemsInputModel
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
