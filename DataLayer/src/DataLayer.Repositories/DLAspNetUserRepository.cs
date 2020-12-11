using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;
using DataLayer.Service.Interfaces.Repository;

namespace DataLayer.Repositories
{
  
    public class DLAspNetUserRepository : BaseRepository<asp_AspNetUser>,
        IDLAspNetUserRepository
    {
        #region Fields
        /// <summary>
        /// Database context connection
        /// </summary>
        private IDataLayerDbContext _dataLayerDbContext;

        /// <summary>
        /// AspNetUser entity set
        /// </summary>
        private  DbSet<asp_AspNetUser> dbSet;
        #endregion


        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerRepository"/> class.
        /// Used to set database connection  and   AspNetuser set references
        /// </summary>
        /// <param name="databaseFactory">The database factory.</param>
        public DLAspNetUserRepository(IDataLayerDbContext dataLayerDbContext)
            : base(dataLayerDbContext)
        {
            DataLayerDbContext.Database.CommandTimeout = 300;
            dbSet = dataLayerDbContext.Set<asp_AspNetUser>();


        }
#endregion

        #region ICommanRepository<asp_AspNetUser> Members




        public asp_AspNetUser GetById(long id)
        {
            throw new NotImplementedException();
        }

        public asp_AspNetUser Add(asp_AspNetUser entity)
        {
            throw new NotImplementedException();
        }

        public void Update(asp_AspNetUser entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(asp_AspNetUser entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds the given entity to the context underlying the set in the Added state 
        /// such that it will be inserted into the database when SaveChanges is called.
        /// </summary>
        /// <param name="entity">Entity to add</param>
        /// <returns>Entity added</returns>

      


        public void Delete(long id)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Saves all changes made in this context to the underlying database
        /// </summary>
        /// <returns>
        ///  Number of records saved to repository
        /// </returns>
        /// <exception cref="DbUpdateException">
        /// An error occurred sending updates to the database.
        /// </exception>
        /// <exception cref="DbUpdateConcurrencyException ">
        /// A database command did not affect the expected number of rows. 
        /// This usually indicates an optimistic concurrency violation; 
        /// that is, a row has been changed in the database since it was queried.
        /// </exception>
        /// <exception cref="DbEntityValidationException">
        /// The save was aborted because validation of entity property values failed.
        /// </exception>
        /// <exception cref="System.NotSupportedException">
        /// An attempt was made to use unsupported behavior such as 
        /// executing multiple asynchronous commands concurrently on the same context instance.
        /// </exception>
        /// <exception cref="System.ObjectDisposedException">
        /// The context or connection have been disposed.
        /// </exception>
        /// <exception cref="System.InvalidOperationException">
        /// Some error occurred attempting to process entities 
        /// in the context either before or after sending commands to the database.
        /// </exception>

        public virtual int SaveChanges()
        {
            var result = 0;
            //try
            //{
            if (DataLayerDbContext != null)
            {
                result = DataLayerDbContext.SaveChanges();
            }
            //}
            //catch(Exception ex)
            //{
            //    // log
            //    result = -1;
            //}
            return result;
        }
        #endregion

        #region IQueryRepository<asp_AspNetUser> Members



        #endregion

        #region IDLAspNetUserRepository

        #endregion

        public IQueryable<asp_AspNetUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<asp_AspNetUser> Get(Func<asp_AspNetUser, bool> @where)
        {
           return  dbSet.Where(where).AsQueryable();
        }

        public asp_AspNetUser GetUser(Func<asp_AspNetUser, bool> @where)
        {
            return dbSet.Where(where).FirstOrDefault();
        }
        public IQueryable<asp_AspNetUser> GetQuery()
        {
            throw new NotImplementedException();
        }

        public asp_AspNetUser GetById(string id)
        {
            throw new NotImplementedException();
        }
    }

}
