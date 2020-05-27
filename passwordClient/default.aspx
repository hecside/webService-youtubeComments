<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="passwordClient._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </p>
        <div>
            <div style="height: 120px">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Youtube Comment Service"></asp:Label>
                <br />
                Select Youtube video from dropdown<br />
                will return 5 comments from said video</div>
        </div>
    <div>
    
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" DataMember="d" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="MCypOL90TYk">❌ WE&#39;RE DELETING A CARD ❌ ...and adding a new one! 😲 Clash Royale</asp:ListItem>
            <asp:ListItem Value="Iy10ibSMjP4">The Best Oculus Quest Games | THE ULTIMATE LIST</asp:ListItem>
            <asp:ListItem Value="_I0-am2e7S4">Oculus Quest VR On a Plane: Best Games Review</asp:ListItem>
        </asp:DropDownList>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
    
    </div>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Call Comments" />
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Height="530px" ReadOnly="True" TextMode="MultiLine" Width="640px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
