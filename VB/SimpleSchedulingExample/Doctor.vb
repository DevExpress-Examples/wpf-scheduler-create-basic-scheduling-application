Public Class Doctor

    Public Shared Function Create() As Doctor
        Return New Doctor()
    End Function

    Public Shared Function Create(ByVal Id As Integer, ByVal Name As String) As Doctor
        Dim doctor As Doctor = Create()
        doctor.Id = Id
        doctor.Name = Name
        Return doctor
    End Function

    Protected Sub New()
    End Sub

    Public Overridable Property Id As Integer

    Public Overridable Property Name As String
End Class
