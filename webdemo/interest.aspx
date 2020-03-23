<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="interest.aspx.cs" Inherits="webdemo.interest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Interest Calculation</title>
</head>
<body>
    <form id="form1" runat="server">
       <h2>Interest Calculation</h2>
       Deposit Amount <br />
       <asp:TextBox ID="txtAmount" Required TextMode="Number" runat="server"></asp:TextBox>
       <p />
       Interest Rate <br />
       <asp:TextBox ID="txtRate" Required  TextMode="Number" runat="server"></asp:TextBox>
       <p />
       <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
       <p />
       <asp:Label ID="lblInterest" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
