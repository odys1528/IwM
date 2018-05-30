using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        public Hl7.Fhir.Model.Bundle everythingById(string id)
        {
            Hl7.Fhir.Model.Bundle ReturnedBundle = null;

            try
            {
                //Attempt to send the resource to the server endpoint                
                UriBuilder UriBuilderx = new UriBuilder(FhirClientEndPoint);
                UriBuilderx.Path = "Patient/" + id;
                Hl7.Fhir.Model.Resource ReturnedResource = _client.InstanceOperation(UriBuilderx.Uri, "everything");

                if (ReturnedResource is Hl7.Fhir.Model.Bundle)
                {
                    ReturnedBundle = ReturnedResource as Hl7.Fhir.Model.Bundle;
                    Console.WriteLine("Received: " + ReturnedBundle.Total + " results. ");

                }
                else
                {
                    throw new Exception("Operation call must return a bundle resource");
                }
                Console.WriteLine();

            }
            catch (Hl7.Fhir.Rest.FhirOperationException FhirOpExec)
            {
                //Process any Fhir Errors returned as OperationOutcome resource
                Console.WriteLine();
                Console.WriteLine("An error message: " + FhirOpExec.Message);
                Console.WriteLine();
                string xml = Hl7.Fhir.Serialization.FhirSerializer.SerializeResourceToXml(FhirOpExec.Outcome);
                XDocument xDoc = XDocument.Parse(xml);
                Console.WriteLine(xDoc.ToString());
            }
            return ReturnedBundle;
        }
        public Patient patientById(string id)
        {
            Patient patient;
            patient = _client.Read<Patient>(id);
            return patient;
        }
    }
}
