using System;
using System.Collections.Generic;
using System.Text;

namespace PatientSearch.Interfaces
{
    interface IPatientSearchFilter
    {
        bool Filter(PatientDataModel patientDataModel);
    }
}
