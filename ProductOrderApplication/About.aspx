<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="ProductOrderApplication.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <p>Records customer details.
     A basic set of address fields is adequate, e.g. First Name, Surname, Address
     Type (Residential / Business), Street Address, Suburb, City/Town and Postal
     Code.</p>
</asp:Content>
