<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Odds-n-Ends</h1>
        <p class="lead">Bits and pieces of using Web Forms and ASP.NET Server Controls.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>
    <style type="text/css">
        .custom-table input {
            margin-right: 4px;
            margin-left: 25px;
        }
    </style>
    <div class="row">
        <div class="col">
            <h2>Customizing the GridView</h2>

            <div id="MessageContainer" runat="server">
                <asp:Label ID="MessageLabel" runat="server" />
            </div>

            <asp:Label ID="Label1" runat="server" AssociatedControlID="StudyProgramList">Study Major: </asp:Label>
            <asp:RadioButtonList ID="StudyProgramList" runat="server" DataSourceID="StudyProgramDataSource" DataTextField="Name" DataValueField="ProgramId" RepeatDirection="Horizontal" RepeatLayout="Flow" CssClass="custom-table" />

            <br />

            <asp:Label ID="Label2" runat="server" AssociatedControlID="CitizenshipList">Canadian Citizen: </asp:Label>
            <asp:RadioButtonList ID="CitizenshipList" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow" CssClass="custom-table">
                <asp:ListItem Value="true">Yes</asp:ListItem>
                <asp:ListItem Value="false">No</asp:ListItem>
            </asp:RadioButtonList>

            <br />

            <asp:GridView ID="AdHocGridView" runat="server"
                AutoGenerateColumns="False" DataSourceID="FakeMarksDataSource"
                CssClass="table table-hover" DataKeyNames="Number"
                OnSelectedIndexChanged="AdHocGridView_SelectedIndexChanged"
                ItemType="MyBackendServices.BLL.CourseMarks" AllowPaging="True" PageSize="4">
                <Columns>
                    <asp:CommandField ShowSelectButton="true" SelectText="Redeem Credits" HeaderText="Action" />
                    <asp:BoundField DataField="Number" HeaderText="Number" SortExpression="Number"></asp:BoundField>
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name"></asp:BoundField>

                    <asp:TemplateField>
                        <HeaderTemplate>Study Program</HeaderTemplate>
                        <ItemTemplate>
                            <asp:DropDownList ID="StudyProgramDropDown" runat="server"
                                DataSourceID="StudyProgramDataSource" 
                                AppendDataBoundItems="true"
                                Enabled="false"
                                SelectedValue="<%# Item.ProgramId %>"
                                DataTextField="Name" DataValueField="ProgramId">
                                <asp:ListItem Value="">[Select a Study Program]</asp:ListItem>
                            </asp:DropDownList>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:BoundField DataField="Credits" HeaderText="Credits" SortExpression="Credits"></asp:BoundField>
                    <asp:BoundField DataField="FinalMark" HeaderText="Course Mark" SortExpression="FinalMark"></asp:BoundField>
                </Columns>
                <EmptyDataTemplate>
                    <p><b>There are no course marks to display.</b> <i>This message was generated in the &lt;EmptyDataTemplate&gt; portion of the &lt;asp:GridView ...&gt; ASP.NET Servier Control</i>.</p>
                </EmptyDataTemplate>
            </asp:GridView>

            <asp:ObjectDataSource ID="FakeMarksDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="ListCourseMarks" TypeName="MyBackendServices.BLL.FakeData" />
            <asp:ObjectDataSource ID="StudyProgramDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="ListStudyPrograms" TypeName="MyBackendServices.BLL.FakeData" />
        </div>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Going Fishing</h2>
            <p>
                Fish are interesting things.
            </p>
            <asp:GridView ID="FishGridView" runat="server"></asp:GridView>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
