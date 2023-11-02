<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sellers.aspx.cs" Inherits="psdLec.Views.Sellers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server" class="seller_form" autocomplete="off">
        <div class="seller_label">
            <label>From which seller do you want to buy the product?</label>
        </div>
        <asp:DropDownList ID="seller_list" runat="server"></asp:DropDownList>
        <div class ="order_buttons">
            <asp:Button ID="to_order" runat="server" Text="To Order" OnClick="to_order_Click" />
            <asp:Button ID="to_main" runat="server" Text="Back to Main" OnClick="to_main_Click" />
        </div>
    </form>
</body>
</html>
