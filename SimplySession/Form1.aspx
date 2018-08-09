<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Form1.aspx.cs" Inherits="Form1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
    <div>
    <table>  
        <tr>  
            <td>  
                Name  
            </td>  
            <td>  
                <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>  
            </td>  
            <td>  
                <asp:Button ID="BtnRedirect" runat="server" Text="Submit" OnClick="BtnRedirect_Click" />  
            </td>  
        </tr>  
          
    </table>  

    </div>
    </form>
</body>
</html>
