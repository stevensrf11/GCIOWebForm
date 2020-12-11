using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;

namespace DataLayer.Service.Interfaces.Repository
{

    /// <summary>
    ///  Data layer AspNetRepository interface  derived from  <see cref="IDLCommandRepository<DLAspNetRepository>"/><see cref="IDLCommandRepository<DLAspNetRepository>"/>,
    /// <se ealso cref="IDLQueryRepository<DLAspNetRepoitory>"/> interface templates using the <seealso cref="AspNetUserEntity"/>
    ///  Used as the aspnet user information repository interface
    /// </summary>
    public interface IDLAspNetUserRepository : IDLCommandRepository<asp_AspNetUser>
        , IDLQueryRepository<asp_AspNetUser>
    {
    }
}
