<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Interaccion.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Nombre:<br />
            <asp:TextBox runat="server" id="txtNombre"></asp:TextBox><br />
            <asp:Button runat="server" ID="btnSaludar" Text="Saludar" OnClick="btnSaludar_Click" />
            <asp:label runat="server" ID="lblSaludo">ACA VA EL SALUDO</asp:label>
        </div>
    </form>
</body>
</html>
