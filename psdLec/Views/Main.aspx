<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="psdLec.Views.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class ="button_form">
            <asp:Button ID="to_order" runat="server" Text="Order" class="main_button" OnClick="to_order_Click" />
            <asp:Button ID="to_transaction" runat="server" Text="Transaction" class="main_button" OnClick="to_transaction_Click" />
            <asp:Button ID="logout" runat="server" Text="Logout" class="main_button" OnClick="logout_Click"/>
        </div>
    </form>
</body>
</html>
