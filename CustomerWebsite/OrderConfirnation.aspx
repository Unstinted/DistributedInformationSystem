<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="OrderConfirnation.aspx.cs" Inherits="OrderConfirnation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
Order have been created !
 <SCRIPT LANGUAGE="JavaScript">
     function redireccionar() {
         setTimeout("location.href='Order.aspx'", 5000);
     }
  </SCRIPT>

</asp:Content>

