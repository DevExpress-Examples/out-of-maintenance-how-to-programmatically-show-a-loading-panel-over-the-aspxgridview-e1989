Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace ShowLoadingPanelFromGrid
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
			ASPxGridViewDemo.DataSource = Person.GetDemoData()
			ASPxGridViewDemo.DataBind()
		End Sub

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If (Not IsPostBack) AndAlso (Not IsCallback) Then
				ASPxGridViewDemo.DetailRows.ExpandRow(0)
			End If
		End Sub
		Protected Sub ASPxCallbackDemo_Callback(ByVal source As Object, ByVal e As DevExpress.Web.CallbackEventArgs)
			' emulate a long lasting operation
			System.Threading.Thread.Sleep(3000)
		End Sub
	End Class
End Namespace
