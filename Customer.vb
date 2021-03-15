Public Class Customer
    Private strName, strEmail As String
    Private dblAmountPaid, dblPhoneNumber As Double

    Public Property Name As String
        Get
            Return strName
        End Get
        Set(value As String)
            strName = Name
        End Set
    End Property

    Public Property Email As String
        Get
            Return strEmail
        End Get
        Set(value As String)
            strEmail = value
        End Set
    End Property

    Public Property AmountPaid As Double
        Get
            Return dblAmountPaid
        End Get
        Set(value As Double)
            dblAmountPaid = value
        End Set
    End Property

    Public Property PhoneNumber As Double
        Get
            Return dblPhoneNumber
        End Get
        Set(value As Double)
            dblPhoneNumber = value
        End Set
    End Property

    Public Sub New()
        strName = ""
        strEmail = ""
        dblPhoneNumber = 0
        dblAmountPaid = 0
    End Sub

    Public Sub New(strName As String, strEmail As String, dblPhone As Double, dblPaid As Double)
        Me.strName = strName
        Me.strEmail = strEmail
        dblAmountPaid = dblPaid
        dblPhoneNumber = dblPhone
    End Sub


End Class
