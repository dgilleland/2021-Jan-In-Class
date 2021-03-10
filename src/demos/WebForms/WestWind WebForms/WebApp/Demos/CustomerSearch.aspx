<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerSearch.aspx.cs" Inherits="WebApp.Demos.CustomerSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="page-header">Customer Search</h1>

    <div class="row">
        <div class="col">
            <div class="form-inline">
                <asp:TextBox ID="PartialName" runat="server" CssClass="form-control" placeholder="Partial Customer Name" />
                &nbsp;
                <asp:LinkButton ID="FindCustomers" runat="server" CssClass="btn btn-md btn-secondary"
                    OnClick="FindCustomers_Click">
                    Find Customer
                </asp:LinkButton>
            </div>
        </div>
        <div class="col">
            <div class="form-inline">
                <asp:Label ID="Label1" runat="server" AssociatedControlID="MatchingNames">Matching Names: </asp:Label>
                <asp:DropDownList ID="MatchingNames" runat="server" CssClass="form-control"></asp:DropDownList>
                &nbsp;
                <asp:LinkButton ID="ShowOrders" runat="server" CssClass="btn btn-md btn-secondary"
                    OnClick="ShowOrders_Click">
                    Show Orders
                </asp:LinkButton>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col">
            <asp:Label ID="MessageLabel" runat="server" />
        </div>
    </div>
</asp:Content>
