#Region "#viewmodel"
Imports System
Imports System.Collections.ObjectModel

Namespace SimpleSchedulingExample
	Public Class MainViewModel
		Public Overridable Property Doctors() As ObservableCollection(Of Doctor)
		Public Overridable Property Appointments() As ObservableCollection(Of MedicalAppointment)

		Protected Sub New()
			CreateDoctors()
			CreateMedicalAppointments()
		End Sub
		Private Sub CreateDoctors()
			Doctors = New ObservableCollection(Of Doctor)()
			Doctors.Add(Doctor.Create(Id:= 1, Name:= "Stomatologist"))
			Doctors.Add(Doctor.Create(Id:= 2, Name:= "Ophthalmologist"))
			Doctors.Add(Doctor.Create(Id:= 3, Name:= "Surgeon"))
		End Sub
		Private Sub CreateMedicalAppointments()
			Appointments = New ObservableCollection(Of MedicalAppointment)()
			Appointments.Add(MedicalAppointment.Create(startTime:= DateTime.Now.Date.AddHours(10), endTime:= DateTime.Now.Date.AddHours(11), doctorId:= 1, notes:= "", location:= "101", categoryId:=1, patientName:= "Dave Muriel", insuranceNumber:= "396-36-XXXX", firstVisit:= True))
		End Sub
	End Class
End Namespace
#End Region ' #viewmodel