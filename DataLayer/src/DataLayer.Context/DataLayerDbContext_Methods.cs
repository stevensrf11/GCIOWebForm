using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Entities;
using DataLayer.Entities.Entity;

namespace DataLayer.Context
{
    public partial class DataLayerDbContext 
    {

        public async Task<List<Read_Only_GetNarsStatusModel>> Read_Only_GetNarsStatussAsync(System.Data.DataTable groupNames, System.Data.DataTable htrStatus,System.DateTimeOffset? issuedStartDateTime, System.DateTimeOffset? issuedEndDateTime, string teamCode, string subTeamCode)
        {
            var groupNamesParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Group_Names", SqlDbType = System.Data.SqlDbType.Structured, Direction = System.Data.ParameterDirection.Input, Value = groupNames, TypeName = "dbo.StringTable" };
            if (groupNamesParam.Value == null)
                groupNamesParam.Value = System.DBNull.Value;

            var htrStatusParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Htr_Status", SqlDbType = System.Data.SqlDbType.Structured, Direction = System.Data.ParameterDirection.Input, Value = htrStatus, TypeName = "dbo.StringTable" };
            if (htrStatusParam.Value == null)
                htrStatusParam.Value = System.DBNull.Value;

            var issuedStartDateTimeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Issued_Start_Date_Time", SqlDbType = System.Data.SqlDbType.DateTimeOffset, Direction = System.Data.ParameterDirection.Input, Value = issuedStartDateTime.GetValueOrDefault() };
            if (!issuedStartDateTime.HasValue)
                issuedStartDateTimeParam.Value = System.DBNull.Value;

            var issuedEndDateTimeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Issued_End_Date_Time", SqlDbType = System.Data.SqlDbType.DateTimeOffset, Direction = System.Data.ParameterDirection.Input, Value = issuedEndDateTime.GetValueOrDefault() };
            if (!issuedEndDateTime.HasValue)
                issuedEndDateTimeParam.Value = System.DBNull.Value;

            var teamCodeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Team_Code", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = teamCode, Size = 10 };
            if (teamCodeParam.Value == null)
                teamCodeParam.Value = System.DBNull.Value;

            var subTeamCodeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Sub_Team_Code", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = subTeamCode, Size = 10 };
            if (subTeamCodeParam.Value == null)
                subTeamCodeParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };


            var procResultData = await Database.SqlQuery<Read_Only_GetNarsStatusModel>("EXEC @procResult = [dbo].[get_nars_status] @Group_Names, @Htr_Status, @Issued_Start_Date_Time, @Issued_End_Date_Time, @Team_Code, @Sub_Team_Code", groupNamesParam, htrStatusParam, issuedStartDateTimeParam, issuedEndDateTimeParam, teamCodeParam, subTeamCodeParam, procResultParam).ToListAsync();
            Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, "EXEC @procResult = [dbo].[get_nars_status] @Group_Names, @Htr_Status, @Issued_Start_Date_Time, @Issued_End_Date_Time, @Team_Code, @Sub_Team_Code", groupNamesParam, htrStatusParam, issuedStartDateTimeParam, issuedEndDateTimeParam, teamCodeParam, subTeamCodeParam, procResultParam);

            return procResultData;
        }

        public List<Read_Only_GetNarsStatusModel> Read_Only_GetNarsStatuss(System.Data.DataTable groupNames, System.Data.DataTable htrStatus, System.DateTimeOffset? issuedStartDateTime, System.DateTimeOffset? issuedEndDateTime, string teamCode, string subTeamCode, out int procResult)
        {
            var groupNamesParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Group_Names", SqlDbType = System.Data.SqlDbType.Structured, Direction = System.Data.ParameterDirection.Input, Value = groupNames, TypeName = "dbo.StringTable" };
            if (groupNamesParam.Value == null)
                groupNamesParam.Value = System.DBNull.Value;

            var htrStatusParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Htr_Status", SqlDbType = System.Data.SqlDbType.Structured, Direction = System.Data.ParameterDirection.Input, Value = htrStatus, TypeName = "dbo.StringTable" };
            if (htrStatusParam.Value == null)
                htrStatusParam.Value = System.DBNull.Value;

            var issuedStartDateTimeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Issued_Start_Date_Time", SqlDbType = System.Data.SqlDbType.DateTimeOffset, Direction = System.Data.ParameterDirection.Input, Value = issuedStartDateTime.GetValueOrDefault() };
            if (!issuedStartDateTime.HasValue)
                issuedStartDateTimeParam.Value = System.DBNull.Value;

            var issuedEndDateTimeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Issued_End_Date_Time", SqlDbType = System.Data.SqlDbType.DateTimeOffset, Direction = System.Data.ParameterDirection.Input, Value = issuedEndDateTime.GetValueOrDefault() };
            if (!issuedEndDateTime.HasValue)
                issuedEndDateTimeParam.Value = System.DBNull.Value;

            var teamCodeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Team_Code", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = teamCode, Size = 10 };
            if (teamCodeParam.Value == null)
                teamCodeParam.Value = System.DBNull.Value;

            var subTeamCodeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Sub_Team_Code", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = subTeamCode, Size = 10 };
            if (subTeamCodeParam.Value == null)
                subTeamCodeParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };

            var procResultData = Database.SqlQuery<Read_Only_GetNarsStatusModel>("EXEC @procResult = [dbo].[get_nars_status] @Group_Names, @Htr_Status, @Issued_Start_Date_Time, @Issued_End_Date_Time, @Team_Code, @Sub_Team_Code", groupNamesParam, htrStatusParam, issuedStartDateTimeParam, issuedEndDateTimeParam, teamCodeParam, subTeamCodeParam, procResultParam).ToList(); ;

            procResult = (int)procResultParam.Value;
            return procResultData;
        }


        public List<WrapperGetNarsStatusReturnModel> WrapperGetNarsStatus(System.Data.DataTable groupNames, System.Data.DataTable htrStatus, System.DateTimeOffset? issuedStartDateTime, System.DateTimeOffset? issuedEndDateTime, string teamCode, string subTeamCode)
        {
            int procResult;
            return WrapperGetNarsStatus(groupNames, htrStatus, issuedStartDateTime, issuedEndDateTime, teamCode, subTeamCode, out procResult);
        }

        public List<WrapperGetNarsStatusReturnModel> WrapperGetNarsStatus(System.Data.DataTable groupNames, System.Data.DataTable htrStatus, System.DateTimeOffset? issuedStartDateTime, System.DateTimeOffset? issuedEndDateTime, string teamCode, string subTeamCode, out int procResult)
        {
            var groupNamesParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Group_Names", SqlDbType = System.Data.SqlDbType.Structured, Direction = System.Data.ParameterDirection.Input, Value = groupNames, TypeName = "dbo.StringTable" };
            if (groupNamesParam.Value == null)
                groupNamesParam.Value = System.DBNull.Value;

            var htrStatusParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Htr_Status", SqlDbType = System.Data.SqlDbType.Structured, Direction = System.Data.ParameterDirection.Input, Value = htrStatus, TypeName = "dbo.StringTable" };
            if (htrStatusParam.Value == null)
                htrStatusParam.Value = System.DBNull.Value;

            var issuedStartDateTimeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Issued_Start_Date_Time", SqlDbType = System.Data.SqlDbType.DateTimeOffset, Direction = System.Data.ParameterDirection.Input, Value = issuedStartDateTime.GetValueOrDefault() };
            if (!issuedStartDateTime.HasValue)
                issuedStartDateTimeParam.Value = System.DBNull.Value;

            var issuedEndDateTimeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Issued_End_Date_Time", SqlDbType = System.Data.SqlDbType.DateTimeOffset, Direction = System.Data.ParameterDirection.Input, Value = issuedEndDateTime.GetValueOrDefault() };
            if (!issuedEndDateTime.HasValue)
                issuedEndDateTimeParam.Value = System.DBNull.Value;

            var teamCodeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Team_Code", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = teamCode, Size = 10 };
            if (teamCodeParam.Value == null)
                teamCodeParam.Value = System.DBNull.Value;

            var subTeamCodeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Sub_Team_Code", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = subTeamCode, Size = 10 };
            if (subTeamCodeParam.Value == null)
                subTeamCodeParam.Value = System.DBNull.Value;

            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<WrapperGetNarsStatusReturnModel>("EXEC @procResult = [dbo].[get_nars_status] @Group_Names, @Htr_Status, @Issued_Start_Date_Time, @Issued_End_Date_Time, @Team_Code, @Sub_Team_Code", groupNamesParam, htrStatusParam, issuedStartDateTimeParam, issuedEndDateTimeParam, teamCodeParam, subTeamCodeParam, procResultParam).ToList();

            procResult = (int)procResultParam.Value;
            return procResultData;
        }
/*
        public async System.Threading.Tasks.Task<System.Collections.Generic.List<GetNarsStatusReturnModel>> GetNarsStatusAsync(System.Data.DataTable groupNames, System.Data.DataTable htrStatus, System.DateTimeOffset? issuedStartDateTime, System.DateTimeOffset? issuedEndDateTime, string teamCode, string subTeamCode)
        {
            var groupNamesParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Group_Names", SqlDbType = System.Data.SqlDbType.Structured, Direction = System.Data.ParameterDirection.Input, Value = groupNames, TypeName = "dbo.StringTable" };
            if (groupNamesParam.Value == null)
                groupNamesParam.Value = System.DBNull.Value;

            var htrStatusParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Htr_Status", SqlDbType = System.Data.SqlDbType.Structured, Direction = System.Data.ParameterDirection.Input, Value = htrStatus, TypeName = "dbo.StringTable" };
            if (htrStatusParam.Value == null)
                htrStatusParam.Value = System.DBNull.Value;

            var issuedStartDateTimeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Issued_Start_Date_Time", SqlDbType = System.Data.SqlDbType.DateTimeOffset, Direction = System.Data.ParameterDirection.Input, Value = issuedStartDateTime.GetValueOrDefault() };
            if (!issuedStartDateTime.HasValue)
                issuedStartDateTimeParam.Value = System.DBNull.Value;

            var issuedEndDateTimeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Issued_End_Date_Time", SqlDbType = System.Data.SqlDbType.DateTimeOffset, Direction = System.Data.ParameterDirection.Input, Value = issuedEndDateTime.GetValueOrDefault() };
            if (!issuedEndDateTime.HasValue)
                issuedEndDateTimeParam.Value = System.DBNull.Value;

            var teamCodeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Team_Code", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = teamCode, Size = 10 };
            if (teamCodeParam.Value == null)
                teamCodeParam.Value = System.DBNull.Value;

            var subTeamCodeParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@Sub_Team_Code", SqlDbType = System.Data.SqlDbType.VarChar, Direction = System.Data.ParameterDirection.Input, Value = subTeamCode, Size = 10 };
            if (subTeamCodeParam.Value == null)
                subTeamCodeParam.Value = System.DBNull.Value;

            var procResultData = await Database.SqlQuery<GetNarsStatusReturnModel>("EXEC [dbo].[get_nars_status] @Group_Names, @Htr_Status, @Issued_Start_Date_Time, @Issued_End_Date_Time, @Team_Code, @Sub_Team_Code", groupNamesParam, htrStatusParam, issuedStartDateTimeParam, issuedEndDateTimeParam, teamCodeParam, subTeamCodeParam).ToListAsync();

            return procResultData;
        }

    */

    }
}
