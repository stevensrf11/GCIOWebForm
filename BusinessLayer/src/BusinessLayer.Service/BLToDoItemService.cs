using BusinessLayer.Interfaces.Models;
using BusinessLayer.Interfaces.Services;
using BusinessLayer.Models;
using DataLayer.Service.Interfaces;
using DataLayer.Service.Interfaces.Repository;
using DataLayer.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.Service
{
    public class BDLToDoItemService :BLService
        , IBLToDoItemService
    {
        #region Fields

        /// <summary>
        /// Asp Net User entity repository interface
        /// </summary>

        private IDLAspNetUserRepository _dlAspNetUserRepository;

        /// <summary>
        /// Repository  context interface
        /// </summary>
        private IDLToDoItemService _dLToDoItemService;

        #endregion

        #region Constructor

        public BDLToDoItemService(IDLToDoItemService dLToDoItemService
                , IDLAspNetUserRepository dlAspNetUserRepository
            )
        {

            _dLToDoItemService = dLToDoItemService;
            _dlAspNetUserRepository = dlAspNetUserRepository;

        }
        #endregion
        /// <summary>
        /// DeleteToDoItems  service
        /// Used to delete a ToDoItem from the resposity based on an id
        /// </summary>
        /// <param name="toDoItemId">Identification of to do item to delete</param>
        /// <param name="error">Out parameter to indicate if thee was and error</param>
        /// <returns>Number of records deleted or hegative number</returns>
        public int DeleteToDoItems(long? toDoItemId, out string error)
        {
            try
            {
                if (!toDoItemId.HasValue || toDoItemId.Value <0)
                {
                    throw new System.ArgumentException("To do item id must have a value and it has to be zero or greater");
                }
                else
                {
                    var ret = _dLToDoItemService.DeleteToDoItems(toDoItemId,out error);
                    error = string.Empty;
                    return ret;
                }
            }
            catch ( Exception ex)
            {
                error = ex.Message;
            }
            return -999;
        }


        /// <summary>
        /// InsertoDoItems  service
        /// Used to insert a ToDoItem into repositry
        /// </summary>
        /// <param name="iDLToDoItemsInputModel">Information to  insert</param>
        /// <param name="error">Out parameter to indicate if there was an error</param>
        /// <returns>Number of records inserted or negative number</returns>
        public int InsertoDoItems(IBLToDoItemsInputModel iBLToDoItemsInputModel, out string error)
        {
            try
            {

                if (!iBLToDoItemsInputModel.ToDoItemId.HasValue || iBLToDoItemsInputModel.ToDoItemId.Value < 0)
                {
                    throw new System.ArgumentException("To do item id must have a value and it has to be zero or greater");
                }
               else if (!iBLToDoItemsInputModel.ToDoItemStrikeThrough.HasValue )
                {
                    throw new System.ArgumentException("To do iten strike thrugh must have a value ");
                }
                else
                {

                    var ret = _dLToDoItemService.InsertoDoItems(new DLToDoItemsInputModel
                    {
                        ToDoItem= iBLToDoItemsInputModel.ToDoItem,
                        ToDoItemId= iBLToDoItemsInputModel.ToDoItemId,
                        ToDoItemStrikeThrough= iBLToDoItemsInputModel.ToDoItemStrikeThrough
                    },out error);
                    error = string.Empty;
                    return ret;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return -999;
        }
        /// <summary>
        /// UpdatetoDoItems  service
        /// Used to update a ToDoItem into repository based on an id
        /// </summary>
        /// <param name="iDLToDoItemsInputModel">Information to  update</param>
        /// <param name="error">Out updated to indicate if there was an error</param>
        /// <returns>Number of records inserted or negative number</returns>
        public int UpdatetoDoItems(IBLToDoItemsInputModel ibLToDoItemsInputModel, out string error)
        {
            try
            {

                if (!ibLToDoItemsInputModel.ToDoItemId.HasValue || ibLToDoItemsInputModel.ToDoItemId.Value < 0)
                {
                    throw new System.ArgumentException("To do item id must have a value and it has to be zero or greater");
                }
                else if (!ibLToDoItemsInputModel.ToDoItemStrikeThrough.HasValue)
                {
                    throw new System.ArgumentException("To do iten strike thrugh must have a value ");
                }
                else
                {
                    var ret = _dLToDoItemService.UpdatetoDoItems(new DLToDoItemsInputModel
                    {
                        ToDoItem = ibLToDoItemsInputModel.ToDoItem,
                        ToDoItemId = ibLToDoItemsInputModel.ToDoItemId,
                        ToDoItemStrikeThrough = ibLToDoItemsInputModel.ToDoItemStrikeThrough
                    }, out error);
                    error = string.Empty;
                    return ret;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return -999;
        }


        /// <summary>
        /// SelecttoDoItems  service
        /// Used to select all the ToDoItem items fro  theo repository
        /// </summary>
        /// <param name="error">Out updated to indicate if there was an error</param>
        /// <returns>Number of records inserted or negative number</returns>
        public IList<IBLToDoItemsReturnModel> SelecttoDoItems(out string error)
        {
            var retItems = new List<IBLToDoItemsReturnModel>();
            var rets = _dLToDoItemService.SelecttoDoItems(out error);
            if(rets.Any())
            {
                foreach(var ret in rets)
                {
                    retItems.Add(new BLToDoItemsReturnModel
                    {
                        ToDoItem = ret.ToDoItem,
                        ToDoItemId = ret.ToDoItemId,
                        ToDoItemStrikeThrough = ret.ToDoItemStrikeThrough
                    }
                    );
                }
            }
            return retItems;
        }
    }
}
