Imports DevExpress.LookAndFeel
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace E4422

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            AddHandler gridView1.CustomDrawCell, New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(AddressOf OnCustomDrawCell)
            Dim invoices As List(Of Invoice) = CreateData()
            bindingSource1.DataSource = invoices
        End Sub

        Private Shared server As RichEditDocumentServer = New RichEditDocumentServer()

        Private Sub OnCustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs)
            If e.Column Is colDescription AndAlso Not String.IsNullOrEmpty(gridView1.FindFilterText) Then
                server.RtfText = e.DisplayText
                Dim document As Document = server.Document
                document.BeginUpdate()
                Dim ranges As DocumentRange() = document.FindAll(gridView1.FindFilterText, SearchOptions.None)
                For i As Integer = 0 To ranges.Length - 1
                    Dim cp As CharacterProperties = document.BeginUpdateCharacters(ranges(i))
                    cp.BackColor = LookAndFeelHelper.GetHighlightSearchAppearance(UserLookAndFeel.Default, False).BackColor
                    document.EndUpdateCharacters(cp)
                Next

                document.EndUpdate()
                e.DisplayText = server.RtfText
            End If
        End Sub

        Private Shared Function CreateData() As List(Of Invoice)
            Dim invoices As List(Of Invoice) = New List(Of Invoice)(10)
            invoices.Add(New Invoice(0, 10.0D, "{\rtf1\deff0{\fonttbl{\f0 Times New Roman;}}{\colortbl\red0\green0\blue0 ;\red0\green0\blue255 ;}{\*\listoverridetable}{\stylesheet {\ql\cf0 Normal;}{\*\cs1\cf0 Default Paragraph Font;}{\*\cs2\sbasedon1\cf0 Line Number;}{\*\cs3\ul\cf1 Hyperlink;}}\sectd\pard\plain\ql{\cf0 RTF }{\b\cf0 text}{\cf0  sample 1.}\par}"))
            invoices.Add(New Invoice(1, 15.0D, "{\rtf1\deff0{\fonttbl{\f0 Times New Roman;}}{\colortbl\red0\green0\blue0 ;\red0\green0\blue255 ;}{\*\listoverridetable}{\stylesheet {\ql\cf0 Normal;}{\*\cs1\cf0 Default Paragraph Font;}{\*\cs2\sbasedon1\cf0 Line Number;}{\*\cs3\ul\cf1 Hyperlink;}}\sectd\pard\plain\ql{\cf0 RTF }{\b\cf0 text}{\cf0  sample 2.}\par}"))
            invoices.Add(New Invoice(2, 20.0D, "{\rtf1\deff0{\fonttbl{\f0 Times New Roman;}}{\colortbl\red0\green0\blue0 ;\red0\green0\blue255 ;}{\*\listoverridetable}{\stylesheet {\ql\cf0 Normal;}{\*\cs1\cf0 Default Paragraph Font;}{\*\cs2\sbasedon1\cf0 Line Number;}{\*\cs3\ul\cf1 Hyperlink;}}\sectd\pard\plain\ql{\cf0 RTF }{\b\cf0 text}{\cf0  sample 3.}\par}"))
            Return invoices
        End Function
    End Class
End Namespace
