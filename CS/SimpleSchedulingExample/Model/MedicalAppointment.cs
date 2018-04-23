#region #appointment
using DevExpress.Mvvm.POCO;
using System;

namespace SchedulerViewsExample {
    public class MedicalAppointment {
        public static MedicalAppointment Create() {
            return ViewModelSource.Create(() => new MedicalAppointment());
        }
        internal static MedicalAppointment Create(DateTime StartTime, DateTime EndTime, 
            int DoctorId, string Notes, string Location, string PatientName, 
            string InsuranceNumber, bool FirstVisit) {

            MedicalAppointment apt = MedicalAppointment.Create();
            apt.StartTime = StartTime;
            apt.EndTime = EndTime;
            apt.DoctorId = DoctorId;
            apt.Notes = Notes;
            apt.Location = Location;
            apt.PatientName = PatientName;
            apt.InsuranceNumber = InsuranceNumber;
            apt.FirstVisit = FirstVisit;
            return apt;
        }

        protected MedicalAppointment() { }

        public virtual int Id { get; set; }
        public virtual bool AllDay { get; set; }
        public virtual DateTime StartTime { get; set; }
        public virtual DateTime EndTime { get; set; }
        public virtual string PatientName { get; set; }
        public virtual string Notes { get; set; }
        public virtual string Subject { get; set; }
        public virtual int PaymentStateId { get; set; }
        public virtual int IssueId { get; set; }
        public virtual int Type { get; set; }
        public virtual string Location { get; set; }
        public virtual string RecurrenceInfo { get; set; }
        public virtual string ReminderInfo { get; set; }
        public virtual int? DoctorId { get; set; }
        public virtual string InsuranceNumber { get; set; }
        public virtual bool FirstVisit { get; set; }
    }
}
#endregion #appointment