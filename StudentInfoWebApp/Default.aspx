<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StudentInfoWebApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtStudentID" runat="server"></asp:TextBox>
            <asp:Button ID="btnGo" runat="server" Text="Go" OnClick="btnGo_Click" />
        </div>
        <div>
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </div>
        <div id="divStudentInfo" runat="server" visible="false">
            <table>
                <tr>
                    <td>Student ID :</td>
                    <td>
                        <asp:Label ID="lblStudentID" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Student Name :</td>
                    <td>
                        <asp:Label ID="lblName" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Gender :</td>
                    <td>
                        <asp:Label ID="lblGender" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>City :</td>
                    <td>
                        <asp:Label ID="lblCity" runat="server"></asp:Label></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
