Public Class Customer
    Public Name, Email As String
    Public AmountPaid, PhoneNumber As Double

    Public Sub New()
        Name = ""
        Email = ""
        PhoneNumber = 0
        AmountPaid = 0
    End Sub

    Public Sub New(strName As String, strEmail As String, dblPhone As Double, dblPaid As Double)
        Name = strName
        Email = strEmail
        AmountPaid = dblPaid
        PhoneNumber = dblPhone
    End Sub


End Class
