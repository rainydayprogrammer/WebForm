<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMenu.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm.Products.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Script" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h3>メニューコントロールを使ったNAVBAR</h3>
    <div>
        Navbarのプルダウンの中のページは存在しないものがあります。
    </div>

<h3>TreeViewを使ったChildren link</h3>
    <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1" ExpandDepth="1" ShowLines="True"></asp:TreeView>
    <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" StartFromCurrentNode="True" ShowStartingNode="True" />

</asp:Content>
