<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SearchBox.aspx.cs" Inherits="WebForm.Test.SearchBox" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <h2>検索BOX</h2>
    <div class="form-inline">
        <asp:TextBox ID="txtKeyword" TextMode="Search" runat="server" CssClass="form-control" placeholder="りんご　と入力してね"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" Text="検索" CssClass="btn btn-primary" OnClick="btnSearch_Click" />
    </div>
    <br />
    <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered" OnRowDataBound="GridView1_RowDataBound">
        <EmptyDataTemplate>
            見つかりませんでした
        </EmptyDataTemplate>
    </asp:GridView>
</asp:Content>
