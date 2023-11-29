#Region "#appointment"
Imports DevExpress.Mvvm.POCO

Namespace SchedulerViewsExample

    Public Class MedicalAppointment

        Public Shared Function Create() As MedicalAppointment
            Return ViewModelSource.Create(Function() New MedicalAppointment())
        End Function

        Friend Shared Function Create(ByVal StartTime As Date, ByVal EndTime As Date, ByVal DoctorId As Integer, ByVal Notes As String, ByVal Location As String, ByVal PatientName As String, ByVal InsuranceNumber As String, ByVal FirstVisit As Boolean) As MedicalAppointment
            Dim apt As MedicalAppointment = Create()
            apt.StartTime = StartTime
            apt.EndTime = EndTime
            apt.DoctorId = DoctorId
            apt.Notes = Notes
            apt.Location = Location
            apt.PatientName = PatientName
            apt.InsuranceNumber = InsuranceNumber
            apt.FirstVisit = FirstVisit
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

        Public Overridable Property PaymentStateId As Integer

        Public Overridable Property IssueId As Integer

        Public Overridable Property Type As Integer

        Public Overridable Property Location As String

        Public Overridable Property RecurrenceInfo As String

        Public Overridable Property ReminderInfo As String

        Public Overridable Property DoctorId As Integer?

        Public Overridable Property InsuranceNumber As String

        Public Overridable Property FirstVisit As Boolean
    End Class
End Namespace
#End Region  ' #appointment
