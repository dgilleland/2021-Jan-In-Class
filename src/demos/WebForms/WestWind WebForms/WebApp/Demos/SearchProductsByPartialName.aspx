<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchProductsByPartialName.aspx.cs" Inherits="WebApp.Demos.SearchProductsByPartialName" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Search Products by Partial Name</h1>

    <div class="row">
        <div class="col">
            <asp:TextBox ID="PartialName" runat="server" CssClass="form-control" placeholder="Enter a partial product name" />
            <asp:LinkButton ID="SearchProducts" runat="server" CssClass="btn btn-primary">Search Products</asp:LinkButton>

            <asp:GridView ID="ProductsGridView" runat="server" CssClass="table table-hover" AutoGenerateColumns="False" DataSourceID="ProductsDataSource">
                <Columns>
                    <asp:BoundField DataField="ProductID" HeaderText="Product ID" SortExpression="ProductID"></asp:BoundField>
                    <asp:BoundField DataField="ProductName" HeaderText="Product Name" SortExpression="ProductName"></asp:BoundField>
                    <asp:BoundField DataField="SupplierID" HeaderText="Supplier ID" SortExpression="SupplierID"></asp:BoundField>
                    <asp:BoundField DataField="CategoryID" HeaderText="Category ID" SortExpression="CategoryID"></asp:BoundField>
                    <asp:BoundField DataField="QuantityPerUnit" HeaderText="Quantity Per Unit" SortExpression="QuantityPerUnit"></asp:BoundField>
                    <asp:BoundField DataField="MinimumOrderQuantity" HeaderText="Minimum Order Quantity" SortExpression="MinimumOrderQuantity"></asp:BoundField>
                    <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" SortExpression="UnitPrice"></asp:BoundField>
                    <asp:BoundField DataField="UnitsOnOrder" HeaderText="UnitsOnOrder" SortExpression="UnitsOnOrder"></asp:BoundField>
                    <asp:CheckBoxField DataField="Discontinued" HeaderText="Discontinued" SortExpression="Discontinued"></asp:CheckBoxField>
                </Columns>
            </asp:GridView>

            <%--This ObjectDataSource control will call my BLL method to get all the data--%>
            <asp:ObjectDataSource ID="ProductsDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="LookupProductsByPartialName" TypeName="WestWindSystem.BLL.ProductManager">
                <SelectParameters>
                    <asp:ControlParameter ControlID="PartialName" PropertyName="Text" Name="partial" Type="String"></asp:ControlParameter>
                </SelectParameters>
            </asp:ObjectDataSource>
        </div>
    </div>
</asp:Content>
