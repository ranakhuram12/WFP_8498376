<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WFP_8498376.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Country: <asp:DropDownList ID="ddlCountry" runat="server">
                <asp:ListItem Text="Burkina Faso" Value="BFA"></asp:ListItem>
                <asp:ListItem Text="Colombia" Value="COL"></asp:ListItem>
            </asp:DropDownList>
            <br />Start Date: <asp:Calendar ID="calStartDate" runat="server"></asp:Calendar>
            End Date: <asp:Calendar ID="calEndDate" runat="server"></asp:Calendar>
            <br /><asp:Button ID="btnMetricA" runat="server" OnClick="btnMetricA_Click" Text="Calculate Metric A" />
            <asp:Button ID="btnMetricB" runat="server" OnClick="btnMetricB_Click" Text="Calculate Metric B" />
            <asp:Button ID="btnPlotMetricB" runat="server" OnClick="btnPlotMetricB_Click" Text="Plot Metric B" />
        </div>
    </form>
</body>
</html>
