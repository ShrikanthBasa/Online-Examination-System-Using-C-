<%@ Page Title="" Language="C#" MasterPageFile="AdminMaster.master" AutoEventWireup="true" CodeFile="AddPhys.aspx.cs" Inherits="Admin_Pages_AddPhys" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <fieldset style="width:500; ; margin-left: 45px;margin-top:20px"">
<legend><b style="FONT-SIZE: x-large; COLOR: green">&nbsp;Physics &nbsp;</b>
</legend>
     <asp:Label ID="Label7" runat="server" style="margin-left:500px" ForeColor="#FF3300"></asp:Label>
     <br />
     <asp:Label ID="Label1" runat="server" Text="Question"></asp:Label><asp:TextBox ID="TextBox1" style="margin-left:47px;" runat="server" Width="362px" Height="30px"></asp:TextBox>
     <br />
     <br />
     <asp:Label ID="Label2" runat="server" Text="Option a"></asp:Label><asp:TextBox ID="TextBox2" style="margin-left:50px;" runat="server" Width="225px" Height="30px"></asp:TextBox>
     <br />
     <br />
     <asp:Label ID="Label3" runat="server" Text="Option b"></asp:Label><asp:TextBox ID="TextBox3" style="margin-left:50px;" runat="server" Width="225px" Height="30px"></asp:TextBox>
     <br />
     <br />
     <asp:Label ID="Label4" runat="server" Text="Option c"></asp:Label><asp:TextBox ID="TextBox4" style="margin-left:50px;" runat="server" Width="225px" Height="30px"></asp:TextBox>
     <br />
     <br />
     <asp:Label ID="Label5" runat="server" Text="Option d"></asp:Label><asp:TextBox ID="TextBox5" style="margin-left:50px;" runat="server" Width="225px" Height="30px"></asp:TextBox>
     <br />
     <br />
     <asp:Label ID="Label6" runat="server" Text="Correct"></asp:Label>&nbsp; <asp:TextBox ID="TextBox6" style="margin-left:50px;" runat="server" Width="225px" Height="30px"></asp:TextBox>
     <br />
     <br />
     <br />
     <asp:Button ID="Button1" runat="server" style="margin-left:70px;" Text="Add Data" OnClick="Button1_Click" />

 </fieldset>
</asp:Content>

