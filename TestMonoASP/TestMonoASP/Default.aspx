<%@ Page Language="C#" Inherits="TestMonoASP.Default" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html>
<head runat="server">
	<title>Default</title>
</head>
<body>
	<form id="form1" runat="server">
		<asp:Label id="lblHead" runat="server" Text="Welcome"/>	<br/>

		<asp:Table id="tableView" runat="server" GridLines="Both" CssClass="tableView">
		<asp:TableRow>
			<asp:TableCell>
				<asp:Label id="lblEmail" runat="server" Text="E-Mail:" />
			</asp:TableCell>
			<asp:TableCell>
				<asp:TextBox id="txtEmail" runat="server" />
			</asp:TableCell>
		</asp:TableRow>

		<asp:TableRow>
			<asp:TableCell>
				<asp:Label id="lblLastName" runat="server" Text="Last Name:" />
			</asp:TableCell>
			<asp:TableCell>
				<asp:TextBox id="txtLastName" runat="server"/>
			</asp:TableCell>		
		</asp:TableRow>

		<asp:TableRow>
			<asp:TableCell>
				<asp:Label id="lblFirstName" runat="server" Text="First Name:" />
			</asp:TableCell>
			<asp:TableCell>
				<asp:TextBox id="txtFirstName" runat="server"/>
			</asp:TableCell>
		</asp:TableRow>

		<asp:TableRow>
			<asp:TableCell>
				<asp:Label id="lblWeight" runat="server" Text="Weight:" />
			</asp:TableCell>
			<asp:TableCell>
				<asp:TextBox id="txtWeight" runat="server"/>
			</asp:TableCell>
		</asp:TableRow>

		<asp:TableRow>
			<asp:TableCell>
				<asp:Label id="lblHeightFoot" runat="server" Text="Height in Feet"/>
			</asp:TableCell>
			<asp:TableCell>
				<asp:TextBox id="txtHeightFoot" runat="server"/> <br/>
			</asp:TableCell>
		</asp:TableRow>

		<asp:TableRow>
			<asp:TableCell>
				<asp:Label id="lblHeightInch" runat="server" Text="Height in Inches"/>
			</asp:TableCell>
			<asp:TableCell>
				<asp:TextBox id="txtHeightInch" runat="server"/> <br/>
			</asp:TableCell>
		</asp:TableRow>

		<asp:TableRow>
			<asp:TableCell>
				<asp:Button id="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click"/>
			</asp:TableCell>
			<asp:TableCell>
				<asp:Button id="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click"/>
			</asp:TableCell>
		</asp:TableRow>
		</asp:Table>

		<asp:RegularExpressionValidator id="validTxtEmail" runat="server" ErrorMessage="Must be a valid email." 
			ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"/>
	</form>
</body>
</html>
