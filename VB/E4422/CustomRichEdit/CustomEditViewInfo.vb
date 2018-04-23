Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.ViewInfo

Namespace CustomEditor
	Public Class CustomEditViewInfo
		Inherits RichTextEditViewInfo
		Public Sub New(ByVal item As RepositoryItem)
			MyBase.New(item)
		End Sub

		Public Overrides ReadOnly Property DisplayText() As String
			Get
				Dim value As Object = Viewer.EditValue
				If value Is Nothing Then
					Return String.Empty
				End If
				Return value.ToString()
			End Get
		End Property
	End Class
End Namespace
