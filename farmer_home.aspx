<%@ Page Title="" Language="C#" MasterPageFile="~/farmer.Master" AutoEventWireup="true" CodeBehind="farmer_home.aspx.cs" Inherits="pdd.farmer_home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<div class="container" style="margin-top:5%; padding:25px">
    
        <h3>Disease Detection</h3>
        <h5>Please upload the image file to detect the disease</h5>
        <div class="rounded shadow" style="margin-top:25px; padding:20px; background-color:rgba(255,255,255,0.9)">
            <asp:FileUpload class="form-control form-control-sm" ID="FileUpload1" runat="server" />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ErrorMessage="Select File" ControlToValidate="FileUpload1" ForeColor="Red"></asp:RequiredFieldValidator>
            <br/>
                
            <asp:Button ID="btnupload" class="btn btn-sm btn-primary" runat="server" 
                Text="Upload" onclick="btnupload_Click" />   
            <asp:Button ID="Button1" class="btn btn-sm btn-primary" runat="server" Text="Detect" />   


        </div>

</div>


</asp:Content>
