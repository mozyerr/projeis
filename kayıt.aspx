<%@ Page Language="C#" AutoEventWireup="true" CodeFile="kayit.aspx.cs" Inherits="kayit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table border="1" style="height: 414px; width: 563px">
           <tr><td class="auto-style2"> 
               <asp:Label ID="Label12" runat="server" Text="Kategori:"></asp:Label>
               </td>
               <td class="auto-style1"> 
                   <asp:DropDownList ID="DropDownList1" runat="server">
                       <asp:ListItem Value="4">Öğrenci</asp:ListItem>
                       <asp:ListItem Value="5">Normal</asp:ListItem>
                       <asp:ListItem Value="6">Personel</asp:ListItem>
                       <asp:ListItem Value="7">Müdür</asp:ListItem>
                       <asp:ListItem Value="8">Müdür Yardımcısı</asp:ListItem>
                   </asp:DropDownList>
               </td>
            </tr>
           <tr><td class="auto-style2"> 
               <asp:Label ID="Label1" runat="server" Text="Adı :"></asp:Label>
               </td>
               <td class="auto-style1"> 
                   <asp:TextBox ID="TextBox1" runat="server" Width="164px"></asp:TextBox>
               </td>
            </tr>
           <tr>
           <td class="auto-style2">  
               <asp:Label ID="Label2" runat="server" Text="Soyadı :"></asp:Label>
           </td>
               <td class="auto-style1"> 
                   <asp:TextBox ID="TextBox2" runat="server" Width="164px"></asp:TextBox>
           </td>
           </tr>
           <tr>
           <td class="auto-style2">  
               <asp:Label ID="Label11" runat="server" Text="Cinsiyet:"></asp:Label>
               (B/E)</td>
               <td class="auto-style1"> 
&nbsp;<asp:RadioButton ID="RadioButton1" runat="server" />
                   <asp:RadioButton ID="RadioButton2" runat="server" Checked="True" />
               </td>
           </tr>
           <tr>
           <td class="auto-style2"> 
               <asp:Label ID="Label3" runat="server" Text="Öğrenci No:"></asp:Label>
           </td>
               <td class="auto-style1"> 
                   <asp:TextBox ID="TextBox11" runat="server" Width="164px"></asp:TextBox>
           </td>
            </tr>
           <tr>
           <td class="auto-style2">   
               <asp:Label ID="Label4" runat="server" Text="Şifre:"></asp:Label>
           </td> <td class="auto-style1"> 
               <asp:TextBox ID="TextBox4" runat="server" Width="164px"></asp:TextBox>
           </td>
        
           </tr>
             <tr>
            <td class="auto-style2">   
                <asp:Label ID="Label5" runat="server" Text="Şifre(Tekrar):"></asp:Label>
           </td> <td class="auto-style1"> 
               <asp:TextBox ID="TextBox5" runat="server" Width="164px"></asp:TextBox>
           </td>
           </tr>
             <tr>
            <td class="auto-style2">   
                <asp:Label ID="Label6" runat="server" Text="Mail:"></asp:Label>
           </td><td class="auto-style1"> 
               <asp:TextBox ID="TextBox6" runat="server" Width="164px"></asp:TextBox>
           </td>
                   </tr>
           <tr>
            <td class="auto-style2">   
                <asp:Label ID="Label7" runat="server" Text="Tel No:"></asp:Label>
           </td><td class="auto-style1"> 
               <asp:TextBox ID="TextBox7" runat="server" Width="164px"></asp:TextBox>
           </td>
               </tr>
           <tr>
           <td class="auto-style2">   
               Nick</td><td class="auto-style1"> 
               <asp:TextBox ID="TextBox8" runat="server" Width="164px"></asp:TextBox>
           </td>
               </tr>
           <tr>
           <td class="auto-style2">   
               Label</td><td class="auto-style1"> 
               <asp:TextBox ID="TextBox9" runat="server" Width="164px"></asp:TextBox>
           </td>
               </tr>
           <tr>
             <td class="auto-style2">   
                 <asp:Label ID="Label10" runat="server" Text="Label" Visible="False"></asp:Label>
           </td><td class="auto-style1"> 
               <asp:TextBox ID="TextBox10" runat="server" Width="164px" Visible="False"></asp:TextBox>
           </td> 
           </tr>

           <tr>
            <td> 
              
                <asp:Button ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click" />
              
           </td>
                 </tr>
       </table>
    </div>
    </form>
</body>
</html>
