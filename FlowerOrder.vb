Public Class FlowerOrder
    Inherits Customer
    Private RecipName, RecipAddress, strArrangement As String

    Public Property RecipientName As String
        Get
            Return RecipName
        End Get
        Set(value As String)
            RecipName = value
        End Set
    End Property

    Public Property RecipientAddress As String
        Get
            Return RecipAddress
        End Get
        Set(value As String)
            RecipAddress = value
        End Set
    End Property

    Public Property Arrangement As String
        Get
            Return strArrangement
        End Get
        Set(value As String)
            strArrangement = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        RecipName = ""
        RecipAddress = ""
        strArrangement = ""
    End Sub

    Public Sub New(strName As String, strEmail As String, dblPhone As Double, dblPaid As Double, strRecipName As String, strRecipAddress As String, strArrang As String)
        MyBase.New(strName, strEmail, dblPhone, dblPaid)
        RecipName = strRecipName
        RecipAddress = strRecipAddress
        strArrangement = strArrang
    End Sub

    Public Function receivedOrder(i As Boolean) As Boolean
        Return i
    End Function

    Public Function Payment(i As Boolean) As Boolean
        Return i
    End Function

    Public Sub PrintOrder()
        MessageBox.Show("Printing Order")
    End Sub

    Public Sub ArrangeOrder()
        MessageBox.Show("Arranging Order")
    End Sub

    Public Function PackageOrder(i As Boolean) As Boolean
        MessageBox.Show("Packaging Order")
        Return i
    End Function

End Class
