namespace Lessons.Lesson5Tasks.Clinic
{
    internal class TreatmentPlan
    {
        private readonly byte[] treatmentPlanCodes;

        public object[]? Doctors { get; private set; }


        public TreatmentPlan(byte treatmentPlanCode, params byte[] otherTreatmentPlanCodes)
        {
            treatmentPlanCodes = new byte[otherTreatmentPlanCodes.Length + 1];
            treatmentPlanCodes[0] = treatmentPlanCode;

            for (int i = 1; i <= otherTreatmentPlanCodes.Length; i++)
            {
                treatmentPlanCodes[i] = otherTreatmentPlanCodes[i - 1];
            }

            AppointDoctors();
        }


        private void AppointDoctors()
        {
            if (treatmentPlanCodes == null || treatmentPlanCodes.Length < 0)
            {
                Console.WriteLine("\nTreatment plan was not appointed.");
                return;
            }

            Doctors = new object[treatmentPlanCodes.Length];
            for (int i = 0; i < treatmentPlanCodes.Length; i++)
            {
                if (treatmentPlanCodes[i] == 1)
                {
                    Doctors[i] = new Surgeon();
                }
                else if (treatmentPlanCodes[i] == 2)
                {
                    Doctors[i] = new Dentist();
                }
                else
                {
                    Doctors[i] = new Therapist();
                }
            }
        }
    }
}