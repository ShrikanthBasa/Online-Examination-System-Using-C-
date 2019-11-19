<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Pages/AdminMaster.master" AutoEventWireup="true" CodeFile="AddAdmin.aspx.cs" Inherits="Admin_Pages_AddAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script type="text/javascript">
        function Showpass(){
            document.getElementById('CheckBox1').type = this.checked ? 'text' : 'password';
        }
    </script>
    <div class="container">
            <div class="row">
                <div class="col-md-4 col-md-offset-4">
                    <div class="login-panel panel panel-default">
                        <div class="panel-heading">
                            <h3 class="panel-title">Enter Details</h3>
                        </div>
                        <div class="panel-body">
                                <fieldset>
                                    <div class="form-group">
                                        <asp:TextBox ID="TextBox1" class="form-control" runat="server" placeholder="Full Name" required></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <asp:DropDownList ID="DropDownList1" class="form-control" placeholder="Department" runat="server">
                                            <asp:ListItem>CO</asp:ListItem>
                                            <asp:ListItem>IF</asp:ListItem>
                                            <asp:ListItem>EJ</asp:ListItem>
                                            <asp:ListItem>CE</asp:ListItem>
                                            <asp:ListItem>EE</asp:ListItem>
                                            <asp:ListItem>ME</asp:ListItem>
                                        </asp:DropDownList>

                                    </div>
                                    <div class="form-group">
                                        <asp:TextBox ID="TextBox2" class="form-control" runat="server" placeholder="UserName" required></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <asp:TextBox ID="TextBox3" class="form-control" runat="server" placeholder="Password" required></asp:TextBox>
                                    </div>
                                    <!-- Change this to a button or input when using this as a form -->
                                    <asp:Button ID="Button1" class="btn btn-lg btn-success btn-block" runat="server" Text="Add Admin" OnClick="Button1_Click" />
                                </fieldset>                           
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>

