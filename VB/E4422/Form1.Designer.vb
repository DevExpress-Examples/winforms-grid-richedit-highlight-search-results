Imports DevExpress.XtraEditors.Repository

Namespace E4422

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemRichTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.bindingSource1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemRichTextEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.bindingSource1
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemRichTextEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(559, 434)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' bindingSource1
            ' 
            Me.bindingSource1.DataSource = GetType(E4422.Invoice)
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colPrice, Me.colDescription})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsFind.AlwaysVisible = True
            Me.gridView1.OptionsView.RowAutoHeight = True
            ' 
            ' colId
            ' 
            Me.colId.FieldName = "Id"
            Me.colId.Name = "colId"
            Me.colId.Visible = True
            Me.colId.VisibleIndex = 0
            ' 
            ' colPrice
            ' 
            Me.colPrice.FieldName = "Price"
            Me.colPrice.Name = "colPrice"
            Me.colPrice.Visible = True
            Me.colPrice.VisibleIndex = 1
            ' 
            ' colDescription
            ' 
            Me.colDescription.ColumnEdit = Me.repositoryItemRichTextEdit1
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 2
            ' 
            ' repositoryItemRichTextEdit1
            ' 
            Me.repositoryItemRichTextEdit1.Name = "repositoryItemRichTextEdit1"
            Me.repositoryItemRichTextEdit1.ShowCaretInReadOnly = False
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(559, 434)
            Me.Controls.Add(Me.gridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.bindingSource1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemRichTextEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private bindingSource1 As System.Windows.Forms.BindingSource

        Private colId As DevExpress.XtraGrid.Columns.GridColumn

        Private colPrice As DevExpress.XtraGrid.Columns.GridColumn

        Private colDescription As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemRichTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
    End Class
End Namespace
