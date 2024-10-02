<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="newfarmer.aspx.cs" Inherits="pdd.newfarmer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html lang="en">
<head>
  <meta charset="UTF-8">
  <link href="signin.css" rel="Stylesheet" />
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
  <title>Sign-in form</title>
 
</head>
<body>
<form runat="server">
 <div class="container" style="margin-top:5%;padding:25px">
     

     <div class="rounded-2" style="margin-left:20%;margin-right:20%; padding:25px; background-color:rgba(255,255,255,0.8)">
            <h3>Farmer Registration</h3>
     <asp:TextBox ID="txtfullname" placeholder="Enter Full Name" class="form-control form-control-sm" MaxLength="50" runat="server"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
         ErrorMessage="Enter Full Name" ControlToValidate="txtfullname" ForeColor="Red"></asp:RequiredFieldValidator>

     <asp:TextBox ID="txtmobile" placeholder="Enter Mobile Number" class="form-control form-control-sm" MaxLength="10" runat="server"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
         ErrorMessage="Enter Mobile Number" ControlToValidate="txtmobile" 
         ForeColor="Red"></asp:RequiredFieldValidator>

     <asp:TextBox ID="txtpass" placeholder="Enter Password" 
                class="form-control form-control-sm" MaxLength="10" runat="server" 
                TextMode="Password"></asp:TextBox>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
         ErrorMessage="Enter Password" ControlToValidate="txtpass" ForeColor="Red"></asp:RequiredFieldValidator>
   
    <div>
        <asp:Button ID="btnsubmit" class="btn btn-sm btn-success" runat="server" 
            Text="Submit" onclick="btnsubmit_Click" />
        <asp:Button ID="btncancel" class="btn btn-sm btn-danger" 
            CausesValidation="false" runat="server" Text="Cancel" 
            onclick="btncancel_Click" />
    </div>
    </div>

 </div>
  
</form>
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>

</body>
</html>