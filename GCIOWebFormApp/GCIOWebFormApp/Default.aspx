<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GCIOWebFormApp._Default" %>

<%@ Register Assembly="DevExpress.Web.v20.2, Version=20.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        .centerEmptyGrid {
            text-align: center;
        }

        .leftEmptyGrid {
            text-align: left;
        }

        .rowbg {
            display: flex;
            background: yellow;
            height: 5vh;
            display: flex;
            align-items: center;
        }

        .rowbg {
            display: flex;
            background: yellow;
            height: 5vh;
            display: flex;
            align-items: center;
        }

        .textStrikeThough {
            text-decoration: line-through;
        }

        .textStrikeThough {
            text-decoration: none;
        }

        .row {
            width:90%;
            margin-top:10px;

        }
.container {
  display: flex;
  justify-content: center;
} 
.center {
   
  align-content:center
}
input,  
select,  
textarea {  
    max-width: 6000px;  
}  
    </style>

    <script type="text/javascript">


        document.onclick = docOnClick;


        function docOnClick(e) {


        }

        function EndCallback(s, e) {
            
            if (gridViewJs.IsEditing() === true) {

                txtAddJs.SetEnabled ( false);
                
            }
            else {
                txtAddJs.SetEnabled(true);
            }
            
        }

        function OnInitTxtToDo(s, e) {
            input.onpaste = onPaste;

        }
        function onPaste() {

            return false;
        }
        //For checking if a string is empty, null or contains only white spa:
        function isEmpty(str) {
            return (!str || 0 === str.length || !str.trim());
        }


        function OnGridUpdate() {
            var table, tbody, i, rowLen, row, j, colLen, cell;
            if (gridViewJs.GetVisibleRowsOnPage() > 0) {


                //    table = document.getElementById("gridViewJs");
                //     tbody = table.tBodies[0];
                //    for (i = 0, rowLen = tbody.rows.length; i < rowLen; i++) {
                //        row = tbody.rows[i];
                //        var cell2 = row.cells[2];
                //    }
                //     //var mt = gridViewJs.GetMainTable();
                //     //for (var rowIndex = 0; rowIndex < mt.rows.length; rowIndex++) {


                //     //  var cell2 = row.cells[2];
                //     //    var lbl = $(cell2[id ^= 'gridLblTodoJs']);
                //     //    var cell0 = row.cells[0];
                //     //    var cell1 = row.cells[1];


            }

        }





        function onBtnDoneClick(s, e) {

            var keys = gridViewJs.AddNewRow();

            e.processOnServer = false;
            return false;
        }
        function onBtnDoneEditClick(s, e) {

            //if (gridViewJs.IsEditing()) {
            //  s.EndEditRow(e.visibleIndex);
            gridViewJs.UpdateEdit();


            e.processOnServer = false;
        }

        function onBtnAddClick(s, e) {

            gridViewJs.AddNewRow();
            e.processOnServer = false;
        }

        function onTextBoxKeuUp(s, e) {

            //if (e.htmlEvent.keyCode == 13)
            //   //  gridViewJs.UpdateEdit();
            //   cp.PerformCallback("Update");
            //if (e.htmlEvent.keyCode == 27)
            //   // gridViewJs.CancelEdit();
            //    cp.PerformCallback("Cancel");
            ASPxClientUtils.PreventEventAndBubble(e.htmlEvent);
            return false;
        }
    </script>

    <dx:ASPxCallbackPanel ID="cp" runat="server" ClientInstanceName="cp" OnCallback="cp_Callback">
        <PanelCollection>
            <dx:PanelContent runat="server" SupportsDisabledAttribute="True">

                <table  style=" border: 2px solid #000000; width: 800px;">
                    <tr style=" border-bottom: 1pt solid black">
                        <td  style="width:600px">
                            
                                    <dx:ASPxTextBox ID="txtAdd" runat="server"
                                        ClientInstanceName="txtAddJs" Width="600px"
                                        AutoPostBack="false" >
                                    </dx:ASPxTextBox>
                          </td>
                       <td   style="width:200px; text-align:center">    
                                    <dx:ASPxButton ID="btnAdd" runat="server" RenderMode="Link"
                                        EnableClientSideAPI="true"  
                                        ClientInstanceName="btnAddJs" AutoPostBack="false"
                                        Text="Add"  Enabled="True" HorizontalAlign="Center">
                                        <ClientSideEvents Click="function(s, e) {
                                                    if (gridViewJs.IsEditing() === true) 
                                                    {
                                                    alert('The grid view must not be in edit mode to add a new row');
                                                    }
                                                    else
                                                    {
                                                    gridViewJs.AddNewRow();
                                                    }
                                            return false;
                                            }" />
                                    </dx:ASPxButton>
                           
                        </td>

                    </tr>
                 <tr style=" border-bottom: 1pt solid black">
                        <td colspan="2" style="margin-top:10px">
                            
                               


                                    <dx:ASPxGridView runat="server"
                                        Width="800px"
                                        
                                        ID="gridView"
                                        ClientInstanceName="gridViewJs"
                                        AutoGenerateColumns="False"
                                        SettingsEditing-Mode="Inline"
                                        KeyFieldName="ToDoItemId"
                                        OnCommandButtonInitialize="gridView_CommandButtonInitialize"
                                        OnCustomButtonInitialize="gridView_CustomButtonInitialize"
                                        OnRowInserting="gridView_RowInserting"
                                        OnHtmlDataCellPrepared="gridView_HtmlDataCellPrepared"
                                        OnRowUpdating="gridView_RowUpdating"
                                        OnRowDeleting="gridView_RowDeleting"
                                        OnInitNewRow="gridView_InitNewRow"
                                        OnCustomButtonCallback="gridView_CustomButtonCallback">
                                        <Settings ShowColumnHeaders="false"
                                            GridLines="Both" ShowStatusBar="Hidden" />

                                        <Templates>
                                            <EmptyDataRow>
                                                <div style="width: 100%;" class="centerEmptyGrid">
                                                    Use Add button to add a To Do Item
                                                </div>
                                            </EmptyDataRow>
                                        </Templates>

                                        <Columns>
                                            <dx:GridViewDataTextColumn FieldName="ToDoItem" VisibleIndex="0" Width="600px"
                                                Name="colToDoItem">


                                                <DataItemTemplate>
                                                    <div style="text-align: center;">
                                                        <dx:ASPxLabel ID="lblTodo" runat="server" 
                                                            Value='<%# Bind("ToDoItem") %>'
                                                            ClientInstanceName="gridLblTodoJs" />
                                                    </div>
                                                </DataItemTemplate>

                                                <EditItemTemplate>
                                                    <dx:ASPxTextBox ID="txtTodo" runat="server"
                                                        ClientInstanceName="gridTxtTodoJs"
                                                        OnPaste="return false"
                                                        OnDrop="return false"
                                                        Value='<%# Bind("ToDoItem") %>'
                                                        Width="100%" AutoCompleteType="Disabled" BackColor="#66FF66">
                                                        <ClientSideEvents KeyUp="function(s, e) {
                                                    var text = gridTxtTodoJs.GetText(); 
                                                    hfAnswers.Set('ToDoItem', text);
                                                    if(e.htmlEvent.keyCode == 13) {                        
                                                        var text = gridTxtTodoJs.GetText();                                   
                                                        hfAnswers.Set('updateedit', text);
                                           
                                                        cp.PerformCallback('Update');
                                                        ASPxClientUtils.PreventEventAndBubble(e.htmlEvent);
                                                    }
                                         else if(e.htmlEvent.keyCode == 27) {  
                                    
                                                        var text = gridTxtTodoJs.GetText();                                   
                                                        hfAnswers.Set('updateedit', text);
                                                     ;
                                                        cp.PerformCallback('Cancel');
                                                        ASPxClientUtils.PreventEventAndBubble(e.htmlEvent);
                                                    }      
                                    
                                            }" />

                                                    </dx:ASPxTextBox>

                                                </EditItemTemplate>
                                            </dx:GridViewDataTextColumn>

                                            <dx:GridViewCommandColumn VisibleIndex="2">
                                                <CustomButtons>
                                                    <dx:GridViewCommandColumnCustomButton ID="btnEdit" Text="Edit">
                                                    </dx:GridViewCommandColumnCustomButton>

                                                    <dx:GridViewCommandColumnCustomButton ID="btnDone" Text="Done">
                                                    </dx:GridViewCommandColumnCustomButton>


                                                    <dx:GridViewCommandColumnCustomButton ID="btnDelete" Text="Delete">
                                                    </dx:GridViewCommandColumnCustomButton>
                                                </CustomButtons>
                                            </dx:GridViewCommandColumn>


                                            <dx:GridViewDataTextColumn FieldName="ToDoItemId" Visible="false" VisibleIndex="2"
                                                Width="1" Name="colToDoID">
                                            </dx:GridViewDataTextColumn>
                                            <dx:GridViewDataCheckColumn FieldName="ToDoItemStrikeThough" VisibleIndex="3"
                                                Name="colStrikeThrough"
                                                Visible="false"
                                                Width="1" />




                                        </Columns>
                                        <ClientSideEvents EndCallback="EndCallback" />
                                    </dx:ASPxGridView>
                                    <br />
                                    <dx:ASPxHiddenField runat="server" ClientInstanceName="hfAnswers" ID="hfAnswers">
                                    </dx:ASPxHiddenField>

                                
                        </td>
                    

                    </tr>        
                  </table>


            </dx:PanelContent>
        </PanelCollection>
    </dx:ASPxCallbackPanel>
</asp:Content>
