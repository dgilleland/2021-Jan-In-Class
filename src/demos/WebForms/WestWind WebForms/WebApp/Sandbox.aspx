<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Sandbox.aspx.cs" Inherits="WebApp.Sandbox" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%-- All of our markup for this page will go inside of our <asp:Content tag --%>
    <!-- Notice that there is effectively little to no C# that appears directly inside of our .aspx file -->

    <h1 class="page-header">Sandbox</h1>

    <div class="row">
        <div class="col">
            <asp:Label ID="Label1" runat="server" AssociatedControlID="FirstName">First Name:</asp:Label>
            <asp:TextBox ID="FirstName" runat="server" CssClass="form-control" />

            <asp:LinkButton ID="SubmitName" runat="server" CssClass="btn btn-primary" OnClick="SubmitName_Click">Submit My Name</asp:LinkButton>

            <hr />
            <asp:Label ID="MessageBox" runat="server" />
        </div>
    </div>
</asp:Content>
