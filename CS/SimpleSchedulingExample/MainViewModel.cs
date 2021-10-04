using System;
using System.Collections.ObjectModel;

namespace SimpleSchedulingExample {
    public class MainViewModel {
        public virtual ObservableCollection<Doctor> Doctors { get; set; }
        public virtual ObservableCollection<MedicalAppointment> Appointments { get; set; }

        public MainViewModel() {
            CreateDoctors();
            CreateMedicalAppointments();
        }
        private void CreateDoctors() {
            Doctors = new ObservableCollection<Doctor>();
            Doctors.Add(Doctor.Create(Id: 1, Name: "Stomatologist"));
            Doctors.Add(Doctor.Create(Id: 2, Name: "Ophthalmologist"));
            Doctors.Add(Doctor.Create(Id: 3, Name: "Surgeon"));
        }
        private void CreateMedicalAppointments() {
            Appointments = new ObservableCollection<MedicalAppointment>();
            Appointments.Add(MedicalAppointment.Create(
                startTime: DateTime.Now.Date.AddHours(10), endTime: DateTime.Now.Date.AddHours(11),
                doctorId: 1, notes: "", location: "101", categoryId: 1, patientName: "Dave Muriel",
                insuranceNumber: "396-36-XXXX", firstVisit: true));
        }
    }
}
