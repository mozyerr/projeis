using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace kelepir
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LinkButton lnk = this.Master.FindControl("LinkButton1") as LinkButton;
            if (Session["userID"] != null)
            {
                KullaniciBilgiGetir();

                lnk.Visible = true;
            }
            else {

               lnk.Visible = false;
            
            }
        }

        void KullaniciBilgiGetir()
        {
            try
            {
                SqlConnection baglan = new SqlConnection("Data Source=M_AKIFEREN; Database=Database_kelepirci;Integrated Security=true ");


                string sql = "select * from kullanicigiris where k_id='" + Session["userID"].ToString();
                DataTable dt = new DataTable();
               
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