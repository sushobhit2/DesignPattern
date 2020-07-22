using PatientSearch.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatientSearch
{
    class NameData : IPatientSearchFilter

    {
        private string name;
        public string MyProperty { get; set; }

        public bool Filter(PatientDataModel patientDataModel)
        {
            throw new NotImplementedException();
        }
    }
}
