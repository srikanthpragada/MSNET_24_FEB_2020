<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListProducts.aspx.cs" Inherits="webdemo.adonet.ListProducts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Products</h2>
        <asp:GridView Width="100%" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="prodid" 
            PageSize="5" DataSourceID="sdsProducts" AllowPaging="True" AllowSorting="True">
            <Columns>
                <asp:BoundField DataField="prodid" HeaderText="prodid" InsertVisible="False" ReadOnly="True" SortExpression="prodid" />
                <asp:BoundField DataField="prodname" HeaderText="prodname" SortExpression="prodname" />
                <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" DataFormatString="{0:######}" >
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="qoh" HeaderText="qoh" SortExpression="qoh" >
                <ItemStyle HorizontalAlign="Right" />
                </asp:BoundField>
                <asp:BoundField DataField="remarks" HeaderText="remarks" SortExpression="remarks" />
                <asp:BoundField DataField="catcode" HeaderText="catcode" SortExpression="catcode" />
                <asp:HyperLinkField DataNavigateUrlFields="prodid" DataNavigateUrlFormatString="sales.aspx?id={0}" Text="Sales" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="sdsProducts" runat="server" 
            ConnectionString="<%$ ConnectionStrings:msdb %>" 
            SelectCommand="SELECT * FROM [products]"></asp:SqlDataSource>
    </form>
</body>
</html>
