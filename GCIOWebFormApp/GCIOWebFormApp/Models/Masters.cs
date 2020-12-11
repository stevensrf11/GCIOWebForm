using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace GCIOWebFormApp.Models
{
    public class Masters
    {
        public DataTable GetChecklistModeList()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ToDoItemId", typeof(int));
            table.Columns.Add("ToDoItem", typeof(string));
            table.Columns.Add("ToDoItemStrikeThough", typeof(bool));

            //DataRow newRow = table.NewRow();

            //newRow["ToDoItemId"] =  1;
            //newRow["ToDoItem"] = "ToDoItem";
            //newRow["ToDoItemStrikeThough"] = false;
            //table.Rows.Add(newRow);

            DataColumn[] keyColumns = new DataColumn[1];
            keyColumns[0] = table.Columns["ToDoItemId"];
            table.PrimaryKey = keyColumns;

            table.PrimaryKey = keyColumns;

           

            return table;
        }
    }
}