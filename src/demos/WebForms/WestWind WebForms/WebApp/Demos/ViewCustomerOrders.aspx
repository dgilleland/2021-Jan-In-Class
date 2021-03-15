<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewCustomerOrders.aspx.cs" Inherits="WebApp.Demos.ViewCustomerOrders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 class="page-header">View Customer Orders</h1>

    <div class="row">
        <div class="col-md-3">
            <!-- Summary information about the customer -->
            <h2><asp:Label ID="CustomerName" runat="server" /></h2>
            <asp:Label ID="ContactName" runat="server" />
            -
            <asp:Label ID="PhoneNumber" runat="server" />
            <br />
            <asp:LinkButton ID="AddOrder" runat="server" CssClass="btn btn-secondary">Add Order</asp:LinkButton>
        </div>
        <div class="col-md-9">
            <!-- HTML Table for all of the orders -->
            <h2>Orders</h2>

            <asp:GridView ID="OrdersGridView" runat="server" CssClass="table table-hover" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="EditLink" runat="server" CssClass="btn btn-secondary btn-sm">Edit</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="OrderDate" DataFormatString="{0:yyyy-MM-dd}" HeaderText="Order Date" />
                    <asp:BoundField DataField="ShipName" HeaderText="Ship Name" />
                    <asp:CheckBoxField DataField="Shipped" HeaderText="Shipped" />
                    <asp:BoundField DataField="Freight" HeaderText="Freight" DataFormatString="{0:C}" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
