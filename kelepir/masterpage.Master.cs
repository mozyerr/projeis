using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
namespace kelepir
{
    public partial class masterpage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userID"] != null)
            {
                ligiris.Visible = false;
                liuser.Visible = true;
                licikis.Visible = true;
                KullaniciBilgiGetir();
            }
            else
            {
                liuser.Visible = false;
                licikis.Visible = false;
            }

        }
        void KullaniciBilgiGetir()
        {
            try
            {
                SqlConnection baglan = new SqlConnection("Data Source=M_AKIFEREN; Database=Database_kelepirci;Integrated Security=true ");


                string sql = "select * from kullanicigiris where k_id='" + Session["userID"].ToString();
                DataTable dt = new DataTable();
                if (dt.Rows.Count > 0)
                {
                    lblUser.Text = dt.Rows[0]["nick"].ToString();
                }
            }
            catch (Exception)
            {


            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Default.aspx");
        }

    }
}