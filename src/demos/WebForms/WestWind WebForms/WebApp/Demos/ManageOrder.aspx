<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageOrder.aspx.cs" Inherits="WebApp.Demos.ManageOrder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="page-header">Manage Order</h1>

    <div class="row">
        <div class="col">
            <asp:LinkButton ID="AddOrder" runat="server" CssClass="btn btn-primary" OnClick="AddOrder_Click">Add Order</asp:LinkButton>
            <asp:LinkButton ID="UpdateOrder" runat="server" CssClass="btn btn-success" OnClick="UpdateOrder_Click">Update Order</asp:LinkButton>
            <asp:LinkButton ID="DeleteOrder" runat="server" CssClass="btn btn-danger" OnClick="DeleteOrder_Click" CausesValidation="false">Delete Order</asp:LinkButton>
            <button type="reset" class="btn btn-secondary">Reset</button>
            <asp:LinkButton ID="ClearForm" runat="server" CssClass="btn btn-warning" OnClick="ClearForm_Click" CausesValidation="false">Clear Form</asp:LinkButton>
            <asp:Label ID="MessageLabel" runat="server" />
            <asp:ValidationSummary ID="Summary" runat="server" />
        </div>
    </div>
    <div class="row">
        <div class="col">
            <asp:Label ID="Label1" runat="server" AssociatedControlID="OrderId">Order ID:</asp:Label>
            <asp:TextBox ID="OrderId" runat="server" CssClass="form-control" Enabled="false" />
            <br />

            <asp:Label ID="Label2" runat="server" AssociatedControlID="SalesRep">Sales Rep:</asp:Label>
            <asp:DropDownList ID="SalesRep" runat="server" CssClass="form-control" />
            <br />

            <asp:Label ID="Label3" runat="server" AssociatedControlID="Customer">Customer:</asp:Label>
            <asp:DropDownList ID="Customer" runat="server" CssClass="form-control" />
            <asp:RequiredFieldValidator ID="CustomerRequired" runat="server" ControlToValidate="Customer"
                 ErrorMessage="Customer is required for adding/updating" />
            <br />

            <asp:Label ID="Label4" runat="server" AssociatedControlID="OrderDate">Order Date:</asp:Label>
            <asp:TextBox ID="OrderDate" runat="server" TextMode="Date" CssClass="form-control" />
            <br />

            <asp:Label ID="Label5" runat="server" AssociatedControlID="RequiredDate">Required By:</asp:Label>
            <asp:TextBox ID="RequiredDate" runat="server" TextMode="Date" CssClass="form-control" />
            <br />

            <asp:Label ID="Label6" runat="server" AssociatedControlID="PaymentDueDate">Payment Due Date:</asp:Label>
            <asp:TextBox ID="PaymentDueDate" runat="server" TextMode="Date" CssClass="form-control" />
            <br />
        </div>
        <div class="col">
            <asp:Label ID="Label7" runat="server" AssociatedControlID="Freight">Freight:</asp:Label>
            <asp:TextBox ID="Freight" runat="server" CssClass="form-control" />
            <br />

            <asp:Label ID="Label8" runat="server" AssociatedControlID="Shipped">Shipped:</asp:Label>
            <asp:CheckBox ID="Shipped" runat="server" Text="Yes" />
            <br />

            <asp:Label ID="Label9" runat="server" AssociatedControlID="ShipName">Ship Name:</asp:Label>
            <asp:TextBox ID="ShipName" runat="server" CssClass="form-control" />
            <br />

            <asp:Label ID="Label10" runat="server" AssociatedControlID="ShipAddress">Ship Address:</asp:Label>
            <asp:DropDownList ID="ShipAddress" runat="server" CssClass="form-control" />
            <br />

            <asp:Label ID="Label11" runat="server" AssociatedControlID="Comments">Comments:</asp:Label>
            <asp:TextBox ID="Comments" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="4" />
            <br />

        </div>
    </div>
</asp:Content>
