<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="newGrid.aspx.cs" Inherits="ass32.newGrid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" align="center" AutoGenerateColumns="False" DataKeyNames="empid" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting">
                <Columns>
                    <asp:BoundField DataField="name" HeaderText="Name" />
                    <asp:BoundField DataField="email" HeaderText="Email" />
                    <asp:BoundField DataField="phone" HeaderText="Phone" />
                    <asp:BoundField DataField="age" HeaderText="Age" />
                    <asp:CommandField HeaderText="Corrections" ShowEditButton="True" />
                    <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />
                    <asp:HyperLinkField DataNavigateUrlFields="empid" DataNavigateUrlFormatString="Details.aspx?eid={0}" HeaderText="View More" InsertVisible="False" Text="Go" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
