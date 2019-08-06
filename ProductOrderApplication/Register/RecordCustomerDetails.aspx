<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RecordCustomerDetails.aspx.cs" Inherits="ProductOrderApplication.RecordCustomerDetails" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  <div>
    <table class="auto-style1">
      <tr>
        <td>
          <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
        </td>
        <td>
          <asp:TextBox ID="username" runat="server" required="true"></asp:TextBox>
        </td>
      </tr>

      <tr>
        <td>
          <asp:Label ID="Label7" runat="server" Text="Surname"></asp:Label>
        </td>
        <td>
          <asp:TextBox ID="surname" runat="server" required="true"></asp:TextBox>
        </td>
      </tr>

      <tr>
        <td>
          <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        </td>
        <td>
          <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        </td>
      </tr>

      <tr>
        <td>
          <asp:Label ID="Label3" runat="server" Text="Confirm Password"></asp:Label>
        </td>
        <td>
          <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
        </td>
      </tr>
      <tr>
        <td>
          <asp:Label ID="Label4" runat="server" Text="Address type"></asp:Label>
        </td>
        <td>
          <asp:RadioButton ID="RadioButton1" runat="server" GroupName="address" Text="Residential" />
          <asp:RadioButton ID="RadioButton2" runat="server" GroupName="address" Text="Business" />
        </td>
      </tr>
      <tr>
        <td>
          <asp:Label ID="Label5" runat="server" Text="Select Area type"></asp:Label>s
        </td>
        <td>
          <asp:CheckBox ID="CheckBox1" runat="server" Text="City" />
          <asp:CheckBox ID="CheckBox2" runat="server" Text="Suburb" />
        </td>
      </tr>
      <tr>
        <td>
        </td>
        <td>
          <br />
          <asp:Button ID="Button1" runat="server" Text="Register" CssClass="btn btn-primary" OnClick="Button1_Click" />
        </td>
      </tr>
    </table>
    <asp:Label ID="message" runat="server" Font-Size="Medium" ForeColor="Blue"></asp:Label>
  </div>
  <table class="auto-style1">
    <tr>
      <td class="auto-style2">
        <asp:Label ID="ShowUserNameLabel" runat="server"></asp:Label>
      </td>
      <td>
        <asp:Label ID="ShowUserName" runat="server"></asp:Label>
      </td>
    </tr>

    <tr>
      <td class="auto-style2">
        <asp:Label ID="ShowSurnameLabel" runat="server"></asp:Label>
      </td>
      <td>
        <asp:Label ID="ShowSurname" runat="server"></asp:Label>
      </td>
    </tr>

    <tr>
      <td class="auto-style2">
        <asp:Label ID="ShowEmailIDLabel" runat="server"></asp:Label>
      </td>
      <td>
        <asp:Label ID="ShowEmail" runat="server"></asp:Label>
      </td>
    </tr>
    <tr>
      <td class="auto-style3">
        <asp:Label ID="ShowResidentialLabel" runat="server"></asp:Label>
      </td>
      <td class="auto-style4">
        <asp:Label ID="ShowResidential" runat="server"></asp:Label>
      </td>
    </tr>
    <tr>
      <td class="auto-style2">
        <asp:Label ID="ShowCityLabel" runat="server"></asp:Label>
      </td>
      <td>
        <asp:Label ID="ShowCity" runat="server"></asp:Label>
      </td>
    </tr>
  </table>
</asp:Content>