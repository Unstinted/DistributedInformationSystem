<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Order.aspx.cs" Inherits="Order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        Customer Name:&nbsp;
        <asp:TextBox ID="CustTxt" runat="server" Width="196px"></asp:TextBox>
    </p>
    <p>
        <asp:Calendar ID="Ordate" runat="server" BackColor="#FFFFCC" 
            BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" 
            Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" 
            ShowGridLines="True" Width="220px">
            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
            <OtherMonthDayStyle ForeColor="#CC9966" />
            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
            <SelectorStyle BackColor="#FFCC66" />
            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" 
                ForeColor="#FFFFCC" />
            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
        </asp:Calendar>
    </p>
    <p>
        <asp:Calendar ID="ReqDate" runat="server"></asp:Calendar>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Ship To Name"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 4px" 
            Width="228px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Shipper"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" 
            Width="226px" DataTextField="CompanyName" DataValueField="ShipperID">
        </asp:DropDownList>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Ship To Address"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 4px" 
            Width="228px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Ship To City"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 4px" 
            Width="228px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="Ship To Province"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" style="margin-left: 4px" 
            Width="228px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label6" runat="server" Text="Ship To Postcode"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox6" runat="server" style="margin-left: 4px" 
            Width="228px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label7" runat="server" Text="Ship To Country"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
            Width="218px">
            <asp:ListItem Selected="True">Nigeria</asp:ListItem>
            <asp:ListItem>Vietnam</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="ORDER" 
            Width="175px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="CANCEL" Width="187px" />
    </p>
    <p>
        <asp:Button ID="Button3" runat="server" Text="ADD ORDER DETAILS" 
            Width="445px" />
    </p>
</asp:Content>

