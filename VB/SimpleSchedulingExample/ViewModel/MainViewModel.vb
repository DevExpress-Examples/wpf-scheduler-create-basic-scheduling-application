#Region "#viewmodel"
Imports System
Imports System.Collections.ObjectModel

Namespace SchedulerViewsExample
    Public Class MainViewModel
        Public Overridable Property Doctors() As ObservableCollection(Of Doctor)
        Public Overridable Property Appointments() As ObservableCollection(Of MedicalAppointment)

        Protected Sub New()
            CreateDoctors()
            CreateMedicalAppointments()
        End Sub
        Private Sub CreateDoctors()
            Doctors = New ObservableCollection(Of Doctor)()
            Doctors.Add(Doctor.Create(Id:=1,Name:="Stomatologist"))
            Doctors.Add(Doctor.Create(Id:=2, Name:="Ophthalmologist"))
            Doctors.Add(Doctor.Create(Id:=3, Name:="Surgeon"))
        End Sub
        Private Sub CreateMedicalAppointments()
            Appointments = New ObservableCollection(Of MedicalAppointment)()
            Appointments.Add(MedicalAppointment.Create(StartTime := Date.Now.Date.AddHours(10), EndTime := Date.Now.Date.AddHours(11), DoctorId := 1, Notes := "", Location := "101", PatientName := "Dave Murrel", InsuranceNumber := "111111111", FirstVisit := True))
        End Sub
    End Class
End Namespace
#End Region ' #viewmodel
