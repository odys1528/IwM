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
        public List<Patient> get20Patients(int bottom_limit, int top_limit) {
            List<Patient> patients = new List<Patient>();
            Patient patient = new Patient();
            patient.Id = (bottom_limit+1).ToString();
            if (bottom_limit == -1)
            {
                int id = top_limit - 1;
                Console.WriteLine(id);
                for (int i = top_limit -1; i > top_limit - 21; i--)
                {
                    patient = patientById(id,-1);
                    patients.Add(patient);
                    id = Int32.Parse(patient.Id) - 1;
                }
            }
            else if (top_limit == -1) {
                int id = bottom_limit + 1;
                for (int i = bottom_limit + 1; i < bottom_limit + 21; i++)
                {
                    patient = patientById(id,1);
                    patients.Add(patient);
                    id = Int32.Parse(patient.Id) + 1;
                }
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

        //id - od którego id zacząć szukać pacjenta (niektóre id zawierają puste elementy)
        //direction - 1: zwiększaj id  -1: zmniejszaj id
        public Patient patientById(int id, int direction)
        {
           
            String url = FhirClientEndPoint + "Patient/" + id;
            Patient patient = null;
            Boolean gotPatient = false;
            while (!gotPatient) {
                try
                {
                    patient = _client.Read<Patient>(url);
                    gotPatient = true;
                }
                catch (Hl7.Fhir.Rest.FhirOperationException)
                {
                    id = id + direction * 1;
                    url = FhirClientEndPoint + "Patient/" + id;
                }
                catch (System.Net.WebException) { }
                //pomiń pacjentów, którzy nie mają imienia
                try { String name = patient.Name.First().Family; }
                catch (System.NullReferenceException)
                {
                    id = id + direction * 1;
                    url = FhirClientEndPoint + "Patient/" + id;
                    gotPatient = false;
                }
                catch (System.InvalidOperationException) {
                    id = id + direction * 1;
                    url = FhirClientEndPoint + "Patient/" + id;
                    gotPatient = false;
                }
            }
            return patient;
        }

        public List<Hl7.Fhir.Model.Observation> observationsByID(string id) {
            List<Hl7.Fhir.Model.Observation> observations = new List<Observation>();

            try
            {
                //Attempt to send the resource to the server endpoint                
                UriBuilder UriBuilderx = new UriBuilder(FhirClientEndPoint);
                UriBuilderx.Path = "Patient/" + id;
                Hl7.Fhir.Model.Resource ReturnedResource = _client.InstanceOperation(UriBuilderx.Uri, "everything");

                if (ReturnedResource is Hl7.Fhir.Model.Bundle)
                {
                    Hl7.Fhir.Model.Bundle ReturnedBundle = ReturnedResource as Hl7.Fhir.Model.Bundle;
                    foreach (var Entry in ReturnedBundle.Entry) {
                        if (Entry.Resource is Observation)
                            observations.Add((Observation)Entry.Resource);
                    }
                }
                else
                {
                    throw new Exception("Operation call must return a bundle resource");
                }

            }
            catch (Hl7.Fhir.Rest.FhirOperationException FhirOpExec)
            {
                Console.WriteLine("An error message: " + FhirOpExec.Message);
            }
            return observations;
        }

        public void updateEffective(FhirDateTime effective, Observation ob) {
            ob.Effective = effective;
            _client.Update<Observation>(ob);
        }
    }
}
