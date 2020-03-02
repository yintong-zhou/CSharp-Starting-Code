<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    </head>
<body style="height: 314px">
    <h3>Natural Language DASHBOARD demo</h3>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtSentiment" runat="server" Height="140px" Width="1040px" TextMode="MultiLine"></asp:TextBox>
        &nbsp;
        <br />
        <asp:Button ID="btnSentiment" runat="server" Text="SENTIMENT" Width="120px"  OnClick="btnSentiment_Click" Height="40px" ViewStateMode="Enabled"/>
        <br />
        <br />
        <asp:TextBox ID="txtEntities" runat="server" Height="140px" TextMode="MultiLine" Width="1040px"></asp:TextBox>
        <br />
    </div>
        <asp:Button ID="btnEntities" runat="server" Height="40px" OnClick="btnEntities_Click" Text="ENTITIES" Width="120px" />
        <br />
        <br />
        <asp:TextBox ID="txtSyntax" runat="server" Height="140px" TextMode="MultiLine" Width="1040px"></asp:TextBox>
        <br />
        <asp:Button ID="btnSyntax" runat="server" Height="40px" OnClick="btnSyntax_Click" Text="SYNTAX" Width="120px" />
    </form>
</body>
</html>
