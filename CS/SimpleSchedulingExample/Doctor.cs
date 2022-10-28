namespace SimpleSchedulingExample
{

    public class Doctor
    {
        public static Doctor Create()
        {
            return new Doctor();
        }
        public static Doctor Create(int Id, string Name)
        {
            Doctor doctor = Doctor.Create();
            doctor.Id = Id;
            doctor.Name = Name;
            return doctor;
        }

        protected Doctor() { }

        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
    }
}
