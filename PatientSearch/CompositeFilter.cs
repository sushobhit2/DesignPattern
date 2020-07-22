using PatientSearch.Interfaces;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace PatientSearch
{
    class CompositeFilter : IPatientSearchFilter
    {
        private List<IPatientSearchFilter> patientSearchFilters;
        public void Add(IPatientSearchFilter patientSearchFilter)
        {
            patientSearchFilters.Add(patientSearchFilter);
        }
        public void Remove(IPatientSearchFilter patientSearchFilter)
        {
            patientSearchFilters.Remove(patientSearchFilter);
        }
        public bool Filter(PatientDataModel patientDataModel)
        {
            foreach(var patientFilter in patientSearchFilters)
            {
                patientFilter.Filter(patientDataModel);
            }
            return false;
        }
    }
}
