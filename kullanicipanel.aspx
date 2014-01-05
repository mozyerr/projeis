<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="kullanicipanel.aspx.cs" Inherits="kelepir.kullanicipanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="data-table">
        <br />
<br />
       
        

       



       
        <table class="style1 datatable" title="Yüklediğim İlanlar">
            <thead>
                <tr>

                    <th>Resim
                    </th>
                    <th>
      <asp:FileUpload ID="FileUpload1" runat="server" />
                  
                   
                    
                </tr>
            </thead>
            <tbody>
                <%--  <asp:Repeater OnItemCommand="Repeater1_ItemCommand" ID="Repeater1" runat="server">
                    <ItemTemplate>--%>
                        


                   <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="TÜR"></asp:Label>
                            </td>
                                
                           <td>
                               <asp:DropDownList ID="DropDownList1" runat="server">
                                   <asp:ListItem Value="BeyazEsya">Beyaz Eşya</asp:ListItem>
                                   <asp:ListItem Value="Mobilya">Mobilya</asp:ListItem>
                                   <asp:ListItem Value="Elektronik">Elektronik</asp:ListItem>
                               </asp:DropDownList>
            
                            </td>
                           
                        </tr>

                <tr>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="MARKA"></asp:Label>
                            </td>
                                
                           <td>
                         <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            
                            </td>
                           
                        </tr>
                 <tr>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="MODEL"></asp:Label>
                            </td>
                                
                           <td>
                         <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            
                            </td>
                           
                        </tr>
                 <tr>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="FİYAT"></asp:Label>
                            </td>
                                
                           <td>
                         <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            
                            </td>
                           
                        </tr>
                <tr>
                            <td>
                                <asp:Label ID="Label7" runat="server" Text="TARİH"></asp:Label>
                            </td>
                                
                           <td>
                               <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                         </td>
                           
                        </tr>
                 <tr>
                            <td>
                                <asp:Label ID="Label5" runat="server" Text="AÇIKLAMA"></asp:Label>
                            </td>
                                
                           <td>
                         <asp:TextBox ID="TextBox6" runat="server" Height="135px" Width="236px"></asp:TextBox>
            
                            </td>
                           
                        </tr>
                <tr>
                            <td>
                         
                                &nbsp;</td>
                                
                           <td>
 
       
        

       



       
        &nbsp;&nbsp;
                                                 
<asp:Button ID="btnUpload" runat="server" Text="Upload"
OnClick="btnUpload_Click" />
                  
                   
                    
                            </td>
                           
                        </tr>
                  <%--  </ItemTemplate>
                </asp:Repeater>--%>
            </tbody>
        </table>
       <table class="style1 datatable">

          <tr>
              <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns = "False"
Font-Names = "Arial" Caption = "Yüklediğim İlanlar" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Width="220px" PageIndex="1" ShowFooter="True">
                  <AlternatingRowStyle BackColor="#DCDCDC" />
<Columns>
    <asp:BoundField DataField = "bid" HeaderText = "bid" />
    <asp:BoundField DataField = "Name" HeaderText = "Name" />
    <asp:BoundField DataField = "tur" HeaderText = "Tür" />
    <asp:BoundField DataField = "marka" HeaderText = "Marka" />
    <asp:BoundField DataField = "model" HeaderText = "Model" />
    <asp:BoundField DataField = "fiyat" HeaderText = "Fiyat" />
    <asp:BoundField DataField = "girilen_tarih" HeaderText = "İlan Gir. Tar."  />
    <asp:BoundField DataField = "aciklama" HeaderText = "Açıklama" />
    <asp:ImageField DataImageUrlField = "bid"
        DataImageUrlFormatString = "kullanicipanel.aspx?ImageID={0}"
     ControlStyle-Width = "100" ControlStyle-Height = "220"
     HeaderText = "Preview Image">
   <ControlStyle Height="100px" Width="220px"></ControlStyle>
    </asp:ImageField>
</Columns>

<Columns>
   <asp:TemplateField>
   <HeaderTemplate>
      <asp:Button ID="ButtonDelete" runat="server" Text="Delete" />
   </HeaderTemplate>
   <ItemTemplate>
      <asp:CheckBox ID="CheckBox1" runat="server" />
   </ItemTemplate>
   </asp:TemplateField>
</Columns> 


                  <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                  <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                  <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                  <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                  <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                  <SortedAscendingCellStyle BackColor="#F1F1F1" />
                  <SortedAscendingHeaderStyle BackColor="#0000A9" />
                  <SortedDescendingCellStyle BackColor="#CAC9C9" />
                  <SortedDescendingHeaderStyle BackColor="#000065" />

</asp:GridView>


             
          </tr>


       </table>


    </div>
    

</asp:Content>
