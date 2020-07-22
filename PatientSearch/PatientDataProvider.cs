using PatientSearch.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatientSearch
{
    class PatientDataProvider
    {
        List<PatientDataModel> patientDataModels;
        public List<PatientDataModel> GetPatientDetails(IPatientSearchFilter searchFilter)
        {
            foreach(var patientDataModel in patientDataModels)
            {
                if (searchFilter.Filter(patientDataModel))
                {

                }
            }
            return null;
        }
    }
}
