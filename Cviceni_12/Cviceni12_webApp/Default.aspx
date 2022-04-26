<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Cviceni12_webApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;<asp:TextBox ID="Operand1" runat="server"></asp:TextBox>
            &nbsp;<asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Selected="True" Value="plus">+</asp:ListItem>
                <asp:ListItem Value="minus">-</asp:ListItem>
                <asp:ListItem Value="krat">*</asp:ListItem>
                <asp:ListItem Value="deleno">/</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="Operand2" runat="server"></asp:TextBox>
            <asp:Button ID="compute" runat="server" OnClick="compute_Click" Text="Spocti" />
        </div>
        &nbsp;</form>
</body>
</html>
