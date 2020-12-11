using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DataLayer.Entities;
using DataLayer.Repositories;
using DataLayer.Services.Extensions;
using DataLayer.Service.Interfaces;
using DataLayer.Service.Interfaces.Models;
using DataLayer.Service.Interfaces.Models.AspNet;
using DataLayer.Service.Interfaces.Repository;
using DataLayer.Service.Models;
using DataLayer.Service.Models.AspNet;
using log4net;

namespace DataLayer.Service
{
    using Context;

    public partial class DLNarsServicePerDependency : IDLNarsServicePerDependency
    {
        /// <summary>
        /// Database connection class
        /// </summary>
        private readonly IDataLayerDbContext _dataLayerDbContext;

        /// <summary>
        /// AspNetUser
        /// /// </summary>
        private IDLAspNetUserRepository _dlAspNetUserRepository;

   

        #region Constructors
        /// <summary>
        ///  Parameter constructor which take the connection string to repository as input parameter
        /// </summary>
        /// <param name="connectionString"></param>
        public DLNarsServicePerDependency(string connectionString)
        {
            _dataLayerDbContext = new DataLayerDbContext(connectionString);
            _dlAspNetUserRepository = new DLAspNetUserRepository(_dataLayerDbContext);
        }
        #endregion

        #region IDLNarsServicePerDependency Implementation

     
        

        /// <summary>
        /// Verifies if login name is located in the repository
        /// </summary>
        /// <param name="loginName">Login name</param>
        /// <returns>True if login name is in repository</returns>
        public bool VerifyLoginName(string loginName)
        {
            return _dlAspNetUserRepository.GetById(loginName) != null;
        }


  


    
        #endregion
    }

    /// <summary>
    /// Nars data layer concrete service  dervived from <see cref="IDLNarsService"/>
    /// </summary>
    public partial class DLNarsService : DLService
        , IDLNarsService
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

        /// <summary>
        /// Logger interface
        /// </summary>
        private ILog _logger;

        #endregion

        #region Constructor

        public DLNarsService(IDataLayerDbContext dataLayerDbContext
                , IDLAspNetUserRepository dlAspNetUserRepository
            )
        {

            _dataLayerDbContext = dataLayerDbContext;
            _dlAspNetUserRepository = dlAspNetUserRepository;
            
        }
        #endregion
        #region DLGetNarsStatus Service

   
     

        /// <summary>
        /// Asynchronous Data layerNars data layer service which retrieves a task of  list of NarsStatusModels
        /// </summary>
        /// <param name="narsStatusInputModel"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>Task of List of NarsStatusModels</returns>
        public Task<IList<IDLNarsStatusModel>> DLGetNarsStatusAsync(IDLNarsStatusInputModel narsStatusInputModel
            , out string error
            ,CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        #endregion
















        #region IDLAspNetUserRepository

        /// <summary>
        /// Verifies if login name is located in the repository
        /// </summary>
        /// <param name="loginName">Login name</param>
        /// <returns>True if login name is in repository</returns>
        public bool VerifyLoginName(string loginName)
        {
            return _dlAspNetUserRepository.GetById(loginName) !=null;
        }

        #endregion

    }
}
