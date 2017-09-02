<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengePhunWithStrings.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            1. Reverse your name:<br />
            <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="reverseButton1" runat="server" OnClick="reverseButton1_Click" Text="Reverse!" />
            <br />
            <br />
            <asp:Label ID="nameLabel" runat="server"></asp:Label>
            <br />
            <br />
            <hr />
        </div>
        <div>
            2. Reverse the Order of These Names: Luke, Leia, Han, Chewbacca<br />
            <br />
            <asp:Button ID="reverseButton2" runat="server" OnClick="reverseButton2_Click" Text="Reverse!" />
            <br />
            <br />
            <asp:Label ID="herosLabel" runat="server"></asp:Label>
            <br />
            <br />
            <hr />
        </div>
        <div>
            3. Star Wars heros ASCII art:<br />
            <br />
            <asp:Button ID="artButton" runat="server" OnClick="artButton_Click" Text="ART!" />
            <br />
            <br />
            <asp:Label ID="artLabel" runat="server"></asp:Label>
            <br />
            <br />
            <hr />
        </div>
        <div>
            4. Solve this puzzle:<br />
            NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.<br />
            <br />
            <asp:Button ID="solveButton" runat="server" OnClick="solveButton_Click" Text="Solve!" />
&nbsp;<br />
            <br />
            <asp:Label ID="sentenceLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
