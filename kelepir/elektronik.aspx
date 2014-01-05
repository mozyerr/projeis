<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="elektronik.aspx.cs" Inherits="kelepir.elektronik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns = "False"
Font-Names = "Arial" Caption = "Yüklenen İlanlar" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Width="965px" PageIndex="1" ShowFooter="True">
                  <AlternatingRowStyle BackColor="#DCDCDC" />
<Columns>
   
    <asp:BoundField DataField = "tur" HeaderText = "Tür" />
    <asp:BoundField DataField = "marka" HeaderText = "Marka" />
    <asp:BoundField DataField = "model" HeaderText = "Model" />
    <asp:BoundField DataField = "fiyat" HeaderText = "Fiyat" />
    <asp:BoundField DataField = "girilen_tarih" HeaderText = "İlan Gir. Tar."  />
     <asp:BoundField DataField = "telefon" HeaderText = "TELEFON" />
    <asp:BoundField DataField = "aciklama" HeaderText = "Açıklama" />
    <asp:ImageField DataImageUrlField = "bid"
        DataImageUrlFormatString = "kullanicipanel.aspx?ImageID={0}"
     ControlStyle-Width = "100" ControlStyle-Height = "320"
     HeaderText = "Preview Image">
    <ControlStyle Height="100px" Width="100px"></ControlStyle>
    </asp:ImageField>
    
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
</asp:Content>
