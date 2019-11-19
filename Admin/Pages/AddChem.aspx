<%@ Page Title="" Language="C#" MasterPageFile="AdminMaster.master" AutoEventWireup="true" CodeFile="AddChem.aspx.cs" Inherits="Admin_Pages_AddChem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <fieldset style="width:500; ; margin-left: 45px;margin-top:20px">
<legend><b style="FONT-SIZE: x-large; COLOR: green">&nbsp;Chemistry &nbsp;</b>
</legend>
     <asp:Label ID="Label1" runat="server" style="margin-left:500px" ForeColor="#FF3300"></asp:Label>
        <br />
     <asp:Label ID="Label7" runat="server" Text="Question"></asp:Label><asp:TextBox ID="TextBox7" style="margin-left:47px;" runat="server" Width="362px" Height="30px" required></asp:TextBox>
     <br />
     <br />
     <asp:Label ID="Label8" runat="server" Text="Option a"></asp:Label><asp:TextBox ID="TextBox8" style="margin-left:50px;" runat="server" Width="225px" Height="30px" required></asp:TextBox>
     <br />
     <br />
     <asp:Label ID="Label9" runat="server" Text="Option b"></asp:Label><asp:TextBox ID="TextBox9" style="margin-left:50px;" runat="server" Width="225px" Height="30px" required></asp:TextBox>
     <br />
     <br />
     <asp:Label ID="Label10" runat="server" Text="Option c"></asp:Label><asp:TextBox ID="TextBox10" style="margin-left:50px;" runat="server" Width="225px" Height="30px" required></asp:TextBox>
     <br />
     <br />
     <asp:Label ID="Label11" runat="server" Text="Option d"></asp:Label><asp:TextBox ID="TextBox11" style="margin-left:50px;" runat="server" Width="225px" Height="30px" required></asp:TextBox>
     <br />
     <br />
     <asp:Label ID="Label12" runat="server" Text="Correct"></asp:Label>&nbsp; <asp:TextBox ID="TextBox12" style="margin-left:50px;" runat="server" Width="225px" Height="30px" required></asp:TextBox>
        <br />
     <br />
     <br />
     <asp:Button ID="Button2" runat="server" style="margin-left:70px;" Text="Add Data" OnClick="Button2_Click" />
 </fieldset>
</asp:Content>

