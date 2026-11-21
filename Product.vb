Public Class Product
    Public Property Id As Integer
    Public Property ItemName As String = ""
    Public Property Description As String = ""
    Public Property Color As String = ""
    Public Property Brand As String = ""
    Public Property OtherDetails As String = ""
    Public Property Remarks As String = ""
    Public Property DateDelivered As Date = Date.Today
    Public Property Barcode As String = ""
    Public Property Category As String = ""
    Public Property Quantity As Integer
    Public Property UnitOfMeasure As String = ""
    Public Property UnitCost As Decimal
    Public Property SellingPrice As Decimal
    Public Property StorageLocation As String = ""

    Public ReadOnly Property TotalCost As Decimal
        Get
            Return Quantity * UnitCost
        End Get
    End Property

    Public ReadOnly Property TotalValue As Decimal
        Get
            Return Quantity * SellingPrice
        End Get
    End Property

    Public ReadOnly Property Profit As Decimal
        Get
            Return TotalValue - TotalCost
        End Get
    End Property
End Class
