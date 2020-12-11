using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Service.Interfaces.Models;

namespace DataLayer.Service.Interfaces
{
    public interface IDLToDoItemService :IDLService
    {
        /// <summary>
        /// DeleteToDoItems interface service
        /// Used to delete a ToDoItem from the resposity based on an id
        /// </summary>
        /// <param name="toDoItemId">Id</param>
        /// <param name="error">Out parameter to indicate if there was an error</param>
        /// <returns>Number of records deleted or negative number</returns>
        int DeleteToDoItems(long? toDoItemId, out string error);

        /// <summary>
        /// InsertoDoItems  service
        /// Used to insert a ToDoItem into repositry
        /// </summary>
        /// <param name="iDLToDoItemsInputModel">Information to  insert</param>
        /// <param name="error">Out parameter to indicate if there was an error</param>
        /// <returns>Number of records inserted or negative number</returns>
        int InsertoDoItems(IDLToDoItemsInputModel iDLToDoItemsInputModel, out string error);

        /// <summary>
        /// UpdatetoDoItems  service
        /// Used to update a ToDoItem into repository based on an id
        /// </summary>
        /// <param name="iDLToDoItemsInputModel">Information to  update</param>
        /// <param name="error">Out updated to indicate if there was an error</param>
        /// <returns>Number of records inserted or negative number</returns>
        int UpdatetoDoItems(IDLToDoItemsInputModel iDLToDoItemsInputModel, out string error);

        /// <summary>
        /// SelecttoDoItems  service
        /// Used to select all the ToDoItem items fro  theo repository
        /// </summary>
        /// <param name="error">Out updated to indicate if there was an error</param>
        /// <returns>Number of records inserted or negative number</returns>
        IList<IDLToDoItemsReturnModel> SelecttoDoItems( out string error);

    }
}
