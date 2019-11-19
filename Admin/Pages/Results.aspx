<%@ Page Title="" Language="C#" MasterPageFile="AdminMaster.master" AutoEventWireup="true" CodeFile="Results.aspx.cs" Inherits="Admin_Pages_Results" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
        <asp:DropDownList ID="DropDownList1" style="margin-left:40px" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Height="30px" Width="99px">
           <asp:ListItem>CO</asp:ListItem>
            <asp:ListItem>IF</asp:ListItem>
            <asp:ListItem>ME</asp:ListItem>
            <asp:ListItem>EE</asp:ListItem>
            <asp:ListItem>CE</asp:ListItem>
            <asp:ListItem>EJ</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left:40px" Height="30px" Width="99px" placeholder="dd/mm/yyyy"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" style="font-weight: 700; margin-left:80px;" Text="Get Results" BorderStyle="None" Height="35px" Width="123px" BackColor="#FF55A3" OnClick="Button1_Click" />
            </p>
    <p>
        &nbsp;</p>
    <p style="margin-left:100px;">
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            </p>
</asp:Content>

