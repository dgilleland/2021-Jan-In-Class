<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchProducts.aspx.cs" Inherits="WebApp.Demos.SearchProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Search Products</h1>

    <div class="row">
        <div class="col">
            <asp:DropDownList ID="SuppliersDropDown" runat="server" CssClass="form-control" />
            <asp:LinkButton ID="SearchBySupplier" runat="server" CssClass="btn btn-secondary" OnClick="SearchBySupplier_Click">Search by Supplier</asp:LinkButton>

            <asp:GridView ID="ProductsGridView" runat="server"></asp:GridView>
        </div>
    </div>
</asp:Content>
