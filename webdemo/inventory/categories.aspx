<%@ Page Title="Categories" Language="C#" MasterPageFile="~/inventory/Inventory.Master" AutoEventWireup="true" CodeBehind="categories.aspx.cs" Inherits="webdemo.inventory.categories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Categories</h2>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="catcode" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="catcode" HeaderText="catcode" ReadOnly="True" SortExpression="catcode" />
            <asp:BoundField DataField="catdesc" HeaderText="catdesc" SortExpression="catdesc" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:msdb %>" SelectCommand="SELECT * FROM [categories]"></asp:SqlDataSource>
</asp:Content>
