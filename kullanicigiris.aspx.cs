using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace kelepir.Yonetim
{
    public partial class kullanicigiris : System.Web.UI.Page
    {
        SqlConnection baglanti = new SqlConnection("Data Source=M_AKIFEREN; Database=Database_kelepirci;Integrated Security=true ");
   
        protected void Page_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from kullanicigiris where nick='" + TextBox1.Text + "' and password='" + TextBox2.Text + "' ";

            Label3.Text = "";
            if (TextBox1.Text != "" && TextBox2.Text != "")
            {
                SqlCommand cmd = new SqlCommand(sql, baglanti);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                if (dt.Rows.Count > 0)
                {
                    Session["userID"] = dt.Rows[0]["k_id"].ToString();
                    Response.Redirect("Default.aspx");
                }

            }

            else
            {
                Label3.Text = "Hatalı Giriş!";
            }

        }
    }
}
