using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IwM
{
    class FhirOperations
    {
        public static string FhirClientEndPoint = "https://fhirtest.uhn.ca/baseDstu3/";
        private FhirClient _client;

        public FhirOperations()
        {
            _client = new FhirClient(FhirClientEndPoint);
        }

        public List<Patient> patientsByName(string name)
        {
            Patient patient;
            List<Patient> patients = new List<Patient>();
            var b = _client.Search<Hl7.Fhir.Model.Patient>(new string[] { "name="+name });

            foreach (var Entry in b.Entry)
            {
                var x = Entry.Resource;
                patient = (Patient)x;
                patients.Add(patient);
            }

            return patients;
        }

        public Patient patientById(string id)
        {
            Patient patient;
            patient = _client.Read<Patient>(id);
            return patient;
        }
    }
}
