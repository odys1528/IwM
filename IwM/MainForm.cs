using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;
using Hl7.FhirPath;

namespace IwM
{
    public partial class MainForm : Form
    {
        private FhirOperations db;
        private List<Patient> patients;
        private Patient patient;
        private Bundle data; //TODO przypisać historię pacjenta
        private String lastPatientID = "0"; //Mówi, jakie jest id ostatniego pacjenta na liście
        private String firstPatientID = "0";
        private String minimalPatientID = "0";
        

        public MainForm()
        {
            InitializeComponent();
            db = new FhirOperations();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            patients = db.get20Patients(0,-1);
            lastPatientID = patients[19].Id;
            firstPatientID = patients[0].Id;
            minimalPatientID = patients[0].Id;
            
            foreach (var l in patients)
            {
                patientListBox.Items.Add(l.Id + " " + l.Name.First().Given.FirstOrDefault() + " " + l.Name.First().Family);
            }
            patientListBox.SelectedIndex = 0;
        }
        private void getPatientById(string id) //TODO zaimplementować to w HistoryForm
        {
            Patient p = null;
            List<Observation> observations = new List<Observation>();
            List<Medication> medications = new List<Medication>();
            List<MedicationStatement> medicationStatements = new List<MedicationStatement>();

            Hl7.Fhir.Model.Bundle ReturnedBundle = db.everythingById(id);
            foreach (var Entry in ReturnedBundle.Entry)
            {
                if (Entry.Resource is Patient)
                {
                    Console.WriteLine("yay");
                    p = (Patient)Entry.Resource;
                }
                if (Entry.Resource is Observation)
                    observations.Add((Observation)Entry.Resource);
                if (Entry.Resource is Medication)
                    medications.Add((Medication)Entry.Resource);
                if (Entry.Resource is MedicationStatement)
                    medicationStatements.Add((MedicationStatement)Entry.Resource);

                Console.WriteLine(string.Format("{0}/{1}", Entry.Resource.TypeName, Entry.Resource.Id));
            }
            Console.WriteLine(string.Format("{0} {1}", p.Name.First().Given.FirstOrDefault(), p.Name.First().Family));
            Period a = medicationStatements[0].Effective as Period;
            Console.WriteLine(string.Format("{0}", a.Start));



        }

        private void validateNameButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "")
            {
                patientListBox.Items.Clear();
                patients = db.patientsByName(nameTextBox.Text);
                foreach (var l in patients)
                {
                    patientListBox.Items.Add(l.Id + " " + l.Name[0].Given.FirstOrDefault() + " " + l.Name.First().Family);
                }
                //Console.WriteLine(patients.Count);
                patientListBox.SelectedIndex = 0;
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            HistoryForm form = new HistoryForm(patient, data);
            form.ShowDialog();
        }

        private void patientListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nextButton.Enabled = true;
            editPatientButton.Enabled = true;
            patient = patients[patientListBox.SelectedIndex];
        }

        private void editPatientButton_Click(object sender, EventArgs e)
        {
            //TODO nowy formularz z edycją danych pacjenta
        }

        private void backPageButton_Click(object sender, EventArgs e)
        {
            patientListBox.Items.Clear();
            List<Patient> messyPatients = new List<Patient>();
            messyPatients = db.get20Patients(-1, Int32.Parse(firstPatientID));
            patients.Clear();
            for (int i = messyPatients.Count-1; i >= 0; i--) {
                patients.Add(messyPatients[i]);
            }
            lastPatientID = patients[19].Id;
            firstPatientID = patients[0].Id;
            
            foreach (var l in patients)
            {
                patientListBox.Items.Add(l.Id + " " + l.Name.First().Given.FirstOrDefault() + " " + l.Name.First().Family);
            }
            patientListBox.SelectedIndex = 0;
            if (firstPatientID == minimalPatientID) {
                backPageButton.Enabled = false;
            }
        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            patientListBox.Items.Clear();
            patients = db.get20Patients(Int32.Parse(lastPatientID),-1);
            lastPatientID = patients[19].Id;
            firstPatientID = patients[0].Id;

            foreach (var l in patients)
            {
                patientListBox.Items.Add(l.Id + " " + l.Name.First().Given.FirstOrDefault() + " " + l.Name.First().Family);
            }
            patientListBox.SelectedIndex = 0;
            backPageButton.Enabled = true;
        }
    }
}
