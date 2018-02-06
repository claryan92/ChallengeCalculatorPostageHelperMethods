﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeCalcPostageHelperMethod.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        	Postage Calculator<br />
			<br />
			Width:&nbsp;
			<asp:TextBox ID="widthTextBox" runat="server" AutoPostBack="True" OnTextChanged="handleChange"></asp:TextBox>
			<br />
			Height:&nbsp;
			<asp:TextBox ID="heightTextBox" runat="server" AutoPostBack="True" OnTextChanged="handleChange"></asp:TextBox>
			<br />
			Length:&nbsp;
			<asp:TextBox ID="lengthTextBox" runat="server" AutoPostBack="True" OnTextChanged="handleChange"></asp:TextBox>
			<br />
			<br />
			<asp:RadioButton ID="groundRadioButton" runat="server" AutoPostBack="True" GroupName="methodGroup" OnCheckedChanged="handleChange" Text="Ground" />
			<br />
			<asp:RadioButton ID="airRadioButton" runat="server" AutoPostBack="True" GroupName="methodGroup" OnCheckedChanged="handleChange" Text="Air" />
			<br />
			<asp:RadioButton ID="nextdayRadioButton" runat="server" AutoPostBack="True" GroupName="methodGroup" OnCheckedChanged="handleChange" Text="Next Day" />
			<br />
			<br />
			<asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
