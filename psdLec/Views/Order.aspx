<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="psdLec.Views.Order" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server" class="order_form" autocomplete="off">
        <div class="order_label">
            <label>Which product do you want to buy?</label>
        </div>
        <asp:DropDownList ID="product_list" runat="server"></asp:DropDownList>
        <div class="order_label">
            <label>Which shipping type do you choose?</label>
        </div>
        <asp:DropDownList ID="shipping_list" runat="server"></asp:DropDownList>
        <div class ="order_buttons">
            <asp:Button ID="buy_button" runat="server" Text="Buy Product" OnClick="buy_button_Click" />
            <asp:Button ID="to_main" runat="server" Text="Back to Main" OnClick="to_main_Click" style="height: 26px" />
        </div>
    </form>
</body>
</html>
