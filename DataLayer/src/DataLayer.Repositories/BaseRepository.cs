using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public abstract class BaseRepository<T> : IDisposable
    {
        #region Fields
        private IDataLayerDbContext _dataLayerDbContext;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRepository"/> class.
        /// </summary>
        /// <param name="dataLayerDbContext">Data layer DBContext</param>
        public BaseRepository(IDataLayerDbContext dataLayerDbContext)
        {

            DataLayerDbContext = dataLayerDbContext;
        }
        #endregion

        #region Accessor Properties
        /// <summary>
        /// Gets or sets the Data layer DBContext.
        /// </summary>
        protected IDataLayerDbContext DataLayerDbContext
        {
            get => _dataLayerDbContext;
            private set => _dataLayerDbContext = value;
        }
        #endregion

        #region IDisposable Methods
        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            if (DataLayerDbContext != null)
                GC.SuppressFinalize(DataLayerDbContext);

        }
        #endregion
    }

}
