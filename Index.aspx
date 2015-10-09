<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="XMLSerialize.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button Text="Serialize" ID="btnSerialize" runat="server" OnClick="btnSerialize_Click" />
            <asp:Button Text="Deserialize" ID="btnDeserialize" runat="server" OnClick="btnDeserialize_Click" />
        </div>
    </form>
</body>
</html>
