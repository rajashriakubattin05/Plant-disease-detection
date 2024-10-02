<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="farmer_login.aspx.cs" Inherits="pdd.farmer_login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 <meta name="viewport" content="width=device-width, initial-scale=1.0">
 <link rel="stylesheet" href="login.css">
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">


</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
    <h4 class="text-center text-primary mt-2 mb.4">Login Here</h4>
    <div class="loginform">
      
        <div class="mb-3">
          <label  class="form-label">Mobile Number</label>
          <asp:TextBox runat="server" class="form-control" ID="txtmobile" MaxLength="10"  placeholder="Enter Mobile Number"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ErrorMessage="Enter Mobile Number" ControlToValidate="txtmobile" 
                ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <div class="mb-3">
          <label  class="form-label">Password</label>
          <asp:TextBox runat="server" TextMode="Password" class="form-control" 
                MaxLength="10"  placeholder="Enter Password" ID="txtpass"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ErrorMessage="Enter Password" ControlToValidate="txtpass" ForeColor="Red"></asp:RequiredFieldValidator>
        </div>
        <asp:Button runat="server" class="btn btn-sm btn-success" Text="Login" 
            ID="btnlogin" onclick="btnlogin_Click" />
        <asp:Button runat="server" type="reset" text="New Farmer Registration" 
            ID="btnreg" CausesValidation="False" 
            CssClass="btn btn-sm btn-primary" onclick="btnreg_Click"/>
        
        
     
    </div>
    
  </div>
  
    </form>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>

</body>
</html>
