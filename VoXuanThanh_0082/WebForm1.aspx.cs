using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace VoXuanThanh_0082
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		string chuoikn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IS385\VoXuanThanh_0082\VoXuanThanh_0082\App_Data\Database1.mdf;Integrated Security=True";
		protected void Page_Load(object sender, EventArgs e)
		{
			if (Page.IsPostBack) return;
			string sql = "select * from NhaCC";
			try
			{
				SqlDataAdapter da = new SqlDataAdapter(sql, chuoikn);
				DataTable dt = new DataTable();
				da.Fill(dt);
				this.RadioButtonList1.DataSource = dt;
				this.RadioButtonList1.DataTextField = "TenNCC";
				this.RadioButtonList1.DataValueField = "MaNCC";
				this.RadioButtonList1.DataBind();
			}
			catch (Exception ex)
			{
				Response.Write(ex.Message);
			}
			LoadThongKe();
		}
		private void LoadThongKe()
		{
			string sqlThongKe = "SELECT COUNT(*) AS TongSoVatTu, SUM(SoLuong) AS TongSoLuong FROM VatTu";
			try
			{
				using (SqlConnection conn = new SqlConnection(chuoikn))
				{
					conn.Open();
					SqlCommand cmd = new SqlCommand(sqlThongKe, conn);
					SqlDataReader reader = cmd.ExecuteReader();
					if (reader.Read())
					{
						// Tạo bảng mới theo chiều dọc
						DataTable dt = new DataTable();
						dt.Columns.Add("Tên thống kê");
						dt.Columns.Add("Giá trị");

						dt.Rows.Add("Tổng số vật tư", reader["TongSoVatTu"].ToString());
						dt.Rows.Add("Tổng số lượng", reader["TongSoLuong"].ToString());

						GridView1.DataSource = dt;
						GridView1.DataBind();
						GridView1.ShowHeader = false;

					}
					reader.Close();
				}
			}
			catch (Exception ex)
			{
				Response.Write("Lỗi thống kê: " + ex.Message);
				Server.Transfer("123.aspx);
			}
		}
	}
}