<%@ Page Title="" Language="C#" MasterPageFile="~/farmer.Master" AutoEventWireup="true" CodeBehind="history.aspx.cs" Inherits="pdd.history" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<div class="container" style="margin-top:5%; padding:25px">
    <center>
        <asp:GridView runat="server" ID="gvhistory" AutoGenerateColumns="False" 
            CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="fname" HeaderText="Farmer Name" />
                <asp:BoundField DataField="adate" HeaderText="Upload Date" />
            </Columns>
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <img src=<%#Eval("imgfile")%> height="100px" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        </center>
</div>

</asp:Content>
