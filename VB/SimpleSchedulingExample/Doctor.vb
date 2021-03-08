Imports DevExpress.Mvvm.POCO

Namespace SimpleSchedulingExample
	#Region "#resource"
	Public Class Doctor
		Public Shared Function Create() As Doctor
			Return ViewModelSource.Create(Function() New Doctor())
		End Function
		Public Shared Function Create(ByVal Id As Integer, ByVal Name As String) As Doctor
'INSTANT VB NOTE: The variable doctor was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
			Dim doctor_Conflict As Doctor = SimpleSchedulingExample.Doctor.Create()
			doctor_Conflict.Id = Id
			doctor_Conflict.Name = Name
			Return doctor_Conflict
		End Function

		Protected Sub New()
		End Sub

		Public Overridable Property Id() As Integer
		Public Overridable Property Name() As String
	End Class
	#End Region ' #resource
End Namespace
