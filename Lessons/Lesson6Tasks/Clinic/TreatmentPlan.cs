namespace Lessons.Lesson6Tasks.Clinic
{
    internal class TreatmentPlan
    {
        private readonly DoctorsCodes[] doctorsCodes;

        public Doctor[]? Doctors { get; private set; }


        public TreatmentPlan(DoctorsCodes treatmentPlanCode, params DoctorsCodes[] otherTreatmentPlanCodes)
        {
            doctorsCodes = new DoctorsCodes[otherTreatmentPlanCodes.Length + 1];
            doctorsCodes[0] = treatmentPlanCode;

            for (int i = 1; i <= otherTreatmentPlanCodes.Length; i++)
            {
                doctorsCodes[i] = otherTreatmentPlanCodes[i - 1];
            }

            AppointDoctors();
        }


        private void AppointDoctors()
        {
            if (doctorsCodes == null || doctorsCodes.Length < 0)
            {
                Console.WriteLine("\nTreatment plan was not appointed.");
                return;
            }

            Doctors = new Doctor[doctorsCodes.Length];
            for (int i = 0; i < doctorsCodes.Length; i++)
            {
                Doctors[i] = doctorsCodes[i] switch
                {
                    DoctorsCodes.Surgeon => new Surgeon(),
                    DoctorsCodes.Dentist => new Dentist(),
                    DoctorsCodes.Therapist => new Therapist(),
                    _ => new Doctor(),
                };
            }
        }
    }
}