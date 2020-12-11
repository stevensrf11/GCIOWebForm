using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DataLayer.Entities;
using DataLayer.Service.Interfaces.Models;
using DataLayer.Service.Interfaces.Models.AspNet;

namespace DataLayer.Service.Interfaces
{
    /// <summary>
    /// Datalayer service per scope lifetime.
    /// Used to communicate with repository when not in a http request
    /// </summary>
    public interface IDLNarsServicePerDependency : IDLService
    {
        /// <summary>
        /// Verifies if login name is registered in repository 
        /// </summary>
        /// <param name="loginName">login name</param>
        /// <returns>True is login name registered in repository</returns>
        bool VerifyLoginName(string loginName);

  
    }
   public interface IDLNarsService : IDLService
   {


        #region IDLAspNetUserRepository
        /// <summary>
        /// Verifies if login name is located in the repository
        /// </summary>
        /// <param name="loginName">Login name</param>
        /// <returns>True if login name is in repository</returns>
        bool VerifyLoginName(string loginName);
        #endregion
    }
}

