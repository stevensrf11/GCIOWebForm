using System;
using System.Web.UI;
using DevExpress.Web;
using GCIOWebFormApp.Models;
using System.Data;
using BusinessLayer.Interfaces.Services;
using BusinessLayer.Models;

namespace GCIOWebFormApp
{
    public partial class _Default : Page
    {
        #region Fields
        private IBLToDoItemService _iBLToDoItemService;
        #endregion

        #region Constructor
        // Uncomment when interfaces are registered fo DI
        //public _Default(IBLToDoItemService iBLToDoItemService)
        //{
        //    _iBLToDoItemService = iBLToDoItemService;
        //}

        #endregion
        #region Accessors

        /// <summary>
        ///  SessionChecklistModeData Get/Set Accessor
        ///  Stores a datatable in a session variable
        ///  Used as soruce for biding to gridview
        /// </summary>
        public DataTable SessionChecklistModeData
        {
            get
            {
                if (Session["ChecklistModeData"] != null)
                {
                    return (DataTable)Session["ChecklistModeData"];
                }
                else
                {
                    return new DataTable();
                }
            }
            set
            {
                Session["ChecklistModeData"] = value;
            }
        }

        /// <summary>
        ///  SelectedChecklistModeID Get/Set Accessor
        ///  Stores a that next primary key to use in a datatable's row 
        ///  Used as soruce for biding to gridview
        /// </summary>
        public Int64 SelectedChecklistModeID
        {
            get
            {
                if (Session["SelectedChecklistModeID"] != null)
                {
                    return (Int64)Session["SelectedChecklistModeID"];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                Session["SelectedChecklistModeID"] = value;
            }
        }
        #endregion

        #region Event Handlers
       
        #region Page Event Handlers
        /// <summary>
        /// Page load event handler
        /// Used to intialize datatable, and bind the datatable to the gridview as the source of informaiton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!Page.IsPostBack)
            {
                BindChecklistMode();
              //   string error;
               // var toditems= _iBLToDoItemService.SelecttoDoItems(out error);
            }
            else
            {
                BindGridView();
               

            }
        }
        #endregion

        #region Aspx Control Event Handlers


        #region Button Click Event Handlers
        /// <summary>
        /// Click event handler for the Add button
        /// Adds a new row to the grid view if the grid view is not edit mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAdd_Click(object sender, EventArgs e)
        {
        
            if (!gridView.IsEditing && !gridView.IsNewRowEditing)
                  gridView.AddNewRow();
        }


        #endregion
      

        #region Gridview Row Event Handlers
        /// <summary>
        /// Gridview Upate Row Event Handler
        /// Used to update data row into the datatable and update the gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected void gridView_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {
            if(e.Cancel)
            {

            }
            else
            {

                var toDoItemId=(int)Session["ToDoItemId"];
                var toDoItemStrikeThough = (bool)Session["ToDoItemStrikeThough"];
                var toDoItem = Session["ToDoItem"].ToString();
                if (hfAnswers.Contains("ToDoItem"))
                {
                    toDoItem = hfAnswers["ToDoItem"].ToString();
                    Session["ToDoItem"] = toDoItem;
                }
                var table = SessionChecklistModeData;
                DataRow found = table.Rows.Find(toDoItemId);
                found["ToDoItem"] = toDoItem;
                found["ToDoItemStrikeThough"] = toDoItemStrikeThough;

                SessionChecklistModeData = table;

                //   string error;
                //var updateTodo = new BLToDoItemsInputModel {
                //ToDoItem= toDoItem,
                //ToDoItemId= toDoItemId,
                //ToDoItemStrikeThrough= toDoItemStrikeThough
                //}
                //;
               
                // var toditems= _iBLToDoItemService.UpdatetoDoItems(updateTodo,out error);
            }

            e.Cancel = true;
                gridView.CancelEdit();

            BindGridView();
        }

        /// <summary>
        /// Gridview Delete Row Event Handler
        /// Used to remove data row into the datatableupdate the gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected void gridView_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
        {

            var toDoItemId = (int)Session["ToDoItemId"];
            //var toDoItemStrikeThough = (bool)Session["ToDoItemStrikeThough"];
            //var toDoItem = Session["ToDoItem"] = Session["ToDoItem"].ToString();


            var table = SessionChecklistModeData;
            DataRow found = table.Rows.Find(toDoItemId);
            table.Rows.Remove(found);
            SessionChecklistModeData = table;
            e.Cancel = true;
            gridView.CancelEdit();

            //   string error          
            //var toditems= _iBLToDoItemService.DeleteToDoItems(toDoItemId, out error,);

            BindGridView();
        }

        /// <summary>
        /// GridView Row Insert Event Handler
        /// Used to insert data row into the datatable and update the gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gridView_RowInserting(object sender, DevExpress.Web.Data.ASPxDataInsertingEventArgs e)
        {
            ASPxGridView grid = sender as ASPxGridView;

            DataTable table = SessionChecklistModeData;
            DataRow newRow = table.NewRow();

            newRow["ToDoItemId"] = GetLastKey() + 1;
            newRow["ToDoItem"] = txtAdd.Value;
            newRow["ToDoItemStrikeThough"] = false;
            table.Rows.Add(newRow);
            // table.Rows.Add(GetLastKey() + 1, e.NewValues["ChecklistMode"], 1, );
            SessionChecklistModeData = table;
            e.Cancel = true;
            gridView.CancelEdit();

            // string error;
            //var updateTodo = new BLToDoItemsInputModel
            //{
            //    ToDoItemId = GetLastKey() + 1,
            //    ToDoItem = txtAdd.Value.ToString(),
            //    ToDoItemStrikeThrough = false
            //}
            //;
            // var toditems= _iBLToDoItemService.InsertoDoItems(updateTodo,out error);

            BindGridView();
        }

        /// <summary>
        /// GridView InitNewRow eventhandle
        /// Used to initialiaze a new row values in grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks> Note the use of the UpdateEdit method to prevent a new row fron being able to be edited</remarks>
        protected void gridView_InitNewRow(object sender, DevExpress.Web.Data.ASPxDataInitNewRowEventArgs e)
        {
            e.NewValues["ToDoItemId"] = GetLastKey() + 1;
            e.NewValues["ToDoItem"] = txtAdd.Value;
            gridView.UpdateEdit();

        }
         #endregion


        #region Gridview Custom Callbacks
        /// <summary>
        ///  Gridview initialaztion callback event handler used for the custom buttons used in the grid
        ///  Used to enable and disable the buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gridView_CustomButtonInitialize(object sender, ASPxGridViewCustomButtonEventArgs e)
        {

            var b = e.VisibleIndex;
            e.Visible = DevExpress.Utils.DefaultBoolean.True;
          
            switch (e.ButtonID)
                {
                    case "btnEdit":
                        {
                            if (gridView.IsEditing || gridView.IsNewRowEditing)
                                e.Enabled = false;
                            else
                                e.Enabled = true;
                        }
                        break;
                    case "btDone":
                        {
                        }
                        break;
                    case "btnDelete":
                        {
                            if (gridView.IsEditing || gridView.IsNewRowEditing)
                                e.Enabled = false;
                            else
                                e.Enabled = true;
                        }
                        break;
                }
        }

        /// <summary>
        ///  Gridview button click callback event handler used for the handling the click events on the buttons
        ///  Used to enable and disable the buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///<remarks> A workflow method should be called for each button</remarks>
        protected void gridView_CustomButtonCallback(object sender, ASPxGridViewCustomButtonCallbackEventArgs e)
        {
            string[] fields = { "ToDoItemId", "ToDoItemStrikeThough", "ToDoItem" };
            var editMode = gridView.IsEditing;
            var newEditMode = gridView.IsNewRowEditing;
            var row = gridView.GetRow(e.VisibleIndex);
            switch (e.ButtonID)
            {
                case "btnEdit":
                    {
                        object[] values = gridView.GetRowValues(e.VisibleIndex, fields) as object[];
                           values[1] = false;
                        var toDoItemId = (int)values[0];
                        var toDoItemStrikeThough = (bool)values[1];
                        var toDoItem = values[2].ToString();

                        var table = SessionChecklistModeData;
                        DataRow found = table.Rows.Find(toDoItemId);
                        found["ToDoItem"] = toDoItem;
                        found["ToDoItemStrikeThough"] = false;
                        SessionChecklistModeData = table;
                        UpdateSessionColumnValues(values);
                        gridView.StartEdit(e.VisibleIndex);
                        
                      
                    }
                    break;
                case "btnDone":
                    {
                        if (newEditMode)
                        {
                            gridView.UpdateEdit();
                            return;
                        }
                        object[] values = gridView.GetRowValues(e.VisibleIndex, fields) as object[];

                        var toDoItemId = (int)values[0];
                        var toDoItemStrikeThough = (bool)values[1];
                        var toDoItem = values[2].ToString();
                        var table = SessionChecklistModeData;
                        DataRow found = table.Rows.Find(toDoItemId); 
                        if (editMode && gridView.EditingRowVisibleIndex == e.VisibleIndex)
                        {
                            values[1] = false;
                            UpdateSessionColumnValues(values);                        
                            found["ToDoItemStrikeThough"] = false;
                            SessionChecklistModeData = table;
                            gridView.UpdateEdit();
                            return;
                        }
                     
                        found["ToDoItem"] = toDoItem;
                        found["ToDoItemStrikeThough"] = true;
                        SessionChecklistModeData= table;



                        //}
                        if (editMode)
                        {
                            values[1] = false;
                            UpdateSessionColumnValues(values);
                            gridView.UpdateEdit();
                        }
                        else
                        {
                            BindGridView();
                        }


                    }
                    break;
                case "btnDelete":
                    {
                        object[] values = gridView.GetRowValues(e.VisibleIndex, fields) as object[];
                        Session["ToDoItemId"] = (int)values[0];
                        Session["ToDoItemStrikeThough"] = (bool)values[1];
                        Session["ToDoItem"] = values[2].ToString();
                        gridView.DeleteRow(e.VisibleIndex);
                        
        
                    }
                    break;
            }// end  switch (e.ButtonID)
        }



        #endregion


        #region Panel Callbck event handlers
        /// <summary>
        /// Call back event handler for the panel the grid view is contained in
        /// Used to update and cancel an edit session in the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected void cp_Callback(object sender, CallbackEventArgsBase e)
        {
            switch (e.Parameter)
            {
                case "Update":
                    gridView.UpdateEdit();
                    break;
                case "Cancel":
                    gridView.CancelEdit();
                   
                    break;
            }
        }

        #endregion


        #region Other Event Handler
        /// <summary>
        /// Grid view hteml data cell prepared event handler
        /// Used to customize place a line through to do item displayed or removie it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gridView_HtmlDataCellPrepared(object sender, ASPxGridViewTableDataCellEventArgs e)
        {
            if (e.DataColumn.FieldName.Equals("ToDoItem"))
            {
                var strikethrough = Convert.ToBoolean(e.GetValue("ToDoItemStrikeThough"));
                var key = Convert.ToInt32(e.GetValue("ToDoItemId"));

                var lbl = gridView.FindRowCellTemplateControl(e.VisibleIndex, gridView.Columns["colToDoItem"] as GridViewDataColumn, "lblTodo") as ASPxLabel;
                if (lbl != null)
                {
                    if (strikethrough)
                    {
                        lbl.Style["text-decoration"] = "line-through";
                    }
                    else
                    {
                        lbl.Style["text-decoration"] = "none";
                    }
                }
            }


        }

        /// <summary>
        /// Gridview Upate Command Button Initialze
        /// Used to to prevent default grid view update and cancel buttons from negin displayed
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gridView_CommandButtonInitialize(object sender, ASPxGridViewCommandButtonEventArgs e)
        {
            if (e.ButtonType == ColumnCommandButtonType.Update || e.ButtonType == ColumnCommandButtonType.Cancel)
            {
                e.Visible = false;
            }
        }

        #endregion

        #endregion

        #endregion

        #region Utility
        /// <summary>
        /// Updates current session column values for given column row being used
        /// </summary>
        /// <param name="values">Array of values to update session column with</param>
        private void UpdateSessionColumnValues(object[] values)
            {
                Session["ToDoItemId"] = (int)values[0];
                Session["ToDoItemStrikeThough"] = (bool)values[1];
                Session["ToDoItem"] = values[2].ToString();
            }

        /// <summary>
        /// Used to bind data source to gridview when page first load
        /// </summary>
        private void BindChecklistMode()
        {
            try
            {
                Masters objChecklist = new Masters();
                DataTable dtChecklistModes = objChecklist.GetChecklistModeList();

                SessionChecklistModeData = dtChecklistModes;

                //DataColumn[] keycol = new DataColumn[1];
                //keycol[0] = SessionChecklistModeData.Columns["ToDoItemId"];
                //SessionChecklistModeData.PrimaryKey = keycol;

                gridView.DataSource = SessionChecklistModeData;
                gridView.DataBind();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// BindGridView method
        /// Used to bind data source to gridview
        /// </summary>
        private void BindGridView()
        {
            gridView.DataSource = SessionChecklistModeData;
            gridView.DataBind();
        }

        /// <summary>
        /// GetLastKey() used to create unique primary key to used in a datatable's row
        /// </summary>
        /// <returns>Unquie primary key</returns>
        public Int32 GetLastKey()
        {
            DataTable table = SessionChecklistModeData;

            Int32 max = 0;
            foreach (DataRow row in table.Rows)
            {
                if (Convert.ToInt32(row["ToDoItemId"]) > max)
                    max = Convert.ToInt32(row["ToDoItemId"]);
            }
            return max;
        }

        #endregion


    }
}