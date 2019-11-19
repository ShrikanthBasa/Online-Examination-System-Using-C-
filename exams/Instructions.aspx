<%@ Page Title="" Language="C#" MasterPageFile="~/exams/ExamMaster.master" AutoEventWireup="true" CodeFile="Instructions.aspx.cs" Inherits="exams_Instructions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
           <fieldset style="width:500; ; margin-left: 25px; margin-top:10px; text-align:center">
<legend><b style="FONT-SIZE: x-large; COLOR:red;">&nbsp;Instructions &nbsp;</b>
</legend>
        <br />
        <asp:Label ID="Label1" runat="server" margin-left="100px;" ForeColor="Red" style="font-size:x-large"></asp:Label>
               <br />
               <br />
        1.Before starting your examination read all the instructions carefully.
        <br />
        <br />
        2.You will be given questions according to your class and subject.
        <br />
        <br />
        3.You will be given four options for every question from which only one is correct.
        <br />
        <br />
        4.You will be provided with three buttons 
         <br />
        <img src="Button1.png" alt="Submit" />
               <br />
             "<--Previous" to Go to Previous Question
                <br />
             "Save answer" to Save the answer 
                <br />
             "Next-->" to Go to the next question
        <br />
        <br />
        5.You are also provided with option to jump to any question
        <br />
        <br />
        6.Once you save your answer it is saved and can be viewed at any time
        <br />
        <br />
        7.You can end your exam by clicking on End Exam or it automatically will submitted at end of the timer.
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" style="font-weight: 700;border-radius:10px" Text="Start exam" BorderStyle="None" Height="35px" Width="400px" OnClick="Button1_Click" BackColor="#FFCC66" />
        
        <p>&nbsp;</p></fieldset>
</asp:Content>

