using System;

namespace PatientSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var patientSearchFilters = new CompositeFilter();
            patientSearchFilters.Add(new MRNData());
            patientSearchFilters.Add(new NameData());
            var patientDataProvider = new PatientDataProvider();
            var patientList = patientDataProvider.GetPatientDetails(patientSearchFilters);
        }
    }
}
