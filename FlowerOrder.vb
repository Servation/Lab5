Public Class FlowerOrder
    Inherits Customer
    Public RecipName, RecipAddress, Arrangement As String

    Public Sub New()
        MyBase.New()
        RecipName = ""
        RecipAddress = ""
        Arrangement = ""
    End Sub

    Public Sub New(strName As String, strEmail As String, dblPhone As Double, dblPaid As Double, strRecipName As String, strRecipAddress As String, strArrang As String)
        MyBase.New(strName, strEmail, dblPhone, dblPaid)
        RecipName = strRecipName
        RecipAddress = strRecipAddress
        Arrangement = strArrang
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
