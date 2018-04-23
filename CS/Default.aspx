<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ShowLoadingPanelFromGrid._Default" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v9.3, Version=9.3.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v9.3, Version=9.3.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxLoadingPanel" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxEditors.v9.3, Version=9.3.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v9.3, Version=9.3.2.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxCallback" tagprefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>How to programmatically show a Loading Panel over the ASPxGridView</title>
<script type="text/javascript" language="javascript">
    function showLoadingPanelDemo() {
        clientLoadingPanelDemo.ShowInElementByID(clientGridViewDemo.name);
    }

    function hideLoadingPanelDemo() {
        clientLoadingPanelDemo.Hide();
    }
</script>
</head>
<body>
    <form id="mainForm" runat="server">
    <div>
		<dx:ASPxLoadingPanel ID="ASPxLoadingPanelDemo" runat="server" 
			ClientInstanceName="clientLoadingPanelDemo">
		</dx:ASPxLoadingPanel>
		<dx:ASPxGridView ID="ASPxGridViewDemo" runat="server" AutoGenerateColumns="True" KeyFieldName="ID"
		    ClientInstanceName="clientGridViewDemo">
			<Templates>
				<DetailRow>
					<dx:ASPxButton ID="btnSubmitDemo" runat="server" Text="Do Something" AutoPostBack="False">
						<ClientSideEvents Click="function(s, e) {
							showLoadingPanelDemo();	
							clientCallbackDemo.PerformCallback('callback');
						}" />
					</dx:ASPxButton>
				</DetailRow>
			</Templates>
			<SettingsDetail ShowDetailRow="True" />
		</dx:ASPxGridView>
    </div>
    <dx:ASPxCallback ID="ASPxCallbackDemo" runat="server" 
		ClientInstanceName="clientCallbackDemo" oncallback="ASPxCallbackDemo_Callback">
		<ClientSideEvents EndCallback="function(s, e) {
			hideLoadingPanelDemo();
		}" />
	</dx:ASPxCallback>
    </form>
</body>
</html>