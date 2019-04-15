<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<h1>テスト用プロジェクト</h1>
<asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1" ExpandDepth="2" ShowLines="True"></asp:TreeView>
    <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
</asp:Content>
