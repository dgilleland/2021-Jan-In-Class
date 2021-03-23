<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageProducts.aspx.cs" Inherits="WebApp.Demos.ManageProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="page-header">Manage Products</h1>

    <div class="row">
        <div class="col-md-4">
            <h2>Lookup Product</h2>
            <div class="form-inline mb-2">
                <asp:DropDownList ID="AllCategories" runat="server" CssClass="form-control mr-2" />
                <asp:LinkButton ID="FilterByCategory" runat="server" CssClass="btn btn-secondary" OnClick="FilterByCategory_Click" CausesValidation="false">Filter</asp:LinkButton>
            </div>
            <div class="form-inline">
                <asp:DropDownList ID="FilteredProducts" runat="server" CssClass="form-control mr-2" />
                <asp:LinkButton ID="SearchForProduct" runat="server" CssClass="btn btn-secondary" OnClick="SearchForProduct_Click" CausesValidation="false">Search</asp:LinkButton>
            </div>
            <asp:Label ID="MessageLabel" runat="server" />
            <asp:ValidationSummary ID="Summary" runat="server" HeaderText="The form has the following user-input errors." CssClass="alert alert-warning" />
            <hr />

            <div class="mb-2">
                <asp:LinkButton ID="AddProduct" runat="server" CssClass="btn btn-primary" OnClick="AddProduct_Click">Add</asp:LinkButton>
                <asp:LinkButton ID="UpdateProduct" runat="server" CssClass="btn btn-success" OnClick="UpdateProduct_Click">Update</asp:LinkButton>
                <asp:LinkButton ID="DeleteProduct" runat="server" CssClass="btn btn-danger" OnClick="DeleteProduct_Click" CausesValidation="false">Delete</asp:LinkButton>
                <asp:LinkButton ID="ClearForm" runat="server" CssClass="btn btn-warning" OnClick="ClearForm_Click" CausesValidation="false">Clear</asp:LinkButton>
            </div>
            <div class="form-row mb-2">
                <asp:Label ID="Label1" runat="server" CssClass="col-sm-3" AssociatedControlID="ProductID" Text="Product ID" />
                <asp:TextBox ID="ProductID" runat="server" CssClass="form-control col-sm-9" Enabled="false" />
            </div>
            <div class="form-row mb-2">
                <asp:Label ID="Label2" runat="server" CssClass="col-sm-3" AssociatedControlID="ProductName" Text="Name" />
                <asp:TextBox ID="ProductName" runat="server" CssClass="form-control col-sm-9" />
                <asp:RequiredFieldValidator ID="RequiredProductName" runat="server" ControlToValidate="ProductName" ErrorMessage="Product Name is required" Display="None" />
            </div>
            <div class="form-row mb-2">
                <asp:Label ID="Label3" runat="server" CssClass="col-sm-3" AssociatedControlID="Suppliers" Text="Supplier" />
                <asp:DropDownList ID="Suppliers" runat="server" CssClass="form-control col-sm-9" />
                <asp:RequiredFieldValidator ID="RequiredSupplier" runat="server" ControlToValidate="Suppliers" ErrorMessage="A supplier for the product must be identified" Display="None" />
            </div>
            <div class="form-row mb-2">
                <asp:Label ID="Label4" runat="server" CssClass="col-sm-3" AssociatedControlID="Categories" Text="Category" />
                <asp:DropDownList ID="Categories" runat="server" CssClass="form-control col-sm-9" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Categories" ErrorMessage="A category for the product must be identified" Display="None" />
            </div>
            <div class="form-row mb-2">
                <asp:Label ID="Label6" runat="server" CssClass="col-sm-3" AssociatedControlID="QtyPerUnit" Text="Qty Per Unit" />
                <asp:TextBox ID="QtyPerUnit" runat="server" CssClass="form-control col-sm-9" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="QtyPerUnit" ErrorMessage="Quantity Per Unit is required" Display="None" />
            </div>
            <div class="form-row mb-2">
                <asp:Label ID="Label7" runat="server" CssClass="col-sm-3" AssociatedControlID="Price" Text="Unit Price" />
                <asp:TextBox ID="Price" runat="server" CssClass="form-control col-sm-9" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="Price" ErrorMessage="Unit Price is required" Display="None" />
                <asp:CompareValidator ID="PriceComparison" runat="server" ControlToValidate="Price" Type="Currency" Operator="GreaterThan" ValueToCompare="0" ErrorMessage="Price must be a currency value over zero." />
            </div>
            <div class="form-row mb-2">
                <asp:Label ID="Label5" runat="server" CssClass="col-sm-3" AssociatedControlID="OnOrder" Text="On Order" />
                <asp:TextBox ID="OnOrder" runat="server" CssClass="form-control col-sm-9" />
                <asp:RequiredFieldValidator ID="RequiredOnOrder" runat="server" ControlToValidate="OnOrder" ErrorMessage="On-Order quantity is required" Display="None" />
                <asp:CompareValidator ID="OnOrderComparison" runat="server" ControlToValidate="OnOrder" Type="Integer" Operator="GreaterThanEqual" ValueToCompare="0" ErrorMessage="On order quantities must be a whole number and cannot be negative" />
            </div>
            <div class="form-row mb-2">
                <asp:Label ID="Label8" runat="server" CssClass="col-sm-3" AssociatedControlID="Discontinued" Text="Discontinued" />
                <asp:CheckBox ID="Discontinued" runat="server" CssClass="col-sm-9" />
            </div>
        </div>

        <div class="col-md-8">
            <h2>Student Notes</h2>
            <p>TODO:</p>
            <ul>
                <li>Add Validation Controls</li>
                <li>Demonstrate Search/GridView/Stored Procedures</li>
                <li></li>
                <li></li>
                <li></li>
            </ul>
        </div>
    </div>
</asp:Content>
