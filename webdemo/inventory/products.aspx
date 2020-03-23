<%@ Page Title="" Language="C#" MasterPageFile="~/inventory/Inventory.Master" AutoEventWireup="true" CodeBehind="products.aspx.cs" Inherits="webdemo.inventory.products" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Products </h2>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="prodid" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="prodid" HeaderText="prodid" InsertVisible="False" ReadOnly="True" SortExpression="prodid" />
            <asp:BoundField DataField="prodname" HeaderText="prodname" SortExpression="prodname" />
            <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
            <asp:BoundField DataField="qoh" HeaderText="qoh" SortExpression="qoh" />
            <asp:BoundField DataField="remarks" HeaderText="remarks" SortExpression="remarks" />
            <asp:BoundField DataField="catcode" HeaderText="catcode" SortExpression="catcode" />
        </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:msdb %>" SelectCommand="SELECT * FROM [products]"></asp:SqlDataSource>
   


</asp:Content>
