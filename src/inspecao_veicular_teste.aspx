<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inspecao_veicular_teste.aspx.cs" Inherits="creaweb.webservices.ws.art.inspecao_veicular_teste" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
		<asp:Button runat="server" ID="cmdTestarWS" Text="Call webservice" OnClick="cmdTestarWS_OnClick"/>
		<asp:BulletedList runat="server" ID="bltErros"></asp:BulletedList>
    </div>
    </form>
</body>
</html>
