<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Test.aspx.cs" Inherits="exams_Test" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 121px;
        }
    </style>
    <script type="text/javascript">
        function changeBgc(which) {
            cell1.style.backgroundColor = 'white';
            cell2.style.backgroundColor = 'white';
            cell3.style.backgroundColor = 'white';
            cell4.style.backgroundColor = 'white';
            document.getElementById(which).style.backgroundColor = '#90ee90';
        }
        function aler() {
            alert("You are going to the summary of your exam");
        }
    </script>
</head>
<body>
<form id="form1" runat="server">
<div>
<b style="font-size:x-large;color:green;">Question No :
<asp:Label ID="QNoLabel" runat="server" style="font-size:x-large"></asp:Label>
</b>   
<a href="Summary.aspx" style="color:red;font-size:large;margin-left:900px" onclick="aler()">SUBMIT/END EXAM</a>
<fieldset style="margin-top:10px;text-align:center">
<legend font-size: x-large; style="text-align:right">
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
</legend>
<a>
<asp:Label ID="ErrLabel" runat="server" Text="" ForeColor="Red"></asp:Label>
    </a>
          <table border="1" style="margin:0px auto; width: 911px;">
              <tr><th class="auto-style1" style="color: #0000FF; font-size: large;">Question</th><th>
                  <asp:TextBox ID="TextBox1" runat="server" Height="37px" Width="774px" ReadOnly="true" Columns="3"></asp:TextBox></th>
              </tr>
              <tr><th class="auto-style1" style="color: #0000FF">Marks</th><th>
                  <asp:Label ID="Label1" runat="server" Text="1"></asp:Label></th>
              </tr> 
              <tr><th class="auto-style1" style="color: #0000FF">Status</th><th>
                  <asp:Label ID="Label2" runat="server"></asp:Label></th>
              </tr>   
          </table>
          <br />
          <b style="font-size: 20px; color: #008000;">:::options:::<br />
          </b>
    <br />
          <table id="OptionTable" border="1" style="margin:0px auto; width: 911px; height: 180px;">
              <tr><th id="cell1" runat="server">1.<asp:RadioButton ID="RadioButton1" runat="server" Height="30px" GroupName="a" onclick="changeBgc('cell1')" /><asp:TextBox ID="TextBox2" runat="server" Height="30px" Width="390px" ReadOnly="true" Columns="2"></asp:TextBox></th>
                  <th id="cell2" runat="server">2.<asp:RadioButton ID="RadioButton2" runat="server" Height="30px" GroupName="a" onclick="changeBgc('cell2')" /><asp:TextBox ID="TextBox3" runat="server" Height="30px" Width="390px" Columns="2"></asp:TextBox></th>
              </tr>
              <tr><th id="cell3" runat="server">3.<asp:RadioButton ID="RadioButton3" runat="server" Height="30px" GroupName="a" onclick="changeBgc('cell3')" /><asp:TextBox ID="TextBox4" runat="server" Height="30px" Width="390px" ReadOnly="true" Columns="2"></asp:TextBox></th>
                  <th id="cell4" runat="server">4.<asp:RadioButton ID="RadioButton4" runat="server" Height="30px" GroupName="a" onclick="changeBgc('cell4')" /><asp:TextBox ID="TextBox5" runat="server" Height="30px" Width="390px" ReadOnly="true" Columns="2"></asp:TextBox></th>
              </tr>
          </table>
    
          <br />
          <p>
          <asp:Button ID="Button11" runat="server" style="margin-right:100px;border-radius:5px" Text="<-- Previous" Height="42px" Width="120px" OnClick="Button11_Click"  />
          <asp:Button ID="Button12" runat="server" style="margin-right:100px;border-radius:5px" Text="Save answer" Height="42px" Width="121px" OnClick="Button12_Click"  />
          <asp:Button ID="Button13" runat="server" style="border-radius:5px" Text="Next -->" Height="42px" Width="121px" OnClick="Button13_Click"  />
          </p>
          </fieldset>
    </div>
    <fieldset style="margin-top:10px;text-align:center">
        <legend style="text-align:center;color:#ff6a00;font-size:larger;">:: Jump To Question ::</legend>
        <br />
        <asp:Button ID="Button1" style="margin-left:20px;border-radius:15px" Height="25px" Width="45px" runat="server" Text="1" OnClick="Button1_Click" />
        <asp:Button ID="Button2" style="margin-left:20px;border-radius:15px" Height="25px" Width="45px" runat="server" Text="2" OnClick="Button2_Click" />
        <asp:Button ID="Button3" style="margin-left:20px;border-radius:15px" Height="25px" Width="45px" runat="server" Text="3" OnClick="Button3_Click1" />
        <asp:Button ID="Button4" style="margin-left:20px;border-radius:15px" Height="25px" Width="45px" runat="server" Text="4" OnClick="Button4_Click" />
        <asp:Button ID="Button5" style="margin-left:20px;border-radius:15px" Height="25px" Width="45px" runat="server" Text="5" OnClick="Button5_Click" />
        <asp:Button ID="Button6" style="margin-left:20px;border-radius:15px" Height="25px" Width="45px" runat="server" Text="6" OnClick="Button6_Click" />
        <asp:Button ID="Button7" style="margin-left:20px;border-radius:15px" Height="25px" Width="45px" runat="server" Text="7" OnClick="Button7_Click" />
        <asp:Button ID="Button8" style="margin-left:20px;border-radius:15px" Height="25px" Width="45px" runat="server" Text="8" OnClick="Button8_Click" />
        <asp:Button ID="Button9" style="margin-left:20px;border-radius:15px" Height="25px" Width="45px" runat="server" Text="9" OnClick="Button9_Click" />
        <asp:Button ID="Button10" style="margin-left:20px;border-radius:15px" Height="25px" Width="45px" runat="server" Text="10" OnClick="Button10_Click" />
        
        <br />
        <br />
        </fieldset>
    </form>
</body>
</html>

