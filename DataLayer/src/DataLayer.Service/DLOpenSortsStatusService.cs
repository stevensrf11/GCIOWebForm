using System.Collections.Generic;
using System.Data;
using System.Linq;
using DataLayer.Repositories;
using DataLayer.Service.Interfaces;
using DataLayer.Service.Interfaces.Models;
using DataLayer.Service.Models;
using DataLayer.Services.Extensions;
using log4net;

namespace DataLayer.Service
{
    /// <summary>
    /// Open sort status data layer  service derived from the interface <see cref="IDLOpenSortsStatusService"/> 
    /// </summary>
    public class DLOpenSortsStatusService : DLService
        ,IDLOpenSortsStatusService
    {

        #region Fields
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
        /// <summary>
        /// Parameter constructor with parameter injected
        /// </summary>
        /// <param name="dataLayerDbContext">Interface to the repository context</param>
        /// <param name="logManager"> Logger interface</param>
        public DLOpenSortsStatusService(IDataLayerDbContext dataLayerDbContext
            )
        {

            _dataLayerDbContext = dataLayerDbContext;
            
        }
        #endregion
    }
}
