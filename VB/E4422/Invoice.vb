Namespace E4422

    Public Class Invoice

        Private idField As Integer

        Public Property Id As Integer
            Get
                Return idField
            End Get

            Set(ByVal value As Integer)
                idField = value
            End Set
        End Property

        Private priceField As Decimal

        Public Property Price As Decimal
            Get
                Return priceField
            End Get

            Set(ByVal value As Decimal)
                priceField = value
            End Set
        End Property

        Private descriptionField As String

        Public Property Description As String
            Get
                Return descriptionField
            End Get

            Set(ByVal value As String)
                descriptionField = value
            End Set
        End Property

        Public Sub New(ByVal id As Integer, ByVal price As Decimal, ByVal description As String)
            Me.Id = id
            Me.Price = price
            Me.Description = description
        End Sub
    End Class
End Namespace
