<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formIn.aspx.cs" Inherits="ass32.formIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 align="center">Employee Registation Form</h2>
            <table align="center">
                <tr>
                    <td>Name</td> 
                    <td>
                        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>Phone</td>
                    <td>
                        <asp:TextBox ID="txtphone" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>Age</td>
                    <td>
                        <asp:TextBox ID="txtage" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>

                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
