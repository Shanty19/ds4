<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Lab15_4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        Suma de 2 números<br />
        <br />
        Introducir el primer número:<br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br /><br />

        Introducir el Segundo número:<br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br /><br />

        <asp:Button ID="Button1" runat="server" Text="Sumar" OnClick="Button1_Click" />
        <br /><br />

        <asp:Label ID="Label1" runat="server" Text="Resultado"></asp:Label> :
        <asp:TextBox ID="TextBox3" runat="server" ReadOnly="true"></asp:TextBox>

        <br /><br />
    </form>
</body>
</html>
