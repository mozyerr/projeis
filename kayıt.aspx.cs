using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class kayit : System.Web.UI.Page
{
    SqlConnection baglanti = new SqlConnection("Data Source=M_AKIFEREN; Database=Database_Project;Integrated Security=true ");

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        try
        {
            baglanti.Open();
            string sql = "insert into Kullanici (uname,ulname,ogrno,passw,cinsiyet,ukat_kod,nick,phone,mail) values (@a,@b,@c,@d,@e,@f,@g,@h,@i)";
            SqlCommand spParam = new SqlCommand(sql, baglanti);

            spParam.Parameters.AddWithValue("@a", TextBox1.Text);
            spParam.Parameters.AddWithValue("@b", TextBox2.Text);
            spParam.Parameters.AddWithValue("@c", TextBox11.Text);
            spParam.Parameters.AddWithValue("@d", TextBox4.Text);
            spParam.Parameters.AddWithValue("@h", TextBox7.Text);
            bool cinsiyet;
            if (RadioButton1.Checked == true)
                cinsiyet = true;
            else cinsiyet = false;
            spParam.Parameters.AddWithValue("@e", cinsiyet);
            spParam.Parameters.AddWithValue("@f", DropDownList1.SelectedValue);
            spParam.Parameters.AddWithValue("@g", TextBox8.Text);
            spParam.Parameters.AddWithValue("@i", TextBox6.Text);
            TextBox9.Text = "BaşardınızzzzzzZZZzzz";
            SqlCommand komut = new SqlCommand("select * from Kullanici", baglanti);
            DataTable tb = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter(komut);
            spParam.ExecuteNonQuery();
            adtr.Fill(tb);
            baglanti.Close();
        }
        catch(Exception) {
            throw;
        }
        /*
      string  adi = TextBox1.Text;
      string  soyadi = TextBox2.Text;
      string telno = TextBox7.Text;
      string  ogrencino = TextBox11.Text;
      string nick = TextBox8.Text;
      string  sifre = TextBox4.Text;
        string mail=TextBox6.Text; 
        bool cinsiyet;
        if (RadioButton1.Checked==true)
            cinsiyet=true;
        else cinsiyet=false;
        SqlCommand komut = new SqlCommand();
        komut.Connection = baglanti;
        if (TextBox4.Text == TextBox5.Text)
        {
            komut.CommandText = "insert into kullanici (uname,ulname,ogrno,passw,cinsiyet,u_katkod,nick,phone,mail) values (" + adi + "," + soyadi + "," + ogrencino + "," + sifre + "," + cinsiyet + "," + DropDownList1.SelectedValue + "," + nick + "," + telno + "," + mail +")";
            komut.ExecuteReader();
        }
        baglanti.Close();
        
       
       */
                   

       // AdminWork.kullaniciOlustur(DropDownList1.SelectedIndex, TextBox1.Text, TextBox2.Text, int.Parse(TextBox11.Text), TextBox8.Text, TextBox4.Text);
    }
    
}
