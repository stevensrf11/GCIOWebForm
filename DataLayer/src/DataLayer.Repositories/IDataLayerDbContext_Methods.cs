using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;
using DataLayer.Entities.Entity;

namespace DataLayer.Repositories
{
    public partial interface IDataLayerDbContext
    {

        System.Collections.Generic.List<Read_Only_GetNarsStatusModel> Read_Only_GetNarsStatuss(
            System.Data.DataTable groupNames
            , System.Data.DataTable htrStatus
            , System.DateTimeOffset? issuedStartDateTime
            , System.DateTimeOffset? issuedEndDateTime
            , string teamCode
            , string subTeamCode
            , out int result);


        Task<List<Read_Only_GetNarsStatusModel>>
            Read_Only_GetNarsStatussAsync(
                System.Data.DataTable groupNames
                , System.Data.DataTable htrStatus
                , DateTimeOffset? issuedStartDateTime
                , DateTimeOffset? issuedEndDateTime
                , string teamCode
                , string subTeamCode);



        List<WrapperGetNarsStatusReturnModel> WrapperGetNarsStatus(
            System.Data.DataTable groupNames
            , System.Data.DataTable htrStatus,
            DateTimeOffset? issuedStartDateTime
            , DateTimeOffset? issuedEndDateTime
            , string teamCode,
            string subTeamCode);


        List<WrapperGetNarsStatusReturnModel> WrapperGetNarsStatus(
             System.Data.DataTable groupNames
             , System.Data.DataTable htrStatus
             ,DateTimeOffset? issuedStartDateTime
             , DateTimeOffset? issuedEndDateTime
             , string teamCode
             , string subTeamCode
             , out int procResult);


    }
}
