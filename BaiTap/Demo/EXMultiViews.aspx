<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EXMultiViews.aspx.cs" Inherits="BaiTap.Demo.EXMultiViews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container-fluid">
        <h2 class="text-info">Demo: MultiView</h2>
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/Photos/Northern_lights1.jpg" Width="250px" Height="200px" />
                <br />
                <asp:LinkButton ID="linkButtonNext" runat="server" CommandName="NextView">Next</asp:LinkButton>
                &nbsp;&nbsp; <asp:Button ID="button2" runat="server" CommandArgument="1" CommandName="SwitchViewByIndex" 
                    CssClass="btn btn-success btn-xs" Text="2" />
                <br />
            </asp:View>
            <asp:View ID="View2" runat="server">
                <asp:Image ID="Image2" runat="server" ImageUrl="~/Photos/Northern_lights2.jpg" Width="250px" Height="200px" />
                <br />
                <asp:LinkButton ID="linkButtonPrev" runat="server" CommandName="PrevView">Prev</asp:LinkButton>
                &nbsp;
                <asp:Button ID="button1" runat="server" CommandArgument="0" CommandName="SwitchViewByIndex" 
                    CssClass="btn btn-success btn-xs" Text="1" OnClick="button1_Click" />
                <br />
            </asp:View>
        </asp:MultiView>

        <div class="bg-danger">
            <asp:ImageButton ID="imageButton1" runat="server" Height="40px" ImageUrl="~/Images/prev.jpg" OnClick="imageButton1_Click" />
            &nbsp;
            <asp:ImageButton ID="imageButton2" runat="server" Height="40px" ImageUrl="~/Images/next.jpg" OnClick="imageButton2_Click" />
        </div>
    </div>
    </form>
</body>
</html>
