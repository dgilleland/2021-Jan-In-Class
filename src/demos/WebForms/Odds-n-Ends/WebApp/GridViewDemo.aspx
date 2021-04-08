<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GridViewDemo.aspx.cs" Inherits="WebApp.GridViewDemo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="page-header">GridView and Programmatic Paging</h1>

    <div class="row">
        <div class="col">
            <div id="MessageContainer" runat="server">
                <asp:Label ID="MessageLabel" runat="server" />
            </div>

            <style type="text/css">
                .custom-table input {
                    margin-right: 4px;
                    margin-left: 25px;
                }
            </style>
            <asp:Label ID="Label1" runat="server" AssociatedControlID="StudyProgramList">Study Major: </asp:Label>
            <asp:RadioButtonList ID="StudyProgramList" runat="server" DataTextField="Name" DataValueField="ProgramId" RepeatDirection="Horizontal" RepeatLayout="Flow" CssClass="custom-table" AutoPostBack="true" OnSelectedIndexChanged="StudyProgramList_SelectedIndexChanged" />

            <br />
            <asp:GridView ID="AdHocGridView" runat="server"
                AutoGenerateColumns="False"
                CssClass="table table-hover" DataKeyNames="Number"
                OnPageIndexChanging="AdHocGridView_PageIndexChanging"
                ItemType="MyBackendServices.BLL.CourseMarks" AllowPaging="True" PageSize="4">
                <Columns>
                    <asp:BoundField DataField="Number" HeaderText="Number" SortExpression="Number"></asp:BoundField>
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>
                    <asp:BoundField DataField="Credits" HeaderText="Credits" SortExpression="Credits"></asp:BoundField>
                    <asp:BoundField DataField="FinalMark" HeaderText="Course Mark" SortExpression="FinalMark"></asp:BoundField>
                </Columns>
                <EmptyDataTemplate>
                    <p><b>There are no course marks to display.</b> <i>This message was generated in the &lt;EmptyDataTemplate&gt; portion of the &lt;asp:GridView ...&gt; ASP.NET Servier Control</i>.</p>
                </EmptyDataTemplate>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
