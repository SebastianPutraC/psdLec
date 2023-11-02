<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="psdLec.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server" class="login_form_frame" autocomplete="off">
        <div class="login_form">
            <div class="login_label">
                <label>Email</label>
                <asp:Label ID="warn_login" runat="server" class="warning" Text="* Email atau Password yang dimasukkan tidak tepat"></asp:Label>
            </div>
            <asp:TextBox ID="login_email" runat="server" />
            <label>Kata Sandi</label>
            <asp:TextBox ID="login_password" runat="server" TextMode="Password" class="password_login" />
            <div class="login_buttons">
                <asp:Button ID="login_account" runat="server" Text="Login" class="login_account" OnClick="login_account_Click" />
                <asp:Button ID="to_register" runat="server" Text="Register" class="login_account" OnClick="to_register_Click" />
            </div>
            <div class="remember_me">
                <label>Remember Me</label>
                <asp:CheckBox ID="remember" runat="server" />
            </div>
        </div>
    </form>
</body>
</html>
