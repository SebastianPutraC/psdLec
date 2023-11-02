<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Transaction.aspx.cs" Inherits="psdLec.Views.Transaction" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="DataList1" runat="server">
                <ItemTemplate>
                    <table>
                        <tr>
                            <td>
                                <b>ID: </b><span><%# Eval("ID") %></span><br />
                                <b>Product: </b><span><%# Eval("Product") %></span><br />
                                <b>Shipper: </b><span><%# Eval("Shipper")%></span><br />
                                <b>Date: </b><span><%# Eval("Date")%></span><br />
                                <b>Status: </b><span><%# Eval("Status")%></span><br />
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
