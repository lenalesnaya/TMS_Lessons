namespace Lessons
{
    internal class Patient
    {
        public TreatmentPlan? TreatmentPlan { get; private set; }

        public string Name { get; set; }


        public Patient(string name)
        {
            Name = name;
        }


        public void CreateTreatmentPlan(byte treatmentPlanCode, params byte[] otherTreatmentPlanCodes)
        {
            TreatmentPlan = new TreatmentPlan(treatmentPlanCode, otherTreatmentPlanCodes);
        }

        public void SetTreatmentPlan(TreatmentPlan treatmentPlan)
        {
            TreatmentPlan = treatmentPlan;
        }

        public void CancelTreatmentPlan()
        {
            TreatmentPlan = null;
        }

        public void Treat()
        {
            if (TreatmentPlan != null && TreatmentPlan.Doctors != null && TreatmentPlan.Doctors.Length > 0)
            {
                foreach (var doctor in TreatmentPlan.Doctors)
                {
                    switch (doctor)
                    {
                        case Surgeon:
                            Surgeon.Treat();
                            break;
                        case Dentist:
                            Dentist.Treat();
                            break;
                        case Therapist:
                            Therapist.Treat();
                            break;
                        default:
                            Console.WriteLine("\nUnknown doctor.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("\nTreatment plan was not appointed.");
            }
        }
    }
}