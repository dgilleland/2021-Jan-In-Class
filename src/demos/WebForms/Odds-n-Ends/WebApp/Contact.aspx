<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebApp.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>

    <div><asp:Label ID="MessageLabel" runat="server" /></div>

    <asp:DropDownList ID="NumberSequenceDropDown" runat="server"
        DataSourceID="NumberSequenceDataSource" DataTextField="Name" DataValueField="Value" 
        OnSelectedIndexChanged="NumberSequenceDropDown_SelectedIndexChanged" AutoPostBack="True"
        AppendDataBoundItems="true">
        <asp:ListItem Value="0">[Select a Number Position]</asp:ListItem>
    </asp:DropDownList>

    <asp:DropDownList ID="NumberMultipleDropDown" runat="server" DataSourceID="NumberMultipleDataSource" DataTextField="Name" DataValueField="Value" AppendDataBoundItems="true">
        <asp:ListItem Value="">[Select a multiple value]</asp:ListItem>
    </asp:DropDownList>

    <asp:ObjectDataSource ID="NumberSequenceDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetSomeNumbers" TypeName="MyBackendServices.BLL.FakeData"></asp:ObjectDataSource>

    <asp:ObjectDataSource ID="NumberMultipleDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetMultiplesOfSomeNumber" TypeName="MyBackendServices.BLL.FakeData">
        <SelectParameters>
            <asp:ControlParameter ControlID="NumberSequenceDropDown" PropertyName="SelectedValue" Name="number" Type="Int32"></asp:ControlParameter>
        </SelectParameters>
    </asp:ObjectDataSource>
    <hr />

    <h3>Your contact page.</h3>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>
