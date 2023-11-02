<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="psdLec.Views.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <body>
        <form runat="server" class="register_form" autocomplete="off">
            <div class="register_label">
                <label>Nama Asli</label>
                <asp:Label ID="warn_name" runat="server" class="warning" Text="* Anda perlu mengisi nama asli anda di kolom ini"></asp:Label>
            </div>
            <asp:TextBox ID="register_realname" runat="server" placeholder="Contoh: Andi Pratama" /></asp:TextBox>
            <div class="register_label">
                <label>Nomor telepon</label>
                <asp:Label ID="warn_phone" runat="server" class="warning" Text="* Anda perlu mengisi nomor telepon di kolom ini"></asp:Label>
            </div>
            <asp:TextBox ID="register_phone" runat="server" placeholder="Contoh: 08123456789" /></asp:TextBox>
            <div class="register_label">
                 <label>Email</label>
                 <asp:Label ID="warn_email" runat="server" class="warning" Text="* Anda perlu mengisi email anda di kolom ini"></asp:Label>
            </div>
            <asp:TextBox ID="register_email" runat="server" placeholder="Contoh: andi@gmail.com" /></asp:TextBox>
            <div class="register_label">
                <label>Kata Sandi</label>
                <asp:Label ID="warn_password" runat="server" class="warning" Text="* Anda perlu membuat password untuk akun anda"></asp:Label>
            </div>
            <asp:TextBox ID="register_password" runat="server" placeholder="********" TextMode="Password" class="password" /></asp:TextBox>
            <div class="login_buttons">
                <asp:Button ID="register_account" runat="server" Text="Register" class="register_account" OnClick="register_account_Click"/>
                <asp:Button ID="to_login" runat="server" Text="Punya Akun?" class="register_account" OnClick="to_login_Click"/>
            </div>
        </form>
    </body>
</html>
