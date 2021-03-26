﻿<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="bg-info p-2 pb-3"><%: Title %> Us.</h2>
    <div class="row">
        <div class="col-md-4">
            <h3>We're Hiring!</h3>
            <p>Due to a recent spat of layoffs following a bad year of litigation, we're currently short-staffed. Simply <b>fill out the form below</b> and we'll be in contact with you shortly. Join us now, and live the dream!</p>

            <asp:Label ID="Label1" runat="server" AssociatedControlID="">Your Name:</asp:Label>
            <asp:TextBox ID="YourFullName" runat="server" CssClass="form-control" />
            <asp:RequiredFieldValidator ID="Required" runat="server" ErrorMessage="You must supply your full name." ControlToValidate="YourFullName" Display="None" />

            <asp:Label ID="Label2" runat="server" AssociatedControlID="">Your Email:</asp:Label>
            <asp:TextBox ID="YourEmail" runat="server" TextMode="Email" CssClass="form-control" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="We need your email to contact you about an interview." ControlToValidate="YourEmail" Display="None" />
            <asp:RegularExpressionValidator ID="EmailFormatValidator" runat="server" ErrorMessage="Your email must meet standard formatting." ControlToValidate="YourEmail" Display="None" ValidationExpression="[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?" />

            <asp:Label ID="Label3" runat="server" AssociatedControlID="">Your Age:</asp:Label>
            <asp:TextBox ID="YourAge" runat="server" TextMode="Number" CssClass="form-control" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="You must supply your actual age." ControlToValidate="YourAge" Display="None" />

            <asp:Label ID="Label4" runat="server" AssociatedControlID="">Expected Starting Salary:</asp:Label>
            <asp:TextBox ID="YourMinStartingSalary" runat="server" TextMode="Range" CssClass="form-control" min="30000" max="120000" step="1000" ClientIDMode="Predictable" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Tell us what you think you're worth." ControlToValidate="YourMinStartingSalary" Display="None" />
            <asp:RangeValidator ID="SalaryRangeValidation" runat="server" ErrorMessage="Your requested salary should fall inside the range of $30,000 to $ 120,000" ControlToValidate="YourMinStartingSalary" MinimumValue="30000" MaximumValue="120000" Type="Integer" />

            <script type="text/javascript">
                // Are you enrolled in CPSC-1520, JavaScript Fundamentals, yet?
                const currencyFormat = function (num) {
                    // Credits: https://blog.abelotech.com/posts/number-currency-formatting-javascript/
                    return '$ ' + num.toString().replace(/(\d)(?=(\d{3})+(?!\d))/g, '$1,');
                }
                document.getElementById('<%: YourMinStartingSalary.ClientID %>')
                    .addEventListener('change', function (evt) {
                        let value = currencyFormat(evt.target.value);
                        let label = document.getElementById('<%: Label4.ClientID %>');
                        label.innerHTML = 'Expected Starting Salary: <b>' + value + '</b>';
                    })
            </script>

            <asp:LinkButton ID="ApplyForJob" runat="server" CssClass="btn btn-primary" OnClick="ApplyForJob_Click">Apply Today!</asp:LinkButton>
        </div>
        <div class="col-md-8">
            <h4><i>You Pay, We Code!</i></h4>
            <p class="lead">We are a company of highly trusted developers! (Trust us.)</p>
            <i>Your information is important to us, and we value your privacy.</i>

            <asp:ValidationSummary ID="ValidationSummary" runat="server" HeaderText="Please correct the following information before submitting your form." />

            <asp:GridView ID="ApplicationsGridView" runat="server" CssClass="table table-hover"></asp:GridView>
        </div>
    </div>

</asp:Content>
