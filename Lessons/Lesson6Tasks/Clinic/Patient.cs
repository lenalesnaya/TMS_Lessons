namespace Lessons.Lesson6Tasks.Clinic
{
    /// <summary>
    /// Represents the entity "patient".
    /// </summary>
    internal class Patient
    {
        public TreatmentPlan? TreatmentPlan { get; private set; }
        public string Name { get; set; }

        public Patient(string name)
        {
            Name = name;
        }

        /// < summary>
        /// Create the treatment plan for the specific patient, using a list of doctors.
        /// < /summary>
        /// <param name="doctorCode">A required argument to pass, representing a particular doctor.</param>
        /// <param name="otherDoctorsCodes">Provides the ability to transfer a list of doctors.</param>
        public void CreateTreatmentPlan(DoctorsCodes doctorCode, params DoctorsCodes[] otherDoctorsCodes)
        {
            TreatmentPlan = new TreatmentPlan(doctorCode, otherDoctorsCodes);
        }

        /// < summary>
        /// Set the treatment plan for the specific patient.
        /// < /summary>
        /// <param name="treatmentPlan">Represents a specific treatment plan.</param>
        public void SetTreatmentPlan(TreatmentPlan treatmentPlan)
        {
            TreatmentPlan = treatmentPlan;
        }

        /// < summary>
        /// Cancel the treatment plan for the specific patient.
        /// < /summary>
        public void CancelTreatmentPlan()
        {
            TreatmentPlan = null;
        }

        /// < summary>
        /// Depending on the treatment plan, calls the "Treat" method for certain doctors.
        /// < /summary>
        public void Treat()
        {
            if (TreatmentPlan != null && TreatmentPlan.Doctors != null && TreatmentPlan.Doctors.Length > 0)
            {
                foreach (var doctor in TreatmentPlan.Doctors)
                {
                    doctor.Treat();
                }
            }
            else
            {
                Console.WriteLine("\nTreatment plan was not appointed.");
            }
        }
    }
}