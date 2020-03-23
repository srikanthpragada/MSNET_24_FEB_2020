<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sales.aspx.cs" Inherits="webdemo.adonet.sales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Sales of Product [<%=Request.QueryString["id"]%>]</h1>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="invno" DataSourceID="SqlDataSource1" EmptyDataText="Sorry! No sales found!">
                <Columns>
                    <asp:BoundField DataField="invno" HeaderText="invno" InsertVisible="False" ReadOnly="True" SortExpression="invno" />
                    <asp:BoundField DataField="prodid" HeaderText="prodid" SortExpression="prodid" />
                    <asp:BoundField DataField="transdate" HeaderText="transdate" SortExpression="transdate" />
                    <asp:BoundField DataField="qty" HeaderText="qty" SortExpression="qty" />
                    <asp:BoundField DataField="amount" HeaderText="amount" SortExpression="amount" />
                </Columns>
                <EmptyDataRowStyle BackColor="Red" Font-Bold="True" Font-Size="20pt" ForeColor="White" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:msdb %>" SelectCommand="SELECT * FROM [sales] WHERE ([prodid] = @prodid)">
                <SelectParameters>
                    <asp:QueryStringParameter Name="prodid" QueryStringField="id" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
