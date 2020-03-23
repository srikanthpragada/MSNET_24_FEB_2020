﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModifyProduct.aspx.cs" Inherits="webdemo.adonet.ModifyProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" DataKeyNames="prodid" DataSourceID="SqlDataSource1" >
            <Fields>
                <asp:BoundField DataField="prodid" HeaderText="prodid" InsertVisible="False" ReadOnly="True" SortExpression="prodid" />
                <asp:BoundField DataField="prodname" HeaderText="prodname" SortExpression="prodname" />
                <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                <asp:BoundField DataField="qoh" HeaderText="qoh" SortExpression="qoh" />
                <asp:BoundField DataField="remarks" HeaderText="remarks" SortExpression="remarks" />
                <asp:BoundField DataField="catcode" HeaderText="catcode" SortExpression="catcode" />
                <asp:CommandField ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:msdb %>" 
            DeleteCommand="DELETE FROM [products] WHERE [prodid] = @prodid" InsertCommand="INSERT INTO [products] ([prodname], [price], [qoh], [remarks], [catcode]) VALUES (@prodname, @price, @qoh, @remarks, @catcode)" 
            SelectCommand="SELECT * FROM [products]"
            UpdateCommand="UPDATE [products] SET [prodname] = @prodname, [price] = @price, [qoh] = @qoh, [remarks] = @remarks, [catcode] = @catcode WHERE [prodid] = @prodid">
            <DeleteParameters>
                <asp:Parameter Name="prodid" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="prodname" Type="String" />
                <asp:Parameter Name="price" Type="Decimal" />
                <asp:Parameter Name="qoh" Type="Int32" />
                <asp:Parameter Name="remarks" Type="String" />
                <asp:Parameter Name="catcode" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="prodname" Type="String" />
                <asp:Parameter Name="price" Type="Decimal" />
                <asp:Parameter Name="qoh" Type="Int32" />
                <asp:Parameter Name="remarks" Type="String" />
                <asp:Parameter Name="catcode" Type="String" />
                <asp:Parameter Name="prodid" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        
    </form>
</body>
</html>
