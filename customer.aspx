<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="Customer_Account_UI.Customer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 202px;
        }
        .auto-style3 {
            width: 348px;
        }
        .auto-style4 {
            width: 202px;
            height: 23px;
        }
        .auto-style5 {
            width: 348px;
            height: 23px;
        }
        .auto-style6 {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">WELCOME TO THE CUSTOMER LOGIN PAGE</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">Cutsomer Name</td>
            <td class="auto-style5">
                <asp:TextBox ID="TextBox1" runat="server" Width="155px"></asp:TextBox>
            </td>
            <td class="auto-style6">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter a valid name"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Gender</td>
            <td class="auto-style3">
                <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="156px">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                    <asp:ListItem>Others</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Date of birth</td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox2" runat="server" Width="155px"></asp:TextBox>
            </td>
            <td>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter a valid Date of birth" MaximumValue="2000-12-31" MinimumValue="1900-12-31" Type="Date"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Contact Number</td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox3" runat="server" Width="155px"></asp:TextBox>
            </td>
            <td>
                <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="Enter a valid number" MaximumValue="9999999999" MinimumValue="1000000000"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">City</td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox4" runat="server" Width="155px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox4" ErrorMessage="This field cannot be empty"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
                <asp:Button ID="Button1" runat="server" Text="Submit" Width="100px" OnClick="Button1_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>

<table class="auto-style1">
    <tr>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
        <td>
            &nbsp;</td>
    </tr>
</table>

</asp:Content>
