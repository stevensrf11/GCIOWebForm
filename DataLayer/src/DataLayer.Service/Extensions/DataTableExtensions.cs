using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Services.Extensions
{
    /// <summary>
    /// Datatable extension to create input table to be used in stored procedure
    /// </summary>
    internal static class DataTableExtensions
    {
        /// <summary>
        /// Create a string and timestamp column table.
        /// The T parameter is a class when a property name StringValue which is the name of the column,
        /// </summary>
        /// <typeparam name="T"> Class with a property Name StringValue of type sting </typeparam>
        /// <param name="dt">Datatable which is populated with information</param>
        /// <param name="infos"> List of classes which populates datatable with information.
        /// A class must have  a string property named StringValue</param>
        internal static void StringTable<T>(this DataTable dt, IList<T> infos) where T: class
        {
            
            var col = new DataColumn { ColumnName = "StringValue", AllowDBNull = false, DataType = typeof(String) };
            dt.Columns.Add(col);

            col = new DataColumn { ColumnName = "Ts", AllowDBNull = true, DataType = typeof(byte[]) };
            dt.Columns.Add(col);


            foreach (var info in infos)
            {
                var tp = info.GetType();
                var prop = tp.GetProperty("StringValue");
                if (prop == null) continue;
                var val = prop.GetValue(info,null);
                if (val is string s)
                {
                    var row = dt.NewRow();
                    row["StringValue"] = s;
                    dt.Rows.Add(row);
                }
            }// end foreach 
        }// end property
    }
}
