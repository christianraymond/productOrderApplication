<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegisterUser.aspx.cs" Inherits="ProductOrderApplication.RegisterUser" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h4 style="font-size: medium">Register a new user</h4>
        <hr />
        <p>
            <asp:Literal runat="server" ID="StatusMessage" />
        </p>                
        <div style="margin-bottom:10px">
            <asp:Label runat="server" AssociatedControlID="UserName">User name</asp:Label>
            <div>
                <asp:TextBox runat="server" ID="UserName" />                
            </div>
        </div>
        <div style="margin-bottom:10px">
            <asp:Label runat="server" AssociatedControlID="Surname">Surnname</asp:Label>
            <div>
                <asp:TextBox runat="server" ID="Surname" />                
            </div>
        </div>
        <div style="margin-bottom:10px">
            <asp:Label runat="server" AssociatedControlID="Telephone">Telephone</asp:Label>
            <div>
                <asp:TextBox runat="server" ID="Telephone" />                
            </div>
        </div>
        <div style="margin-bottom:10px">
            <asp:Label runat="server" AssociatedControlID="StreetAddress">Street Address</asp:Label>
            <asp:PlaceHolder ID="PlaceHolder1" runat="server">City/Suburb</asp:PlaceHolder>
            <div>
                <asp:TextBox runat="server" ID="StreetAddress" /> 
            </div>
        </div>
        <div style="margin-bottom:10px">
            <asp:Label runat="server" AssociatedControlID="AddressType">Address Type</asp:Label>
            <asp:PlaceHolder ID="PlaceHolder2" runat="server">Residential/ Business</asp:PlaceHolder>
            <div>
                <asp:TextBox runat="server" ID="AddressType" />                
            </div>
        </div>
        <div style="margin-bottom:10px">
            <asp:Label runat="server" AssociatedControlID="Password">Password</asp:Label>
            <div>
                <asp:TextBox runat="server" ID="Password" TextMode="Password" />                
            </div>
        </div>
        <div style="margin-bottom:10px">
            <asp:Label runat="server" AssociatedControlID="ConfirmPassword">Confirm password</asp:Label>
            <div>
                <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" />                
            </div>
        </div>
        <div>
            <div>
                <asp:Button runat="server" CssClass="btn btn-primary" OnClick="CreateUser_Click" Text="Register" />
            </div>
        </div>
    </div>
</asp:Content>