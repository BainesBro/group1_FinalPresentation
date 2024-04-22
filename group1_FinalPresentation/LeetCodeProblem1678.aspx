<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LeetCodeProblem1678.aspx.cs" Inherits="group1_FinalPresentation.LeetCodeProblem1678" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
            <label for="txtCommand">Enter command:</label>
            <asp:TextBox ID="txtCommand" runat="server"></asp:TextBox>
            <asp:Button ID="btnInterpret" runat="server" Text="Interpret" OnClick="btnInterpret_Click" />
        </div>
        <div>
            <asp:Label ID="lblOutput" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
