using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Data.SqlClient;
using System.IO;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Configuration;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Specialized;

namespace kelepir
{
    public partial class mobilya : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ImageID"] != null)
            {
                string strQueryy = "select * from esyakayit where tur like 'M%'";
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
            string strQuery = "select * from esyakayit where tur like 'M%'"; ;
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
    }
}