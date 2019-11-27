<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentLogin.aspx.cs" Inherits="StudentLogin" %>

<!DOCTYPE html>
<script runat="server">
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1"/>
<!--===============================================================================================-->	
	<link rel="icon" type="image/png" href="Admin/Pages/images/icons/favicon.ico"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="Admin/Pages/vendor/bootstrap/css/bootstrap.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="Admin/Pages/fonts/font-awesome-4.7.0/css/font-awesome.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="Admin/Pages/fonts/Linearicons-Free-v1.0.0/icon-font.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="Admin/Pages/vendor/animate/animate.css"/>
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="Admin/Pages/vendor/css-hamburgers/hamburgers.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="Admin/Pages/vendor/animsition/css/animsition.min.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="Admin/Pages/vendor/select2/select2.min.css"/>
<!--===============================================================================================-->	
	<link rel="stylesheet" type="text/css" href="Admin/Pages/vendor/daterangepicker/daterangepicker.css"/>
<!--===============================================================================================-->
	<link rel="stylesheet" type="text/css" href="Admin/Pages/css/util.css"/>
	<link rel="stylesheet" type="text/css" href="Admin/Pages/css/main.css"/>
<!--===============================================================================================-->
</head>
<body>
    <form id="form1" runat="server">
    <div>
    	<div class="limiter">
		<div class="container-login100">
			<div class="wrap-login100 p-l-85 p-r-85 p-t-55 p-b-55">
				<a class="login100-form validate-form flex-sb flex-w">
					<span class="login100-form-title p-b-32">
						Student Login
					</span>

					<span class="txt1 p-b-11">
						First Name
					</span>
					<div class="wrap-input100 validate-input m-b-36" >
                        <asp:TextBox ID="TextBox1" class="input100" runat="server" required></asp:TextBox>
						<span class="focus-input100"></span>
					</div>

                    <span class="txt1 p-b-11">
						Last Name
					</span>
					<div class="wrap-input100 validate-input m-b-36" >
                        <asp:TextBox ID="TextBox2" class="input100" runat="server" required></asp:TextBox>
						<span class="focus-input100"></span>
					</div>

                    <span class="txt1 p-b-11">
						Class
					</span>
					<div class="wrap-input100 validate-input m-b-36" >
                        <asp:DropDownList ID="DropDownList1" class="input100" runat="server">
                            <asp:ListItem>CO</asp:ListItem>
                            <asp:ListItem>IF</asp:ListItem>
                            <asp:ListItem>EJ</asp:ListItem>
                            <asp:ListItem>CE</asp:ListItem>
                            <asp:ListItem>EE</asp:ListItem>
                            <asp:ListItem>ME</asp:ListItem>
                        </asp:DropDownList>
						<span class="focus-input100"></span>
					</div>

                    <span class="txt1 p-b-11">
						Roll No
					</span>
					<div class="wrap-input100 validate-input m-b-36">
                        <asp:TextBox ID="TextBox3" class="input100" runat="server" required></asp:TextBox>
						<span class="focus-input100"></span>
					</div>
					
					<span class="txt1 p-b-11">
						Enroll No
					</span>
					<div class="wrap-input100 validate-input m-b-36">
                        <asp:TextBox ID="TextBox4" class="input100" runat="server" required></asp:TextBox>
						<span class="focus-input100"></span>
					</div>

                    <span class="txt1 p-b-11">
						Subject
					</span>
					<div class="wrap-input100 validate-input m-b-36">
                        <asp:DropDownList ID="DropDownList2" class="input100" runat="server">
                            <asp:ListItem>Physics</asp:ListItem>
                            <asp:ListItem>Chemistry</asp:ListItem>
                        </asp:DropDownList>
						<span class="focus-input100"></span>
					</div>
					
					<br />
                    <br />

                    <asp:Button ID="Button1" class="login100-form-btn" runat="server" Text="Submit" OnClick="Button1_Click" />

				</a>
			</div>
		</div>
	</div>
	
<!--===============================================================================================-->
	<script src="Admin/Pages/vendor/jquery/jquery-3.2.1.min.js"></script>
<!--===============================================================================================-->
	<script src="Admin/Pages/vendor/animsition/js/animsition.min.js"></script>
<!--===============================================================================================-->
	<script src="Admin/Pages/vendor/bootstrap/js/popper.js"></script>
	<script src="Admin/Pages/vendor/bootstrap/js/bootstrap.min.js"></script>
<!--===============================================================================================-->
	<script src="Admin/Pages/vendor/select2/select2.min.js"></script>
<!--===============================================================================================-->
	<script src="Admin/Pages/vendor/daterangepicker/moment.min.js"></script>
	<script src="Admin/Pages/vendor/daterangepicker/daterangepicker.js"></script>
<!--===============================================================================================-->
	<script src="Admin/Pages/vendor/countdowntime/countdowntime.js"></script>
<!--===============================================================================================-->
	<script src="Admin/Pages/js/main.js"></script>
    </div>
    </form>
</body>
</html>
