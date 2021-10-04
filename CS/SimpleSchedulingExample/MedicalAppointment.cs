using System;

public class MedicalAppointment {
    public static MedicalAppointment Create() {
        return new MedicalAppointment();
    }
    internal static MedicalAppointment Create(DateTime startTime, DateTime endTime,
        int doctorId, string notes, string location, int categoryId, string patientName,
        string insuranceNumber, bool firstVisit) {

        MedicalAppointment apt = MedicalAppointment.Create();
        apt.StartTime = startTime;
        apt.EndTime = endTime;
        apt.DoctorId = doctorId;
        apt.Notes = notes;
        apt.Location = location;
        apt.CategoryId = categoryId;
        apt.PatientName = patientName;
        apt.InsuranceNumber = insuranceNumber;
        apt.FirstVisit = firstVisit;
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
    public virtual int StatusId { get; set; }
    public virtual int CategoryId { get; set; }
    public virtual int Type { get; set; }
    public virtual string Location { get; set; }
    public virtual string RecurrenceInfo { get; set; }
    public virtual string ReminderInfo { get; set; }
    public virtual int? DoctorId { get; set; }
    public virtual string InsuranceNumber { get; set; }
    public virtual bool FirstVisit { get; set; }
}
