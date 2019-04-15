<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PageSearch.aspx.cs" Inherits="WebForm.Test.PageSearch" %>
<asp:Content ID="Contents" ContentPlaceHolderID="Script" runat="server">
   <script type="text/javascript">
        function highlightKeyword(keyword) {
            var tbls = document.getElementsByTagName("table");
            // 一番上のテーブルを除く全てのテーブルの全ての行の全てのセル内を置換
            for (var i = 1; i < tbls.length; i++) {
                for (var j = 1; j < tbls[i].rows.length; j++) {
                    for (var k = 0; k < tbls[i].rows[j].cells.length; k++) {
                        var str = tbls[i].rows[j].cells[k].innerHTML;
                        // 既にタグが付いてるかも知れないので削除してから追加
                        tbls[i].rows[j].cells[k].innerHTML = str.replace('<span style="background: yellow;">', '').replace('</span>', '').replace(keyword, '<span style="background: yellow;">' + keyword + '</span>');
                    }
                }
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>ページ内検索</h2>
    <h3>テーブル1</h3>
    <asp:GridView ID="GridView1" runat="server" CssClass="table table-sm table-bordered" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" OnRowDataBound="GridView1_RowDataBound">
        <Columns>
            <asp:BoundField DataField="PurchaseDate" HeaderText="PurchaseDate" SortExpression="PurchaseDate" />
            <asp:BoundField DataField="CustomerId" HeaderText="CustomerId" SortExpression="CustomerId" />
            <asp:BoundField DataField="GoodsId" HeaderText="GoodsId" SortExpression="GoodsId" />
            <asp:BoundField DataField="CategoryId" HeaderText="CategoryId" SortExpression="CategoryId" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetCartData" TypeName="WebForm.Data.CartData"></asp:ObjectDataSource>
    <h3>テーブル2</h3>
    <asp:GridView ID="GridView2" runat="server" CssClass="table table-sm table-bordered" BorderColor="#dee2e6" AutoGenerateColumns="False" DataSourceID="ObjectDataSource2">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="CategoryId" HeaderText="CategoryId" SortExpression="CategoryId" />
            <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetGoodsAll" TypeName="WebForm.Data.Goods"></asp:ObjectDataSource>
    <h3>テーブル3</h3>
    <asp:XmlDataSource ID="XmlDataSource1" runat="server"></asp:XmlDataSource>
    <asp:GridView ID="GridView3" runat="server" CssClass="table table-sm table-bordered" BorderColor="#dee2e6" AutoGenerateColumns="False" DataSourceID="ObjectDataSource3">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="GetCategory" TypeName="WebForm.Data.Category"></asp:ObjectDataSource>
</asp:Content>

