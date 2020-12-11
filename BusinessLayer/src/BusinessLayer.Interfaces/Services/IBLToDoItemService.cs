using System.Collections.Generic;
using BusinessLayer.Interfaces.Models;

namespace BusinessLayer.Interfaces.Services
{
    public interface IBLToDoItemService : IBLService
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
        int InsertoDoItems(IBLToDoItemsInputModel iBLToDoItemsInputModel, out string error);

        /// <summary>
        /// UpdatetoDoItems  service
        /// Used to update a ToDoItem into repository based on an id
        /// </summary>
        /// <param name="iDLToDoItemsInputModel">Information to  update</param>
        /// <param name="error">Out updated to indicate if there was an error</param>
        /// <returns>Number of records inserted or negative number</returns>
        int UpdatetoDoItems(IBLToDoItemsInputModel iBLToDoItemsInputModel, out string error);


        /// <summary>
        /// SelecttoDoItems  service
        /// Used to select all the ToDoItem items fro  theo repository
        /// </summary>
        /// <param name="error">Out updated to indicate if there was an error</param>
        /// <returns>Number of records inserted or negative number</returns>
        IList<IBLToDoItemsReturnModel> SelecttoDoItems(out string error);

    }
}
