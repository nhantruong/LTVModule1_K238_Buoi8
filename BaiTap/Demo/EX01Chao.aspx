<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EX01Chao.aspx.cs" Inherits="BaiTap.Demo.EX01Chao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>1-Chào mừng</title>
    <%-- ASP.Net chú thích: Internal Style Sheet --%>
    <style>
        h3{color:red;}
        .tieu-de{background-color:yellow;color:red;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!--HTML ghi chú: Inline Styles-->
        <h2 style="color:#159f5d;">Nhập môn ASP.NET</h2>
        <h3>Chào mừng bạn đến với T3H</h3>
        <h3>10-03-2018</h3>
        <h4 class="tieu-de">K238</h4>

    </div>
    </form>
</body>
</html>
