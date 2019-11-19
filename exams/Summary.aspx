<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Summary.aspx.cs" Inherits="exams_Summary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <div style="text-align:center;font-family:'MV Boli'">
            SUMMARY OF YOUR EXAM
        </div>
<asp:ScriptManager ID= "SM1" runat="server"></asp:ScriptManager>
<asp:Timer ID="timer1" runat="server" Interval="1000" OnTick="timer1_tick"></asp:Timer>
<asp:UpdatePanel id="updPnl" runat="server" UpdateMode="Always">
<ContentTemplate>
<p style="text-align:right;font-size:x-large"><asp:Label ID="lblTimer" runat="server" Height="30px"></asp:Label></p> 
</ContentTemplate>
<Triggers>
<asp:AsyncPostBackTrigger ControlID="timer1" EventName ="tick" />
</Triggers>
 </asp:UpdatePanel>   
         <br />
    <div>
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    </div>
        <br />
        <br />
        <div style="text-align:center;">
        <asp:Button ID="Button1" style="border-radius:5px" runat="server" Height="42px" Width="200" Text="SUBMIT YOUR EXAM" OnClick="Button1_Click" />
        <asp:Button ID="Button2" style="border-radius:5px" runat="server" Height="42px" Width="200px" Text="GO BACK AND CHANGE" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
