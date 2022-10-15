<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="calculator_using__btn_textbox.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" Font-Size="50px" runat="server" Height="60px" OnClick="Button1_Click" Text="open calculator" Width="500px" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/calculator.aspx">open calculator</asp:HyperLink>
        </div>
    </form>
</body>
</html>
