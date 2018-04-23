Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraEditors.Repository
Imports System.Drawing
Imports System.Reflection
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Drawing

Namespace CustomEditor
	'The attribute that points to the registration method
	<UserRepositoryItem("RegisterCustomEdit")> _
	Public Class RepositoryItemCustomEdit
		Inherits RepositoryItemRichTextEdit
		'The static constructor which calls the registration method
		Shared Sub New()
			RegisterCustomEdit()
		End Sub

		'Initialize new properties
		Public Sub New()
		End Sub

		'The unique name for the custom editor
		Public Const CustomEditName As String = "CustomEdit"

		'Return the unique name
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return CustomEditName
			End Get
		End Property

		'Register the editor
		Public Shared Sub RegisterCustomEdit()
			'Icon representing the editor within a container editor's Designer
			Dim img As Image = Nothing
			Try
				img = CType(Bitmap.FromStream(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("DevExpress.CustomEditors.CustomEdit.bmp")), Bitmap)
			Catch
			End Try
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomEditName, GetType(CustomEdit), GetType(RepositoryItemCustomEdit), GetType(CustomEditViewInfo), New RichTextEditPainter(), True, img))
		End Sub

		'Override the Assign method
		Public Overrides Sub Assign(ByVal item As RepositoryItem)
			BeginUpdate()
			Try
				MyBase.Assign(item)
				Dim source = TryCast(item, RepositoryItemCustomEdit)
				If source Is Nothing Then
					Return
				End If
			Finally
				EndUpdate()
			End Try
		End Sub
	End Class
End Namespace
