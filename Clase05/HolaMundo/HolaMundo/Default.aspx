<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HolaMundo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="a.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ¡Hola Mundo desde ASPX!<br />

            <% int numeroUno = 10 + 20; 
                Response.Write("Hola mundo desde el servidor"); %>
            <br />
            <asp:Label ID="lblHolaMundo" runat="server" Text="Hola mundo desde un componente de asp.net"></asp:Label>
        </div>
    </form>
</body>
</html>
