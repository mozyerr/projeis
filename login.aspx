<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="kelepir.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div style="height: 209px; width: 771px">
    <table border="1" style="height: 148px; width: 555px">
         <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>            
                   </td>
                            
                     <td>
                         <asp:TextBox ID="TextBox1" runat="server" Height="20px" Width="126px"></asp:TextBox>
                     </td>
                    
         </tr>
     <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                   </td>
                            
                     <td>
                         <asp:TextBox ID="TextBox2" runat="server" Height="25px" Width="129px"></asp:TextBox>
                     </td>
                    
         </tr>
         <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                   </td>
             <td>
                 <asp:Label ID="Label3" runat="server"></asp:Label>
                      </td>
     
         </tr>
        </table>
    </div>
</asp:Content>
