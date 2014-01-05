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
using System.Text;
namespace kelepir
{
    public partial class kullanicipanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            //===============================================================================================================================
            if (Request.QueryString["ImageID"] != null)
            {
                string strQueryy = "select * from esyakayit where bid=@bid";
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
            string strQuery = "select * from esyakayit where k_id=" + Convert.ToInt32(Session["userID"]);
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
//==================================================================================================================


         private Boolean InsertUpdateData(SqlCommand cmd)
        {
            String strConnString = System.Configuration.ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            SqlConnection con = new SqlConnection(strConnString);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                return false;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
        //=========================================================================================================
        private void BindGridData()
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);

            conn.Open();
            SqlCommand comm = new SqlCommand("select *  from esyakayit", conn);

            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();


        }
        //=========================================================================================================
      
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindGridData();

        }
        //=========================================================================================================
      
    protected void btnUpload_Click(object sender, EventArgs e)
        {
            // Read the file and convert it to Byte Array
            string filePath = FileUpload1.PostedFile.FileName;
            string filename = Path.GetFileName(filePath);
            string ext = Path.GetExtension(filename);
            string contenttype = String.Empty;

            //Set the contenttype based on File Extension
            switch (ext)
            {

                case ".jpg":
                    contenttype = "image/jpg";
                    break;
                case ".png":
                    contenttype = "image/png";
                    break;
                case ".gif":
                    contenttype = "image/gif";
                    break;
               
            }

        //========================================================================================================================================
           
        //==========================================================================================================================================


            if (contenttype != String.Empty)
            {

                Stream fs = FileUpload1.PostedFile.InputStream;
                BinaryReader br = new BinaryReader(fs);
                Byte[] bytes = br.ReadBytes((Int32)fs.Length);

                //insert the file into database
                string strQuery = "insert into esyakayit(Name, ContentType, Data,tur,marka,model,fiyat,girilen_tarih,k_id,aciklama)" +
                   " values (@Name, @ContentType, @Data,@tur,@marka,@model,@fiyat,@girilen_tarih,@k_id,@aciklama)";
                SqlCommand cmd = new SqlCommand(strQuery);
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = filename;
                cmd.Parameters.Add("@ContentType", SqlDbType.VarChar).Value= contenttype;
                cmd.Parameters.Add("@Data", SqlDbType.Binary).Value = bytes;
                cmd.Parameters.Add("@tur", SqlDbType.Text).Value = DropDownList1.SelectedItem.Text;
                cmd.Parameters.Add("@marka", SqlDbType.Text).Value = TextBox3.Text;
                cmd.Parameters.Add("@model", SqlDbType.Text).Value = TextBox4.Text;
                cmd.Parameters.Add("@fiyat", SqlDbType.Text).Value = TextBox5.Text;
                cmd.Parameters.Add("@girilen_tarih", SqlDbType.Text).Value = TextBox7.Text;
                cmd.Parameters.Add("@k_id", SqlDbType.Int).Value = Convert.ToInt32(Session["userID"]);
                cmd.Parameters.Add("@aciklama",SqlDbType.Text).Value = TextBox6.Text;
                InsertUpdateData(cmd);
                
            }
           
            Page.Response.Redirect(HttpContext.Current.Request.Url.ToString(), true);// sayfayı güncelleme
        //=========================================================================================================
     
        }
        //=====================================================================================================
    private void BindGridView()
    {

        DataTable dt = new DataTable();
        SqlConnection connection = new SqlConnection(GetConnectionString());

        try
        {
            connection.Open();
            string sqlStatement = "SELECT * FROM Customers";
            SqlCommand sqlCmd = new SqlCommand(sqlStatement, connection);
            SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);
            sqlDa.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
        catch (System.Data.SqlClient.SqlException ex)
        {
            string msg = "Fetch Error:";
            msg += ex.Message;
            throw new Exception(msg);
        }
        finally
        {
            connection.Close();
        }
    }
        //===========================================================================================================
    private void DeleteRecords(StringCollection sc)
    {
        SqlConnection conn = new SqlConnection(GetConnectionString());
        StringBuilder sb = new StringBuilder(string.Empty);

        foreach (string item in sc)
        {
            const string sqlStatement = "DELETE FROM esyakayit WHERE bid";
            sb.AppendFormat("{0}='{1}'; ", sqlStatement, item);
        }
        try
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
        }
        catch (System.Data.SqlClient.SqlException ex)
        {
            string msg = "Deletion Error:";
            msg += ex.Message;
            throw new Exception(msg);
        }
        finally
        {
            conn.Close();
        }
    }
        //====================================================================================================
    protected void ButtonDelete_Click(object sender, EventArgs e)
    {
        StringCollection sc = new StringCollection();
        string id = string.Empty;
        //loop the GridView Rows
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            CheckBox cb = (CheckBox)GridView1.Rows[i].Cells[0].FindControl("CheckBox1"); //find the CheckBox
            if (cb != null)
            {
                if (cb.Checked)
                {
                    id = GridView1.Rows[i].Cells[1].Text; // get the id of the field to be deleted
                    sc.Add(id); // add the id to be deleted in the StringCollection
                }
            }
        }

        DeleteRecords(sc); // call method for delete and pass the StringCollection values
        BindGridView(); // Bind GridView to reflect changes made here
    }
        //===============================================================================================
    private string GetConnectionString()
    {
        throw new NotImplementedException();
    }
        //=================================================================================================00

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.Header) //check for RowType
        {
            //access the LinkButton from the Header TemplateField using FindControl
            Button b = (Button)e.Row.FindControl("ButtonDelete");
            //attach the JavaScript function
            b.Attributes.Add("onclick", "return ConfirmOnDelete();");
        }
    }

   
        //=======================================================================================================
        }

     

    }
