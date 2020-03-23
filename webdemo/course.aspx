<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="course.aspx.cs" Inherits="webdemo.course" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Course Fee Calculator</title>
</head>
<body>
    <h2>Course Fee Calculator</h2>
    <form id="form1" runat="server">
        Date and Time : <asp:Label ID="lblTime" runat="server" Text=""></asp:Label>
        <p></p>
        Course : 
        <asp:DropDownList ID="ddlCourse" runat="server">
            <asp:ListItem Value="5000">Java SE</asp:ListItem>
            <asp:ListItem Value="6000">Python</asp:ListItem>
            <asp:ListItem Value="2000">Angular</asp:ListItem>
            <asp:ListItem Value="4000">Oracle Database</asp:ListItem>
        </asp:DropDownList>
        <p></p>
        Mode : 
        <asp:RadioButton ID="rbOffline" runat="server"
            Checked="true" Text ="Offline(Classroom)" GroupName="mode" />
        <asp:RadioButton ID="rbOnline" runat="server" 
            Text ="Online (Internet)" GroupName="mode" />
        <p></p>
        <asp:CheckBox ID="cbCourseMaterial" runat="server" Text="Printed Course Material" />
        <p></p>
        <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
        <p></p>
        <asp:Label ID="lblFee" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
