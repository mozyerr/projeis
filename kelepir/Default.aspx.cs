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
            //LinkButton btnEdit = this.Master.FindControl("btnEdit") as LinkButton;
            //LinkButton btnDelete = this.Master.FindControl("btnDelete") as LinkButton;

            if (Session["userID"] != null)
            {
                KullaniciBilgiGetir();

                lnk.Visible = true;
                //btnEdit.Visible = true;
                //btnDelete.Visible = true;
                
            }
            else {

               lnk.Visible = false;
               //btnDelete.Visible = false;
               //btnEdit.Visible = false;
            
            }
//==============================================================================================================================


               if (Request.QueryString["ImageID"] != null)
            {
                string strQueryy = "select * from esyakayit";
                String strConnStringg = System.Configuration.ConfigurationManager.ConnectionStrings["conString"].ConnectionString;




                SqlCommand cmdd = new SqlCommand(strQueryy);
                cmdd.Parameters.Add("@bid", SqlDbType.Int).Value = Convert.ToInt32(Request.QueryString["ImageID"]);

                SqlConnection conn = new SqlConnection(strConnStringg);
                SqlDataAdapter sdaa = new SqlDataAdapter();

                cmdd.CommandType = CommandType.Text;
                cmdd.Connection = conn;
                DataTable dtt = new DataTable();


                try
                {
                    conn.Open();
                    sdaa.SelectCommand = cmdd;
                    sdaa.Fill(dtt);

                }
                catch
                {
                    dtt = null;
                }
                finally
                {
                    conn.Close();
                    sdaa.Dispose();
                    conn.Dispose();
                }
                if (dtt != null)
                {
                    Byte[] bytes = (Byte[])dtt.Rows[0]["Data"];
                    Response.Buffer = true;
                    Response.Charset = "";
                    Response.Cache.SetCacheability(HttpCacheability.NoCache);
                    Response.ContentType = dtt.Rows[0]["ContentType"].ToString();
                    Response.AddHeader("content-disposition", "attachment;filename="
                        + dtt.Rows[0]["Name"].ToString());
                    Response.BinaryWrite(bytes);
                    Response.Flush();
                    Response.End();
                }
            }

            //================================================================================================================================

            DataTable dt = new DataTable();
            String strConnString = System.Configuration.ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            string strQuery = "select * from esyakayit";
            SqlCommand cmd = new SqlCommand(strQuery);
            SqlConnection con = new SqlConnection(strConnString);
            SqlDataAdapter sda = new SqlDataAdapter();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            try
            {
                con.Open();
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();


            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                con.Close();
                sda.Dispose();
                con.Dispose();
                dt.Dispose();
            }







        
        

        }
//==========================================================================================================================================
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

        void KullaniciBilgiGetir(string Query)
        {
            try
            {
                SqlConnection baglan = new SqlConnection("Data Source=M_AKIFEREN; Database=Database_kelepirci;Integrated Security=true ");


                // string sql = "select * from kullanicigiris where k_id='" + Session["userID"].ToString();
                baglan.Open();
                using (SqlCommand comm = new SqlCommand(Query +
                              ";select ", baglan))
                {
                    SqlDataAdapter da = new SqlDataAdapter(comm);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                }
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