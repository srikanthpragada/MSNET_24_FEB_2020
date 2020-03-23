<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="webdemo.adonet.ProductDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:DataList ID="DataList1" runat="server" DataKeyField="prodid" 
            RepeatLayout="Flow"
            DataSourceID="SqlDataSource1">
            <HeaderTemplate>
                <h2>List Of Products</h2>
            </HeaderTemplate>
            <ItemTemplate>
                 <%# Eval("prodname") %> <br />
                 <%# Eval("price") %> 
            </ItemTemplate>
            <SeparatorTemplate>
                <hr />
            </SeparatorTemplate>
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:msdb %>" SelectCommand="SELECT * FROM [products]"></asp:SqlDataSource>
        
    </form>
</body>
</html>
