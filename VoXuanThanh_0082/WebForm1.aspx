<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="VoXuanThanh_0082.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
		<asp:Image ID="Image1" runat="server" CssClass="logo" ImageUrl="~/img/Anh_bia_summer_sale_holiday_podium_display_on_yellow_background.jpg" />
		<header>
			<nav class="menu">
				<asp:HyperLink ID="HyperLink1" runat="server">Trang chủ</asp:HyperLink>
				<asp:HyperLink ID="HyperLink2" runat="server">Giới thiệu</asp:HyperLink>
				<asp:HyperLink ID="HyperLink3" runat="server">Vật tư</asp:HyperLink>
				<asp:HyperLink ID="HyperLink4" runat="server">Khuyến mãi</asp:HyperLink>			
				<asp:HyperLink ID="HyperLink5" runat="server">Tin tức</asp:HyperLink>
				<asp:HyperLink ID="HyperLink6" runat="server">Liên hệ</asp:HyperLink>
			</nav>
		</header>
		<section>
			<div class="left">
				<asp:RadioButtonList ID="RadioButtonList1" runat="server"></asp:RadioButtonList>
			</div>
			<div class="right">
				<asp:GridView ID="GridView1" runat="server" ShowHeader="false">
				</asp:GridView>
				<asp:Button ID="btn_thongke" runat="server" Text="Thống kê" class="button" />
			</div>
		</section>
		<footer>
			Võ Xuân Thành - 28211100082
		</footer>
    </form>
</body>
</html>
