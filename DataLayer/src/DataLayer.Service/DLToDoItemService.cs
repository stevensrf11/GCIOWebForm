using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Repositories;
using DataLayer.Service.Interfaces;
using DataLayer.Service.Interfaces.Models;
using DataLayer.Service.Interfaces.Repository;
using DataLayer.Service.Models;

namespace DataLayer.Service
{
    public class DLToDoItemService :DLService
        , IDLToDoItemService
    {
        #region Fields

        /// <summary>
        /// Asp Net User entity repository interface
        /// </summary>

        private IDLAspNetUserRepository _dlAspNetUserRepository;

        /// <summary>
        /// Repository  context interface
        /// </summary>
        private IDataLayerDbContext _dataLayerDbContext;

        #endregion

        #region Constructor

        public DLToDoItemService(IDataLayerDbContext dataLayerDbContext
                , IDLAspNetUserRepository dlAspNetUserRepository
            )
        {

            _dataLayerDbContext = dataLayerDbContext;
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
                    var ret = _dataLayerDbContext.DeleteToDoItems(toDoItemId);
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
        public int InsertoDoItems(IDLToDoItemsInputModel iDLToDoItemsInputModel, out string error)
        {
            try
            {

                if (!iDLToDoItemsInputModel.ToDoItemId.HasValue || iDLToDoItemsInputModel.ToDoItemId.Value < 0)
                {
                    throw new System.ArgumentException("To do item id must have a value and it has to be zero or greater");
                }
               else if (!iDLToDoItemsInputModel.ToDoItemStrikeThrough.HasValue )
                {
                    throw new System.ArgumentException("To do iten strike thrugh must have a value ");
                }
                else
                {
                    var ret = _dataLayerDbContext.InsertToDoItems(iDLToDoItemsInputModel.ToDoItemId
                        , iDLToDoItemsInputModel.ToDoItem
                        ,iDLToDoItemsInputModel.ToDoItemStrikeThrough);
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
        public int UpdatetoDoItems(IDLToDoItemsInputModel iDLToDoItemsInputModel, out string error)
        {
            try
            {

                if (!iDLToDoItemsInputModel.ToDoItemId.HasValue || iDLToDoItemsInputModel.ToDoItemId.Value < 0)
                {
                    throw new System.ArgumentException("To do item id must have a value and it has to be zero or greater");
                }
                else if (!iDLToDoItemsInputModel.ToDoItemStrikeThrough.HasValue)
                {
                    throw new System.ArgumentException("To do iten strike thrugh must have a value ");
                }
                else
                {
                    var ret = _dataLayerDbContext.UpdateToDoItems(iDLToDoItemsInputModel.ToDoItemId
                        , iDLToDoItemsInputModel.ToDoItem
                        , iDLToDoItemsInputModel.ToDoItemStrikeThrough);
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
        public IList<IDLToDoItemsReturnModel> SelecttoDoItems(out string error)
        {
            var retItems = new List<IDLToDoItemsReturnModel>();
            try
            {

  
                    var rets = _dataLayerDbContext.SelectToDoItems();
                    foreach(var ret in rets)
                    {
                        var retItem = new DLToDoItemsReturnModel
                        {
                            ToDoItem = ret.ToDoItem,
                            ToDoItemId = ret.ToDoItemId,
                            ToDoItemStrikeThrough = ret.ToDoStrikeThrough

                        };
                        retItems.Add(retItem);
                    }
                    error = string.Empty;
                    return retItems;
                
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return retItems;
        }
    }
}
