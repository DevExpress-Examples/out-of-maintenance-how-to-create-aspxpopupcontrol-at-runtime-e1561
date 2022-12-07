<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dxe" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>How to create ASPxPopupControl in runtime</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dxe:ASPxButton ID="btnShow" runat="server" Text="Show popup" AutoPostBack="false">
            <ClientSideEvents Click="function (s, e) { popup.Show(); }" />
        </dxe:ASPxButton>
    </div>
    </form>
</body>
</html>
