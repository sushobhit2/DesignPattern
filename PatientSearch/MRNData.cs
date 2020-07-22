using PatientSearch.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatientSearch
{
    class MRNData:IPatientSearchFilter
    {
        public string mrn;
        public MRNData()
        {

        }

        public bool Filter(PatientDataModel patientDataModel)
        {
            throw new NotImplementedException();
        }
    }
}
