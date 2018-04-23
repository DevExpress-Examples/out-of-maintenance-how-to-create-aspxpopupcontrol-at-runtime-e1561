Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxPopupControl

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim popup As New ASPxPopupControl()
		popup.ID = "popup"
		popup.ClientInstanceName = "popup"

		popup.HeaderText = "Runtime Popup"
		popup.Controls.Add(GetControl())

		form1.Controls.Add(popup)
	End Sub

	Private Function GetControl() As Control
		Dim txt As New TextBox()
		txt.ID = "txt"
		txt.Width = 200
		txt.Text = "Dynamic control"

		Return txt
	End Function
End Class
