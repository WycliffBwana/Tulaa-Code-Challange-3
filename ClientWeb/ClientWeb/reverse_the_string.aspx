<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reverse_the_string.aspx.cs" Inherits="codeChallangeWebClient.reverse_the_string" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="align-content:center">
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtValue" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Input:"></asp:Label>
            <asp:Label ID="lblInput" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Output:"></asp:Label>
            <asp:Label ID="lblOutput" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>
