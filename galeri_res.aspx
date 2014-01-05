<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="galeri_res.aspx.cs" Inherits="kelepir.Yonetim.galeri_res" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .buttonkaydet
        {}
        .fl-space2 {}
        .datatable {
            width: 335px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
   <div id="data-table">
        <br />
      <asp:FileUpload ID="FileUpload1" runat="server" />
<asp:Button ID="btnUpload" runat="server" Text="Upload"
OnClick="btnUpload_Click" />
<br />
<asp:Label ID="lblMessage" runat="server" Text=""
Font-Names = "Arial"></asp:Label>
        <asp:Label ID="UploadDetails" runat="server" Text="UploadDetails"></asp:Label>
       
        

       



       
        <table class="style1 datatable">
            <thead>
                <tr>

                    <th>Resim
                    </th>
                    <th>#
                    </th>
                    <th>
                        <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                    </th>
                    
                </tr>
            </thead>
            <tbody>
                <%--  <asp:Repeater OnItemCommand="Repeater1_ItemCommand" ID="Repeater1" runat="server">
                    <ItemTemplate>--%>
                        <tr>
                            <td>
                                <asp:Label Visible="false" ID="lblID" runat="server" Text='<%#Eval ("Id") %>'></asp:Label><%#Eval("Id") %>
                                
                            </td>
                            
                            
                                <td>
                                    &nbsp;</td>
                            
                            
                            
                            
                        </tr>


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
                         &nbsp;<asp:Calendar ID="Calendar1" runat="server" Height="98px" Width="236px"></asp:Calendar>
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

                  <%--  </ItemTemplate>
                </asp:Repeater>--%>
            </tbody>
        </table>
       <table class="style1 datatable">

          <tr>
              <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns = "False"
Font-Names = "Arial" Caption = "Yüklediğim İlanlar" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Width="1185px">
                  <AlternatingRowStyle BackColor="#DCDCDC" />
<Columns>
    <asp:BoundField DataField = "bid" HeaderText = "bid" />
    <asp:BoundField DataField = "Name" HeaderText = "Name" />
    <asp:BoundField DataField = "tur" HeaderText = "Tür" />
    <asp:BoundField DataField = "marka" HeaderText = "Marka" />
    <asp:BoundField DataField = "model" HeaderText = "Model" />
    <asp:BoundField DataField = "fiyat" HeaderText = "Fiyat" />
    <asp:BoundField DataField = "girilen_tarih" HeaderText = "İlan Gir. Tar." />
    <asp:BoundField DataField = "aciklama" HeaderText = "Açıklama" />
    <asp:ImageField DataImageUrlField = "bid"
        DataImageUrlFormatString = "galeri_res.aspx?ImageID={0}"
     ControlStyle-Width = "100" ControlStyle-Height = "100"
     HeaderText = "Preview Image">
   



<ControlStyle Height="100px" Width="100px"></ControlStyle>
    </asp:ImageField>
  <asp:CommandField ShowEditButton="true" />
   <asp:CommandField ShowDeleteButton="true" />
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
        
    </form>
</body>
</html>
