<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="CRUD.aspx.vb" Inherits="System_Tools.CRUD" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="container">
        <asp:GridView 
            ID="GrillaPrueba" 
            runat="server"
            CssClass="gridview">
            <Columns>
                <%--<asp:BoundField DataField="Nombre" HeaderText="Nombre" />--%>
            </Columns>
        </asp:GridView>
        
    </div>
</asp:Content>
