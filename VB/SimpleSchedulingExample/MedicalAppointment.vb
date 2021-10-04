Public Class MedicalAppointment

    Public Shared Function Create() As MedicalAppointment
        Return New MedicalAppointment()
    End Function

    Friend Shared Function Create(ByVal startTime As Date, ByVal endTime As Date, ByVal doctorId As Integer, ByVal notes As String, ByVal location As String, ByVal categoryId As Integer, ByVal patientName As String, ByVal insuranceNumber As String, ByVal firstVisit As Boolean) As MedicalAppointment
        Dim apt As MedicalAppointment = Create()
        apt.StartTime = startTime
        apt.EndTime = endTime
        apt.DoctorId = doctorId
        apt.Notes = notes
        apt.Location = location
        apt.CategoryId = categoryId
        apt.PatientName = patientName
        apt.InsuranceNumber = insuranceNumber
        apt.FirstVisit = firstVisit
        Return apt
    End Function

    Protected Sub New()
    End Sub

    Public Overridable Property Id As Integer

    Public Overridable Property AllDay As Boolean

    Public Overridable Property StartTime As Date

    Public Overridable Property EndTime As Date

    Public Overridable Property PatientName As String

    Public Overridable Property Notes As String

    Public Overridable Property Subject As String

    Public Overridable Property StatusId As Integer

    Public Overridable Property CategoryId As Integer

    Public Overridable Property Type As Integer

    Public Overridable Property Location As String

    Public Overridable Property RecurrenceInfo As String

    Public Overridable Property ReminderInfo As String

    Public Overridable Property DoctorId As Integer?

    Public Overridable Property InsuranceNumber As String

    Public Overridable Property FirstVisit As Boolean
End Class
