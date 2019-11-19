<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FeedBack.aspx.cs" Inherits="exams_FeedBack" %>

<!DOCTYPE html>
<html lang="en">
<head>
	<title>FeedBack</title>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<link rel="icon" type="image/png" href="assetsFB/images/icons/favicon.ico"/>
	<link rel="stylesheet" type="text/css" href="assetsFB/vendor/bootstrap/css/bootstrap.min.css">
	<link rel="stylesheet" type="text/css" href="assetsFB/fonts/font-awesome-4.7.0/css/font-awesome.min.css">
	<link rel="stylesheet" type="text/css" href="assetsFB/fonts/iconic/css/material-design-iconic-font.min.css">
	<link rel="stylesheet" type="text/css" href="assetsFB/vendor/animate/animate.css">
	<link rel="stylesheet" type="text/css" href="assetsFB/vendor/css-hamburgers/hamburgers.min.css">
	<link rel="stylesheet" type="text/css" href="assetsFB/vendor/animsition/css/animsition.min.css">
	<link rel="stylesheet" type="text/css" href="assetsFB/vendor/select2/select2.min.css">
	<link rel="stylesheet" type="text/css" href="assetsFB/vendor/daterangepicker/daterangepicker.css">
	<link rel="stylesheet" type="text/css" href="assetsFB/vendor/noui/nouislider.min.css">
	<link rel="stylesheet" type="text/css" href="assetsFB/css/util.css">
	<link rel="stylesheet" type="text/css" href="assetsFB/css/main.css">
</head>
<body>
	<div class="container-contact100">
		<div class="wrap-contact100">
			<form class="contact100-form validate-form" runat="server">
				<span class="contact100-form-title">
					Feedback
				</span>

				<div class="wrap-input100 validate-input bg1" data-validate="Please Type Your Name">
					<span class="label-input100">FULL NAME *</span>
                    <asp:TextBox ID="TextBox1" class="input100" runat="server" placeholder="Enter your name" ReadOnly="True"></asp:TextBox>
				</div>

				<div class="wrap-input100 validate-input bg1 rs1-wrap-input100" data-validate = "Enter Your Email (e@a.x)">
					<span class="label-input100">Email *</span>
					<asp:TextBox ID="TextBox2" class="input100" runat="server" placeholder="Enter your Email"></asp:TextBox>
				</div>

				<div class="wrap-input100 bg1 rs1-wrap-input100">
					<span class="label-input100">Phone</span>
					<asp:TextBox ID="TextBox3" class="input100" runat="server" placeholder="Enter your Phone Number"></asp:TextBox>
				</div>

				<div class="wrap-input100 input100-select bg1">
					<span class="label-input100">How was the system *</span>
					<div>
						<select class="js-select2" name="service">
							<option>Good</option>
                            <option>Poor</option>
							<option>Best</option>
							<option>Can't say</option>
						</select>
						<div class="dropDownSelect2"></div>
					</div>
				</div>

				<div class="w-full dis-none js-show-service">
					<div class="wrap-contact100-form-radio">
						<span class="label-input100">What is your profession?</span>

						<div class="contact100-form-radio m-t-15">
                            <asp:RadioButton ID="RadioButton1" runat="server" />
								Student
						</div>

						<div class="contact100-form-radio">
							<asp:RadioButton ID="RadioButton2"  runat="server" />
								Teacher
						</div>

						<div class="contact100-form-radio">
							<asp:RadioButton ID="RadioButton3" runat="server" />
                            Other
						</div>
					</div>

					<div class="wrap-contact100-form-range">
						<span class="label-input100">Rating *</span>

						<div class="contact100-form-range-value">
							<span id="value-lower"> 1 </span> - <span id="value-upper">10</span>
                            <asp:Label ID="Label1" name="from-value" runat="server"></asp:Label>
                            <asp:Label ID="Label2" name="to-value" runat="server"></asp:Label>
						</div>

						<div class="contact100-form-range-bar">
							<div id="filter-bar"></div>
						</div>
					</div>
				</div>

				<div class="wrap-input100 validate-input bg0 rs1-alert-validate" data-validate = "Please Type Your Message">
					<span class="label-input100">Message</span>
                    <asp:TextBox ID="TextBox4" class="input100" placeholder="How can we imrove.." runat="server"></asp:TextBox>
				</div>

				<div class="container-contact100-form-btn">
                    <asp:Button ID="Button1" class="contact100-form-btn" runat="server" Text="Submit" OnClick="Button1_Click" />
				</div>
			</form>
		</div>
	</div>


	<script src="assetsFB/vendor/jquery/jquery-3.2.1.min.js"></script>
	<script src="assetsFB/vendor/animsition/js/animsition.min.js"></script>
	<script src="assetsFB/vendor/bootstrap/js/popper.js"></script>
	<script src="assetsFB/vendor/bootstrap/js/bootstrap.min.js"></script>
	<script src="assetsFB/vendor/select2/select2.min.js"></script>
	<script>
	    $(".js-select2").each(function () {
	        $(this).select2({
	            minimumResultsForSearch: 20,
	            dropdownParent: $(this).next('.dropDownSelect2')
	        });


	        $(".js-select2").each(function () {
	            $(this).on('select2:close', function (e) {
	                if ($(this).val() == "Please chooses") {
	                    $('.js-show-service').slideUp();
	                }
	                else {
	                    $('.js-show-service').slideUp();
	                    $('.js-show-service').slideDown();
	                }
	            });
	        });
	    })
	</script>
	<script src="assetsFB/vendor/daterangepicker/moment.min.js"></script>
	<script src="assetsFB/vendor/daterangepicker/daterangepicker.js"></script>
	<script src="assetsFB/vendor/countdowntime/countdowntime.js"></script>
	<script src="assetsFB/vendor/noui/nouislider.min.js"></script>
	<script>
	    var filterBar = document.getElementById('filter-bar');

	    noUiSlider.create(filterBar, {
	        start: [1, 10],
	        connect: true,
	        range: {
	            'min': 1,
	            'max': 10
	        }
	    });

	    var skipValues = [
	    document.getElementById('value-lower'),
	    document.getElementById('value-upper')
	    ];

	    filterBar.noUiSlider.on('update', function (values, handle) {
	        skipValues[handle].innerHTML = Math.round(values[handle]);
	        $('.contact100-form-range-value input[name="from-value"]').val($('#value-lower').html());
	        $('.contact100-form-range-value input[name="to-value"]').val($('#value-upper').html());
	    });
	</script>
	<script src="assetsFB/js/main.js"></script>

<!-- Global site tag (gtag.js) - Google Analytics -->
<script async src="https://www.googletagmanager.com/gtag/js?id=UA-23581568-13"></script>
<script>
    window.dataLayer = window.dataLayer || [];
    function gtag() { dataLayer.push(arguments); }
    gtag('js', new Date());

    gtag('config', 'UA-23581568-13');
</script>

</body>
</html>
