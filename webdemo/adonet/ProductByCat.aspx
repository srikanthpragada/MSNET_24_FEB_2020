<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductByCat.aspx.cs" Inherits="WebDemo.adonet.ProductByCat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Products By Category</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Products By Category</h2>
        Category : <asp:DropDownList ID="ddlCategory" runat="server"
            DataSourceID="sdsCategories" 
            AutoPostBack="true"
            DataTextField="catdesc" 
            DataValueField="catcode"></asp:DropDownList>
        <asp:SqlDataSource ID="sdsCategories" runat="server" 
            ConnectionString="<%$ ConnectionStrings:msdb %>"
            SelectCommand="SELECT * FROM [categories]"></asp:SqlDataSource>
        <p></p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="prodid" DataSourceID="sdsProducts">
            <Columns>
                <asp:BoundField DataField="prodid" HeaderText="prodid" InsertVisible="False" ReadOnly="True" SortExpression="prodid" />
                <asp:BoundField DataField="prodname" HeaderText="prodname" SortExpression="prodname" />
                <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                <asp:BoundField DataField="qoh" HeaderText="qoh" SortExpression="qoh" />
                <asp:BoundField DataField="remarks" HeaderText="remarks" SortExpression="remarks" />
                <asp:BoundField DataField="catcode" HeaderText="catcode" SortExpression="catcode" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="sdsProducts" runat="server" ConnectionString="<%$ ConnectionStrings:msdb %>" SelectCommand="SELECT * FROM [products] WHERE ([catcode] = @catcode)">
            <SelectParameters>
                <asp:ControlParameter ControlID="ddlCategory" Name="catcode" PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <p></p>
         
        
    </form>
</body>
</html>
